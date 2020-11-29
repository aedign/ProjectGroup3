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
                label3.Text = "Enter a Project name";
                return;
            }

            label3.Text = "";
            string name = textProject.Text;
            Project project = new Project(name);
            Project exists = this.Projects.Find(p => p.Name == project.Name);
            if(exists == null){
                this.Projects.Add(project);
                listProjects.Items.Add(project);
                label3.Text = "";
                textProject.Text = "";
                return;
            }
            label3.Text = "Project already exists";

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
                label3.Text = "";
                ProjectView view = new ProjectView(p);
                view.ShowDialog();
            }
            label3.Text = "Select a Project to view";
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
            Project p = (Project) listProjects.SelectedItem;
            if(p == null)
            {
                label3.Text = "Select a Project to remove";
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Would you like to delete \"" + p.GetName() + "\"?", "Remove Project", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                Project toDelete = (Project)listProjects.SelectedItem;
                Projects.Remove(toDelete);
                listProjects.Items.Remove(toDelete);
                label3.Text = "";
            }
        }
    }
}