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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textProject.Text;
            Project project = new Project(name, "Description");
            project.AddMember(new Member("Fucktard"));
            listProjects.Items.Add(project);
        }

        private void listProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Project selectedProject = (Project) listProjects.SelectedItem;
            EditProject editProject = new EditProject();
            editProject.Name = selectedProject.Name;
            DialogResult result = editProject.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                selectedProject.Name = editProject.Name;
            }

            listProjects.Refresh();
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
    }
}