using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectIdea
{
    public partial class Form1 : Form 
        {
        public List<Project> Projects;
        public Data data = new Data();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textProject.Text.Equals("")){
                return;
            }
            
            string name = textProject.Text;
            Project project = new Project(name);
            Project exists = this.Projects.Find(p => p.Name == project.Name);
            if(exists == null){
                this.Projects.Add(project);
                listProjects.Items.Add(project);
            }
            
        }

        private void listProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listProjects.SelectedItem == null)
            {
                return;
            }

            Project selectedProject = (Project) listProjects.SelectedItem;
            EditProject editProject = new EditProject(this.Projects);
            editProject.Name = selectedProject.Name;
            DialogResult result = editProject.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                selectedProject.Name = editProject.Name;
            }
            listProjects.Items.Add(selectedProject); //find new way for editing
            listProjects.Items.Remove(selectedProject);
        
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project p = (Project)listProjects.SelectedItem;
            if (p != null){
                ProjectView view = new ProjectView(p);
                view.ShowDialog();
            }
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.setDatabase(Projects);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.checkPath();
            Projects = data.getDatabase();
            
            foreach (Project p in Projects)
            {
                if (!p.Name.Equals("empty"))
                {
                    listProjects.Items.Add(p);
                }
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Want To Delete Your Project", "Remove Project", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                Project toDelete = (Project)listProjects.SelectedItem;
                Projects.Remove(toDelete);
                listProjects.Items.Remove(toDelete);
            }
        }
    }
}