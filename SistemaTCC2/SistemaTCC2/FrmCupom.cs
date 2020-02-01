using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTCC2
{
    public partial class FrmCupom : Form
    {
        public FrmCupom()
        {
            InitializeComponent();
            
        }

        private void Cupom_Load(object sender, EventArgs e)
        {

            label6.Text = DateTime.Now.ToShortDateString();
            label7.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
