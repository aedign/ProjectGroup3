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
    public partial class EditProject : Form
    {
        public string Name { get; set; }
        public List<Project> Projects;
        public List<Member> Members;

        public EditProject(List<Project> Projects)
        {
            this.Projects = Projects;
            InitializeComponent();
        }

        public EditProject(List<Member> Members)
        {
            this.Projects = Projects;
            InitializeComponent();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            textName.Text = Name;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (textName.Text.Equals("")){
                return;
            }
            if(this.Projects != null){
                Project exists = this.Projects.Find(p => p.Name == textName.Text);
                if(exists == null){
                     Name = textName.Text;
                    return;
                }
            }
             if(this.Members != null){
               Member exists = this.Members.Find(m => m.Name == textName.Text);
                if(exists == null){
                    Name = textName.Text;
                    return;
                }
            }
        }
    }
}
