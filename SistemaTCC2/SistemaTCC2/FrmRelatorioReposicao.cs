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
    public partial class FrmRelatorioReposicao : Form
    {
        public FrmRelatorioReposicao()
        {
            InitializeComponent();
        }


        private void FrmRelatorioReposicao_Load(object sender, EventArgs e)
        {
            try
            {
                String SQL = "Select *  " +
                    "from relatorioreposicao ";

                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);




                sqlc.Open();

                MySqlCommand cmd = new MySqlCommand("Select * from relatorioreposicao", sqlc);

                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);










                Adapter.Fill(DSRelatorios, "relatorioreposicao");

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