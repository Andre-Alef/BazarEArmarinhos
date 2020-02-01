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
using SistemaTCC2.Correios;

namespace SistemaTCC2
{
    public partial class FrmCadastroClientes : Form
    {
        public String IDCliente;
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao cn = new conexao();

            MySqlConnection sqlc = new MySqlConnection(cn.conn);

            sqlc.Open();


            // SqlCommand cqlc = new SqlCommand("insert into Usuarios(senha,login,nome,endereco)values('1234','adm','alef','rua minie')", sqlc);
            MySqlCommand cmd = new MySqlCommand("insert into CadastroClientes(NomeCliente,TelefoneCliente,CelularCliente,EmailCliente," +
    "EnderecoCliente,BairroCliente,NumeroCliente,CPFCliente)" +
             " values(@NomeC,@TelC,@CelC,@EmailC,@EndCliente,@BairroC,@NumCliente,@CPF)", sqlc);

            //padão antigo
            // txtsenha.Text = "@sen";
            //cmd.Parameters.Add("@sen", txtsenha.Text);

            // padrão novo
            cmd.Parameters.Add("@NomeC", MySqlDbType.VarChar);
            cmd.Parameters["@NomeC"].Value = txtNomeCliente.Text;

            cmd.Parameters.Add("@TelC", MySqlDbType.VarChar);
            cmd.Parameters["@TelC"].Value = txtTelefoneCliente.Text;

            cmd.Parameters.Add("@CelC", MySqlDbType.VarChar);
            cmd.Parameters["@CelC"].Value = txtCelularCliente.Text;

            cmd.Parameters.Add("@EmailC", MySqlDbType.VarChar);
            cmd.Parameters["@EmailC"].Value = txtEmailCliente.Text;


            cmd.Parameters.Add("@EndCliente", MySqlDbType.VarChar);
            cmd.Parameters["@EndCliente"].Value = txtEnderecoCliente.Text;


            cmd.Parameters.Add("@BairroC", MySqlDbType.VarChar);
            cmd.Parameters["@BairroC"].Value = txtBairroCliente.Text;



            cmd.Parameters.Add("@NumCliente", MySqlDbType.VarChar);
            cmd.Parameters["@NumCliente"].Value = txtNumeroCliente.Text;


            cmd.Parameters.Add("@CPF", MySqlDbType.VarChar);
            cmd.Parameters["@CPF"].Value = txtCPFCliente.Text;


            cmd.ExecuteNonQuery();
            MessageBox.Show("Dados cadastrados com sucesso !!");
            txtNomeCliente.Text = "";
            txtTelefoneCliente.Text = "";
            txtCelularCliente.Text = "";
            txtEmailCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtBairroCliente.Text = "";
            txtNumeroCliente.Text = "";
            txtCPFCliente.Text = "";
            mskCEP.Text = "";
            txtMuniciopioCliente.Text = "";
            txtComplemento.Text = "";
            
        }

    
        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

           


            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void txtEnderecoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefoneCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCelularCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

  
        private void txtNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo não aceita espaços!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBairroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCPFCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo não aceita espaços!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            AtendeClienteClient cliente = new AtendeClienteClient();

