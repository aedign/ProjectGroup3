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
        public EditProject()
        {
            InitializeComponent();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            textName.Text = Name;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Name = textName.Text;
        }
    }
}
