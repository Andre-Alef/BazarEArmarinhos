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
    public partial class FrmConsultaProdutos : Form
    {
        public FrmConsultaProdutos()
        {
            InitializeComponent();
            btnAlterar.Visible = (false);
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

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


                String SQL = "Delete  From CadastroProdutos Where IDProduto = @ID";
                MySqlCommand cmd = new MySqlCommand(SQL, sqlc);

                cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!!");

                btnConsultarProdutos_Click(sender, e);


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void btnConsultarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                String SQL = "Select*from CadastroProdutos Where NomeProduto like @NomeProd ";
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();




                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);


        
                Adapter.SelectCommand.Parameters.Add("@NomeProd", MySqlDbType.VarChar).Value =TxtDesc.Text + "%";


                DataSet DS = new DataSet();

                Adapter.Fill(DS, "CadastroProdutos");
                DgConsulta.DataSource = DS.Tables["CadastroProdutos"];



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



                MySqlCommand cmd = new MySqlCommand("Update CadastroProdutos Set NomeProduto = @NomeProd, TipoProduto = @TipProd,PrecoProduto = @PrecProd,FrequenciaProduto = @FreqProd," +
            "QuantidadeProduto = @QuantProd,DescricaoProduto = @DescProd" +
                     "  Where IDProduto = @ID", sqlc);
                //    String SQL = "Update Produtos Set Descricao=@desc,Unidade=@unid,Categoria=@cat,Valor=@val Where ID = @ID";


                var pr = cmd.Parameters;
                pr.Add("@NomeProd", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[1].Value.ToString();

                pr.Add("@TipProd", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[2].Value.ToString();

                pr.Add("@PrecProd", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[3].Value.ToString();

                pr.Add("@FreqProd", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[4].Value.ToString();

                pr.Add("@QuantProd", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[5].Value.ToString();

                pr.Add("@DescProd", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[6].Value.ToString();

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
                    btnConsultarProdutos_Click(sender, e);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReposicao frm = new FrmReposicao();
            frm.TopMost = true;
            frm.Show();

           

            frm.txtProdutoFornecedor.Text = DgConsulta.SelectedCells[1].Value.ToString();
            frm.txtIDProduto.Text = DgConsulta.SelectedCells[0].Value.ToString();

        }
    }
}
