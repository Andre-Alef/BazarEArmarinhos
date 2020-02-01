using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SistemaTCC2
{
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            try
            {


                String SQL = "Select IDCliente, NomeCliente,TelefoneCliente,CelularCliente,EmailCliente," +
    "EnderecoCliente,BairroCliente,NumeroCliente,CPFCliente from CadastroClientes";
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);


              

                    sqlc.Open();

                    MySqlCommand cmd = new MySqlCommand("Select IDCliente, NomeCliente,TelefoneCliente,CelularCliente,EmailCliente," +
    "EnderecoCliente,BairroCliente,NumeroCliente,CPFCliente from CadastroClientes", sqlc);

                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);




             

               

               

                Adapter.Fill(DSRelatorios, "CadastroClientes");
              
                sqlc.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
                this.reportViewer1.RefreshReport();
            }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }