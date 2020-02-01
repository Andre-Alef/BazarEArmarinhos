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
    public partial class FrmReposicao : Form
    {
        public FrmReposicao()
        {
            InitializeComponent();
        }

        private void FrmReposicao_Load(object sender, EventArgs e)
        {

        }

        private void txtDataEntregaPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {

                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                MySqlCommand cmd = new MySqlCommand("select* from CadastroFornecedores where NomeFornecedor = @NomeF", sqlc);

                cmd.Parameters.Add("@NomeF", MySqlDbType.VarChar);
               // cmd.Parameters["@NomeF"].Value = txtNomeFornecedor.Text;

                int es = Convert.ToInt16(cmd.ExecuteScalar());

                if (es > 0)
                {


                   
                }
                else
                {

                    MessageBox.Show("Esse Fornecedor não esta cadastrado");
            //        txtNomeFornecedor.BackColor = Color.GreenYellow;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro + "");

            }






        }

        private void txtProdutoFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {

                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                MySqlCommand cmd = new MySqlCommand("select* from CadastroProdutos where NomeProduto = @NomeP", sqlc);

                cmd.Parameters.Add("@NomeP", MySqlDbType.VarChar);
                cmd.Parameters["@NomeP"].Value = txtProdutoFornecedor.Text;

                int es = Convert.ToInt16(cmd.ExecuteScalar());

                if (es > 0)
                {



                }
                else
                {

                    MessageBox.Show("Esse Produto não esta cadastrado");
                    txtProdutoFornecedor.BackColor = Color.GreenYellow;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro + "");

            }
        }

        private void txtNomeFornecedor_Click(object sender, EventArgs e)
        {
      //      txtNomeFornecedor.BackColor = Color.White;
        }

        private void txtProdutoFornecedor_Click(object sender, EventArgs e)
        {
            txtProdutoFornecedor.BackColor = Color.White;
        }

        private void btnRepor_Click(object sender, EventArgs e)
        {
            try
            {

                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();

                /*
                MySqlCommand cmd = new MySqlCommand("Update CadastroProdutos QuantidadeProduto)" +
                     " values(@QuantProd) where NomeProduto = @NomeP", sqlc);
                     
              
                //padão antigo
                // txtsenha.Text = "@sen";
                //cmd.Parameters.Add("@sen", txtsenha.Text);

                //padrão novo


                cmd.Parameters.Add("@NomeP", MySqlDbType.VarChar);
                cmd.Parameters["@NomeP"].Value = txtProdutoFornecedor.Text;

                cmd.Parameters.Add("@QuantProd", MySqlDbType.VarChar);
                cmd.Parameters["@QuantProd"].Value = txtQuantidadeProduto.Text;
                */

                FrmConsultaProdutos frm = new FrmConsultaProdutos();

                MySqlCommand cmd2 = new MySqlCommand("insert into reposicao(DataEntregaRep,DataVencimentoRep,ParcelasRep,PrecoRep,QuantidadeRep,IDProduto)  "
                    + "values (@dtEntregarep,@dtVencimentorep,@parRep,@precoRep,@QuantRep,@ID)", sqlc);

                cmd2.Parameters.Add("@dtEntregarep", MySqlDbType.VarChar);
                cmd2.Parameters["@dtEntregarep"].Value = txtDataEntregaPF.Text;

                cmd2.Parameters.Add("@dtVencimentorep", MySqlDbType.VarChar);
                cmd2.Parameters["@dtVencimentorep"].Value = mskVencimento.Text;

                cmd2.Parameters.Add("@parRep", MySqlDbType.Int16);
                cmd2.Parameters["@parRep"].Value = txtParcelasReposicao.Text;

                cmd2.Parameters.Add("@precoRep", MySqlDbType.Double);
                cmd2.Parameters["@precoRep"].Value = txtPrecoProduto.Text;

                cmd2.Parameters.Add("@QuantRep", MySqlDbType.Int16);
                cmd2.Parameters["@QuantRep"].Value = txtQuantidadeProduto.Text;

                FrmConsultaProdutos frm2 = new FrmConsultaProdutos();

                cmd2.Parameters.Add("@ID", MySqlDbType.Int16);
                cmd2.Parameters["@ID"].Value = txtIDProduto.Text ;

             

                //  cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Dados Cadastrados com Sucesso!!");
                txtProdutoFornecedor.Text = "";
                txtPrecoProduto.Text = "";
                txtQuantidadeProduto.Text = "";
                
                
                
            }

            catch (MySqlException erro)
            {
                MessageBox.Show(erro + "");


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
