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

        public ProjectView(Project project)
        {
            InitializeComponent();

            this.p = project;
            labelProjectName.Text = p.Name;
            richTextBox1.Text = p.GetDescription();
            if (p.Manager == null || p.Manager.Equals(""))
            {
                label6.Text = "(Set Manager)";
            }
            else
            {
                label6.Text = p.Manager;
            }
            

            foreach (Member member in p.GetMembers())
            {
                listMembers.Items.Add(member);
            }

            foreach (string fr in p.GetFunctionalRequirements())
            {
                listFunctionalities.Items.Add(fr);
            }

        }

        private void labelProjectName_Click(object sender, EventArgs e)
        {
            labelProjectName.Text = p.Name;
        }


        private void buttonAddMembers_Click(object sender, EventArgs e)
        {
            if (textBoxMembers.Text.Equals(""))
            {
                return;
            }
            string name = textBoxMembers.Text;
            Member member = new Member(name);
            Member exists = this.p.GetMembers().Find(m => m.Name == member.Name);
            if (exists == null)
            {
                p.AddMember(member);
                listMembers.Items.Add(member);
            }
        }

        private void listMembers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Member selectedMembers = (Member)listMembers.SelectedItem;
            EditProject editProject = new EditProject(this.p.GetMembers());
            editProject.Name = selectedMembers.Name;
            DialogResult result = editProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedMembers.Name = editProject.Name;
            }

            listMembers.Items.Remove(selectedMembers);
            listMembers.Items.Add(selectedMembers);
        }

        private void listBoxRisk_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*Risk selectedRisk = (Risk)listBoxRisk.SelectedItem;
            FormRisk editRisk = new FormRisk(this.p.GetRisks());
            editRisk*/
        }

        private void buttonAddFunctionalities_Click(object sender, EventArgs e)
        {
            if (textBoxFunctionalities.Text.Equals(""))
            {
                return;
            }
            string FunctionalRequirement = textBoxFunctionalities.Text;

            List<string> fr = this.p.GetFunctionalRequirements();

            if (!fr.Contains(FunctionalRequirement))
            {
                p.AddFunctionalRequirement(FunctionalRequirement);
                listFunctionalities.Items.Add(FunctionalRequirement);
            }
        }
        private void listFunctionalities_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fr = (string)listFunctionalities.SelectedItem;
            EditProject editProject = new EditProject(this.p.GetFunctionalRequirements(), true);
            editProject.Name = fr;
            DialogResult result = editProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                listFunctionalities.Items.Remove(fr);
                p.RemoveFunctionalRequirement(fr);
                fr = editProject.Name;
            }
            listFunctionalities.Items.Add(fr);
            p.AddFunctionalRequirement(fr);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            p.SetDescription(richTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProject editProject = new EditProject();
            editProject.Name = label6.Text;

            DialogResult result = editProject.ShowDialog();
            if (result == DialogResult.OK)
            {
                label6.Text = editProject.Name;
                p.Manager = label6.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member selectedMember = (Member)listMembers.SelectedItem;
            listMembers.Items.Remove(selectedMember);
            p.RemoveMember(selectedMember);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fr = (string)listFunctionalities.SelectedItem;
            listFunctionalities.Items.Remove(fr);
            p.RemoveFunctionalRequirement(fr);
        }
    }
}