            Correios.enderecoERP Endereco = cliente.consultaCEP(mskCEP.Text);
            txtEnderecoCliente.Text = Endereco.end;
            txtBairroCliente.Text = Endereco.bairro;
            txtMuniciopioCliente.Text = Endereco.cidade;
           // txtEstado.Text = Endereco.uf;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBairroCliente_TextChanged(object sender, EventArgs e)
        {
            txtBairroCliente.BackColor = Color.White;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void po_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroCliente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                txtNomeCliente.BackColor = Color.Red;
                MessageBox.Show("O Nome do cliente não foi preenchido!!");


            }
        }

        private void txtNomeCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.BackColor = Color.White;
        }

        private void txtTelefoneCliente_Leave(object sender, EventArgs e)
        {
            if (txtTelefoneCliente.Text == "")
            {
                txtTelefoneCliente.BackColor = Color.Red;
                MessageBox.Show("O Telefone do cliente não foi preenchido!!");


            }
        }

        private void txtCelularCliente_Leave(object sender, EventArgs e)
        {
            if (txtCelularCliente.Text == "")
            {
                txtCelularCliente.BackColor = Color.Red;
                MessageBox.Show("O Celular do cliente não foi preenchido!!");


            }
        }

        private void txtEmailCliente_Leave(object sender, EventArgs e)
        {
            if (txtEmailCliente.Text == "")
            {
                txtEmailCliente.BackColor = Color.Red;
                MessageBox.Show("O Nome do cliente não foi preenchido!!");


            }
        }

        private void txtCPFCliente_Leave(object sender, EventArgs e)
        {
            if (txtCPFCliente.Text == "")
            {
                txtCPFCliente.BackColor = Color.Red;
                MessageBox.Show("O CPF do cliente não foi preenchido!!");


            }
        }

        private void txtTelefoneCliente_Click(object sender, EventArgs e)
        {
            txtTelefoneCliente.BackColor = Color.White;
        }

        private void txtCelularCliente_Click(object sender, EventArgs e)
        {
            txtCelularCliente.BackColor = Color.White;
        }

        private void txtEmailCliente_Click(object sender, EventArgs e)
        {
            txtEmailCliente.BackColor = Color.White;
        }

        private void txtCPFCliente_Click(object sender, EventArgs e)
        {
            txtCPFCliente.BackColor = Color.White;
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            if (mskCEP.Text == "#####-###")
            {
                mskCEP.BackColor = Color.Red;
                MessageBox.Show("O Nome do cliente não foi preenchido!!");


            }
        }

        private void mskCEP_Click(object sender, EventArgs e)
        {
            mskCEP.BackColor = Color.White;
        }

        private void txtEnderecoCliente_Leave(object sender, EventArgs e)
        {
            if (txtEnderecoCliente.Text == "")
            {
                txtEnderecoCliente.BackColor = Color.Red;
                MessageBox.Show("A rua do cliente não foi preenchido!!");


            }
        }

        private void txtMuniciopioCliente_Click(object sender, EventArgs e)
        {
         

            txtMuniciopioCliente.BackColor = Color.White;
        }

        private void txtBairroCliente_Click(object sender, EventArgs e)
        {
          
            txtBairroCliente.BackColor = Color.White;
        }

        private void txtComplemento_Click(object sender, EventArgs e)
        {
          
            txtComplemento.BackColor = Color.White;
        }

        private void txtNumeroCliente_Leave(object sender, EventArgs e)
        {
            if (txtNumeroCliente.Text == "")
            {
                txtNumeroCliente.BackColor = Color.Red;
                MessageBox.Show("O Número do cliente não foi preenchido!!");


            }
        }

        private void txtEnderecoCliente_Click(object sender, EventArgs e)
        {
            txtEnderecoCliente.BackColor = Color.White;
        }

        private void txtMuniciopioCliente_Leave(object sender, EventArgs e)
        {
            if (txtMuniciopioCliente.Text == "")
            {
                txtMuniciopioCliente.BackColor = Color.Red;
                MessageBox.Show("O Município do cliente não foi preenchido!!");


            }
        }

        private void txtBairroCliente_Leave(object sender, EventArgs e)
        {
            if (txtBairroCliente.Text == "")
            {
                txtBairroCliente.BackColor = Color.Red;
                MessageBox.Show("O Bairro do cliente não foi preenchido!!");


            }
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            if (txtComplemento.Text == "")
            {
                txtComplemento.BackColor = Color.Red;
                MessageBox.Show("O Complemento não foi preenchido!!");


            }
        }

        private void txtNumeroCliente_Click(object sender, EventArgs e)
        {
            txtNumeroCliente.BackColor = Color.White;
        }

        private void txtEnderecoCliente_TextChanged(object sender, EventArgs e)
        {
           txtEnderecoCliente.BackColor = Color.White;
        }

        private void txtMuniciopioCliente_TextChanged(object sender, EventArgs e)
        {
            txtMuniciopioCliente.BackColor = Color.White;
        }
    }
}