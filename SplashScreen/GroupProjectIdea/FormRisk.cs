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
    public partial class FormRisk : Form
    {

        public string Name { get; set; }
        List<Risk> Risks;

        public FormRisk(List<Risk> Risks)
        {
            this.Risks = Risks;
            InitializeComponent();
        }

        private void FormRisk_Load(object sender, EventArgs e)
        {
            textBox1.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Text
        }
    }
}
