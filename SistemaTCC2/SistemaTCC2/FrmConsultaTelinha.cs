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
    public partial class FrmConsultaTelinha : Form
    {
        AbrirFechar abrirFechar = new AbrirFechar();
        public FrmConsultaTelinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmConsultaCliente)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmConsultaFornecedores)));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmConsultaProdutos)));
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            abrirFechar.OpenForm((typeof(FrmConsultaUsuarios)));
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            abrirFechar.OpenForm((typeof(FrmConsultaFuncionarios)));
         

        }

        private void FrmConsultaTelinha_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
