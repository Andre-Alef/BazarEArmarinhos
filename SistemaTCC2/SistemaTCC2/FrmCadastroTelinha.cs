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
    public partial class FrmCadastroTelinha : Form
    {
        AbrirFechar abrirFechar = new AbrirFechar();
        public FrmCadastroTelinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           abrirFechar.OpenForm((typeof(FrmCadastroClientes)));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmCadastroFornecedores)));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmCadastroProdutos)));
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmCadastroDeUsuarios)));
            
        }

        private void CadastroTelinha_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmCadastroFuncionarios)));
            
        }

      

        private void CadastroTelinha_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroTelinha_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
