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
    public partial class ProjectView : Form
    {
        private Project p;
        private void labelProjectName_Click(object sender, EventArgs e)
        {
            labelProjectName.Text = p.Name;
        }
        public ProjectView(Project project)
        {
            InitializeComponent();
            this.p = project;
            foreach (Member member in p.GetMembers()) {
                listMembers.Items.Add(member);
            }
            
            labelProjectName.Text = p.Name;
        }

        private void buttonAddMembers_Click(object sender, EventArgs e)
        {
            string name = textBoxMembers.Text;
            Member member = new Member(name);
            p.AddMember(member);
            listMembers.Items.Add(member);
        }

        private void listMembers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Member selectedMembers = (Member)listMembers.SelectedItem;
            EditProject editProject = new EditProject();
            editProject.Name = selectedMembers.Name;
            DialogResult result = editProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedMembers.Name = editProject.Name;
            }

            listMembers.Items.Remove(selectedMembers);
            listMembers.Items.Add(selectedMembers);
        }
    }
}
