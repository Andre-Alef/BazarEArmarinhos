using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Sql;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemaTCC2
{
    public partial class FrmConsultaUsuarios : Form
    {
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
            btnAlterar.Visible = (false);
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                String SQL = "Delete From CadastroUsuarios Where IDUsuario = @ID";
                MySqlCommand cmd = new MySqlCommand(SQL, sqlc);

                cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!!");
               btnConsultarUsuario_Click(sender, e);


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                String SQL = "Select * from CadastroUsuarios where Login like @log";
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();




                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);


                Adapter.SelectCommand.Parameters.Add("@log", MySqlDbType.VarChar).Value = TxtDesc.Text + "%";


                DataSet DS = new DataSet();

                Adapter.Fill(DS, "CadastroUsuarios");
                DgConsulta.DataSource = DS.Tables["CadastroUsuarios"];


                DgConsulta.ContextMenuStrip = contextMenuStrip1;

                sqlc.Close();
                btnAlterar.Visible = (true);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();



                MySqlCommand cmd = new MySqlCommand("Update CadastroUsuarios Set login =" +
                    " @log, senha = @sen  Where IDUsuario = @ID ", sqlc);
                // UPDATE clientes SET nome = 'Rafael', email = 'contato@rlsystem.com.br' WHERE id = 1;
                //    String SQL = "Update Produtos Set Descricao=@desc,Unidade=@unid,Categoria=@cat,Valor=@val Where ID = @ID";


                var pr = cmd.Parameters;


                pr.Add("@log", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[1].Value.ToString();

                pr.Add("@sen", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[2].Value.ToString(); ;

              //  pr.Add("@conf", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[3].Value.ToString(); ;

                pr.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString(); ;



                //    pr.Add("@ID", MySqlDbType.Int16).Value = IDUsuario;


                DialogResult Resp;

                Resp = MessageBox.Show("Tem certeza de que deseja Alterar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resp == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Alteração teve sucesso");
                }
                else
                {


                    TxtDesc.Text = "";
                    MessageBox.Show("Alteração Cancelada");
                    btnConsultarUsuario_Click(sender, e);



                }
            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
