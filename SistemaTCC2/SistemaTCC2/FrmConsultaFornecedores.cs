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
    public partial class FrmConsultaFornecedores : Form
    {
        public FrmConsultaFornecedores()
        {
            InitializeComponent();
            btnAlterar.Visible = (false);
        }

        private void ConsultaFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                String SQL = "Delete From CadastroFornecedores Where IDFornecedor = @ID";
                MySqlCommand cmd = new MySqlCommand(SQL, sqlc);

                cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!!");
             button1_Click(sender, e);


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String SQL = "Select*from CadastroFornecedores where NomeFornecedor like @NomeF ";
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();




                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);


               
                Adapter.SelectCommand.Parameters.Add("@NomeF", MySqlDbType.VarChar).Value = TxtDesc.Text + "%";


                DataSet DS = new DataSet();

                Adapter.Fill(DS, "CadastroFornecedores");
                DgConsulta.DataSource = DS.Tables["CadastroFornecedores"];


                DgConsulta.ContextMenuStrip = contextMenuStrip1;
                btnAlterar.Visible = (true);
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



                MySqlCommand cmd = new MySqlCommand("Update CadastroFornecedores Set NomeFornecedor = @NomeF, CNPJ = @CNPJF, ProdutoEntregue = @ProdEnt,TelefoneFornecedor = @TelFor,TelefoneFornecedor =@TelFor2, " +
            "PrecoProdutoForn =@PrecoPF, QuantidadeProdutoF=@QuantPF,DataEntregaF =@DataEntF, EmailFornecedor =@EmailF,Representante = @Repr" +
                     "  Where IDFornecedor = @ID", sqlc);
                //    String SQL = "Update Produtos Set Descricao=@desc,Unidade=@unid,Categoria=@cat,Valor=@val Where ID = @ID";

               
                var pr = cmd.Parameters;
                pr.Add("@NomeF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[1].Value.ToString();

                pr.Add("@CNPJF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[2].Value.ToString();

                pr.Add("@ProdEnt", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[3].Value.ToString();

                pr.Add("@TelFor", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[4].Value.ToString();

                pr.Add("@TelFor2", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[5].Value.ToString();

                pr.Add("@PrecoPF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[6].Value.ToString();

                pr.Add("@QuantPF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[7].Value.ToString();

                pr.Add("@DataEntF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[8].Value.ToString();

                pr.Add("@EmailF", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[9].Value.ToString();

                pr.Add("Repr", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[10].Value.ToString();

                pr.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();


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
    }
}
