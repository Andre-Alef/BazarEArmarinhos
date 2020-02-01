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
    public partial class FrmFerramentasTelinha : Form
    {
        public FrmFerramentasTelinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\calc.exe");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  System.Diagnostics.Process.Start(@"C:\Windows\system32\cal.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\system32\notepad.exe");
            this.Close();
        }

        private void ferramentasTelinha_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
