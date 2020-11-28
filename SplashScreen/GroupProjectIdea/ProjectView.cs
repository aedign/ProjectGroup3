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
            if(p.GetDescription() == null)
            {
                richTextBox1.Text = "";
            }
            else
            {
                richTextBox1.Text = p.GetDescription();
            }
            
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

            foreach (string nfr in p.GetNonFunctionalRequirements())
            {
                listBox3.Items.Add(nfr);
            }

            foreach (Risk r in p.GetRisks())
            {
                listBoxRisk.Items.Add(r.GetName() + "   - Status: " + r.GetStatus());
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

            if (listMembers.SelectedItem == null)
            {
                return;
            }

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

            if (listFunctionalities.SelectedItem == null)
            {
                return;
            }

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

        //non-functional requirements VVV
        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null)
            {
                return;
            }

            string nfr = (string)listBox3.SelectedItem;
            EditProject editProject = new EditProject(this.p.GetNonFunctionalRequirements(), false);
            editProject.Name = nfr;
            DialogResult result = editProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                listBox3.Items.Remove(nfr);
                p.RemoveNonFunctionalRequirement(nfr);
                nfr = editProject.Name;
            }
            listBox3.Items.Add(nfr);
            p.AddNonFunctionalRequirement(nfr);
        }

        private void buttonAdd3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                return;
            }
            string NonFunctionalRequirement = textBox3.Text;

            List<string> nfr = this.p.GetNonFunctionalRequirements();

            if (!nfr.Contains(NonFunctionalRequirement))
            {
                p.AddNonFunctionalRequirement(NonFunctionalRequirement);
                listBox3.Items.Add(NonFunctionalRequirement);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nfr = (string) listBox3.SelectedItem;
            listBox3.Items.Remove(nfr);
            p.RemoveNonFunctionalRequirement(nfr);
        }

        private void buttonAdd4_Click(object sender, EventArgs e)
        {

            if (textBox4.Text.Equals(""))
            {
                return;
            }

            string riskName = (string) textBox4.Text;
            string riskStatus = (string)comboBox1.Text;
            Risk newRisk = new Risk(riskName, riskStatus);

            Risk exists = this.p.GetRisks().Find(r => r.GetName().Equals(newRisk.GetName()));

            if (exists == null)
            {
                p.AddRisk(newRisk);
                listBoxRisk.Items.Add(newRisk.GetName() + "   - Status: " + newRisk.GetStatus());
            }

        }

        private void listBoxRisk_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxRisk.SelectedItem == null)
            {
                return;
            }
            string RiskString = (string) listBoxRisk.SelectedItem;
            string name = "";
            string[] array = RiskString.Split('-');
            name = array[0].Trim();

            Risk current = this.p.GetRisks().Find(r => r.GetName().Equals(name));

            FormRisk editRisk = new FormRisk(this.p.GetRisks());
            editRisk.Name = current.GetName();
            editRisk.Status = current.GetStatus();

            DialogResult result = editRisk.ShowDialog();

            listBoxRisk.Items.Remove(current.GetName() + "   - Status: " + current.GetStatus());

            if (result == DialogResult.OK)
            {
                current.SetName(editRisk.Name);
                current.SetStatus(editRisk.Status);
            }

           
            listBoxRisk.Items.Add(current.GetName() + "   - Status: " + current.GetStatus());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string RiskString = (string)listBoxRisk.SelectedItem;
            string name = "";
            string[] array = RiskString.Split('-');
            name = array[0].Trim();

            Risk current = this.p.GetRisks().Find(r => r.GetName().Equals(name));

            listBoxRisk.Items.Remove(current.GetName() + "   - Status: " + current.GetStatus());
            p.RemoveRisk(current);
            
        }
    }
}
