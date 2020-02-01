using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SistemaTCC2
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
            btnAlterar.Visible = (false);
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
             {
                    String SQL = "Select*from CadastroClientes where NomeCliente like @NomeC ";
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();




                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);
              

              
                Adapter.SelectCommand.Parameters.Add("@NomeC", MySqlDbType.VarChar).Value = TxtDesc.Text + "%";


                DataSet DS = new DataSet();

                     Adapter.Fill(DS, "CadastroClientes");
                     DgConsulta.DataSource = DS.Tables["CadastroClientes"];
                     this.TxtDesc.DataSource = DS.Tables["CadastroClientes"];
                     this.TxtDesc.DisplayMember = "NomeCliente";       

                     

                      DgConsulta.ContextMenuStrip = contextMenuStrip1;

                btnAlterar.Visible = (true);
            }
                 catch (Exception Erro)
                 {
                     MessageBox.Show(Erro.Message);
                 }
         


        }
        private void Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                String SQL = "Delete From CadastroClientes Where IDCliente = @ID";
                MySqlCommand cmd = new MySqlCommand(SQL, sqlc);

                cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();
                cmd.ExecuteNonQuery();

                button1_Click(sender, e);
                MessageBox.Show("Dados Excluidos com Sucesso!!");

            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();



                MySqlCommand cmd = new MySqlCommand("Update CadastroClientes Set NomeCliente = @NomeC, TelefoneCliente " +
                    "= @TelC,CelularCliente = @CelC,EmailCliente = @EmailC," +
            "EnderecoCliente = @EndCliente,BairroCliente = @BairroC,NumeroCliente = @NumCliente,CPFCliente =@CPF" +
                     "  Where IDCliente = @ID", sqlc);
                //    String SQL = "Update Produtos Set Descricao=@desc,Unidade=@unid,Categoria=@cat,Valor=@val Where ID = @ID";


                var pr = cmd.Parameters;
                pr.Add("@NomeC", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[1].Value.ToString();

                pr.Add("@TelC", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[2].Value.ToString();

                pr.Add("@CelC", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[3].Value.ToString();

                pr.Add("@EmailC", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[4].Value.ToString();

                pr.Add("@EndCliente", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[5].Value.ToString();

                pr.Add("@BairroC", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[6].Value.ToString();

                pr.Add("@NumCliente", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[7].Value.ToString();

                pr.Add("@CPF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[8].Value.ToString();


                pr.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();
                DialogResult Resp;

                Resp = MessageBox.Show("Tem certeza de que deseja Alterar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resp == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Alteração teve sucesso");
                }
                else if (Resp == DialogResult.No)
                {

                    TxtDesc.Text = "";
                    MessageBox.Show("Alteração Cancelada");
                    button1_Click(sender, e);
                }

            
      
              
                sqlc.Close();


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

        private void TxtDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
