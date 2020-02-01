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
    public partial class FrmCadastroProdutos : Form
    {
        public String IDProduto;
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                MySqlCommand cmd = new MySqlCommand("insert into CadastroProdutos(NomeProduto,TipoProduto,PrecoProduto,FrequenciaProduto," +
              "QuantidadeProduto,DescricaoProduto)" +
                     " values(@NomeP,@TipProd,@PrecProd,@FreqProd,@QuantProd,@DescProd)", sqlc);

                //padão antigo
                // txtsenha.Text = "@sen";
                //cmd.Parameters.Add("@sen", txtsenha.Text);

                //padrão novo
                cmd.Parameters.Add("@NomeP", MySqlDbType.VarChar);
                cmd.Parameters["@NomeP"].Value = txtNomeProduto.Text;

                cmd.Parameters.Add("@TipProd", MySqlDbType.VarChar);
                cmd.Parameters["@TipProd"].Value = txtTipoProduto.Text;

                cmd.Parameters.Add("@PrecProd", MySqlDbType.Double);
                cmd.Parameters["@PrecProd"].Value = txtPrecoProduto.Text;

                cmd.Parameters.Add("@FreqProd", MySqlDbType.VarChar);
               


                cmd.Parameters.Add("@QuantProd", MySqlDbType.VarChar);
                cmd.Parameters["@QuantProd"].Value = txtQuantidadeProduto.Text;


                cmd.Parameters.Add("@DescProd", MySqlDbType.VarChar);
                cmd.Parameters["@DescProd"].Value = txaDescricao.Text;




                cmd.ExecuteNonQuery();

                MessageBox.Show("Dadso Cadastrados com Sucesso!!");
                txtNomeProduto.Text = "";
                txtPrecoProduto.Text = "";
                txtQuantidadeProduto.Text = "";
                txtTipoProduto.Text = "";
                txaDescricao.Text = "";
                
            }

            catch (MySqlException erro)
            {
                MessageBox.Show(erro + "");


            }

        }

        private void txtNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTipoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txaDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmReposicao rp = new FrmReposicao();
            rp.Show();
            this.Close();
        }
    }
}
