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
        public string Status { get; set; }
        List<Risk> Risks;

        public FormRisk(List<Risk> Risks)
        {
            this.Risks = Risks;
            InitializeComponent();
        }

        private void FormRisk_Load(object sender, EventArgs e)
        {
            textBox1.Text = Name;
            comboBox1.Text = Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                return;
            }

            Risk exists = this.Risks.Find(r => r.GetName() == textBox1.Text);
            if (exists == null || exists.GetStatus().Equals(this.Status))
            {
                Name = textBox1.Text;
                Status = (string) comboBox1.SelectedItem;
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
