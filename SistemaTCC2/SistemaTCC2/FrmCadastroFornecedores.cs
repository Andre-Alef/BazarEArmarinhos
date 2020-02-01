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
    public partial class FrmCadastroFornecedores : Form
    {
        public String IDFornecedor;
        public FrmCadastroFornecedores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                //  SqlCommand cqlc = new SqlCommand("insert into Usuarios(senha,login,nome,endereco)values('1234','adm','alef','rua minie')", sqlc);
                MySqlCommand cmd = new MySqlCommand("insert into CadastroFornecedores(NomeFornecedor,CNPJ,ProdutoEntregue,TelefoneFornecedor,TelefoneFornecedor2," +
                        "PrecoProdutoForn,QuantidadeProdutoF,DataEntregaF,EmailFornecedor,Representante)" +
                       " values(@NomeF,@CNPJF,@ProdEnt,@TelFor,@TelFor2,@PrecoPF,@QuantPF,@DataEntF,@EmailF,@Repr)", sqlc);

                //padão antigo
                // txtsenha.Text = "@sen";
                //cmd.Parameters.Add("@sen", txtsenha.Text);

                //padrão novo
                cmd.Parameters.Add("@NomeF", MySqlDbType.VarChar);
                cmd.Parameters["@NomeF"].Value = txtNomeFornecedor.Text;

                cmd.Parameters.Add("@CNPJF", MySqlDbType.VarChar);
                cmd.Parameters["@CNPJF"].Value = txtCNPJFornecedor.Text;

                cmd.Parameters.Add("@ProdEnt", MySqlDbType.VarChar);
                cmd.Parameters["@ProdEnt"].Value = txtProdutoFornecedor.Text;

                cmd.Parameters.Add("@TelFor", MySqlDbType.VarChar);
                cmd.Parameters["@TelFor"].Value = txtTelefoneFornecedor.Text;

                cmd.Parameters.Add("@TelFor2", MySqlDbType.VarChar);
                cmd.Parameters["@TelFor2"].Value = txtTelefoneFornecedor2.Text;


                cmd.Parameters.Add("@PrecoPF", MySqlDbType.VarChar);
                cmd.Parameters["@PrecoPF"].Value = txtPrecoPFornecedor.Text;


                cmd.Parameters.Add("@QuantPF", MySqlDbType.VarChar);
                cmd.Parameters["@QuantPF"].Value = txtQuantidadePFornecedor.Text;



                cmd.Parameters.Add("@DataEntF", MySqlDbType.VarChar);
                cmd.Parameters["@DataEntF"].Value = txtDataEntregaPF.Text;


                cmd.Parameters.Add("@EmailF", MySqlDbType.VarChar);
                cmd.Parameters["@EmailF"].Value = txtEmailFornecedor.Text;

                cmd.Parameters.Add("@Repr", MySqlDbType.VarChar);
                cmd.Parameters["@Repr"].Value = mstRepresentante.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso!!");

                txtNomeFornecedor.Text = "";
                txtCNPJFornecedor.Text = "";
                txtProdutoFornecedor.Text = "";
                txtTelefoneFornecedor.Text = "";
                txtDataEntregaPF.Text = "";
                txtEmailFornecedor.Text = "";
                txtPrecoPFornecedor.Text = "";
                txtQuantidadePFornecedor.Text = "";
                txtTelefoneFornecedor2.Text = "";
                mstRepresentante.Text = "";
            }
            catch (Exception erro){

                MessageBox.Show(erro +"");
            }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtProdutoFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEmailFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) )
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCNPJFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefoneFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefoneFornecedor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPrecoPFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtQuantidadePFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtDataEntregaPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text == "")
            {
                txtNomeFornecedor.BackColor = Color.Red;
                MessageBox.Show("O Nome do Fornecedor não foi preenchido!!");


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
