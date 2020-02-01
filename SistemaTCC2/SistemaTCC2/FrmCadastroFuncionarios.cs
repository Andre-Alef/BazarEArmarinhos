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
    public partial class FrmCadastroFuncionarios : Form
    {
        public String IDFuncionario;
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();

                SqlConnection sqlc = new SqlConnection(cn.conn);

                sqlc.Open();


                // SqlCommand cqlc = new SqlCommand("insert into Usuarios(senha,login,nome,endereco)values('1234','adm','alef','rua minie')", sqlc);
                SqlCommand cmd = new SqlCommand("insert into CadastroFuncipnarios(NomeFuncionario,IdadeFuncionario,RGFfuncionario,CPFfuncionario," +
        "SexoFuncionario,EnderecoFuncionario,BairroFuncionario,TelefoneFuncionario,CelularFuncinario,FuncaoFuncionario,SalarioFuncionario)" +
                 " values(@NomeFunc,@IdadeFunc,@RGFunc,@CPFfunc,@SexoFunc,@EnderecoFunc,@BairroFunc,@TelFunc,CelFunc,@FuncaoFunc,@SalarioFunc)", sqlc);

                //padão antigo
                // txtsenha.Text = "@sen";
                //cmd.Parameters.Add("@sen", txtsenha.Text);

                // padrão novo
                cmd.Parameters.Add("@NomeFunc", SqlDbType.VarChar);
                cmd.Parameters["@NomeFunc"].Value = txtNomeFuncionario.Text;

                cmd.Parameters.Add("@IdadeFunc", SqlDbType.VarChar);
                cmd.Parameters["@IdadeFunc"].Value = txtIdadeFuncionario.Text;

                cmd.Parameters.Add("@RGFunc", SqlDbType.VarChar);
                cmd.Parameters["@RGFunc"].Value = mtbRGfuncionario.Text;

                cmd.Parameters.Add("@CPFfunc", SqlDbType.VarChar);
                cmd.Parameters["@CPFfunc"].Value = mtbCPFfuncionario.Text;


                cmd.Parameters.Add("@SexoFunc", SqlDbType.VarChar);
                cmd.Parameters["@SexoFunc"].Value = cboSexoFuncionario.Text;


                cmd.Parameters.Add("@EnderecoFunc", SqlDbType.VarChar);
                cmd.Parameters["@EnderecoFunc"].Value = txtEnderecoFuncionario.Text;



                cmd.Parameters.Add("@BairroFunc", SqlDbType.VarChar);
                cmd.Parameters["@BairroFunc"].Value = txtBairroFuncionario.Text;


                cmd.Parameters.Add("@TelFunc", SqlDbType.VarChar);
                cmd.Parameters["@TelFunc"].Value = mtbTelefoneFuncionario.Text;

                cmd.Parameters.Add("@CelFunc", SqlDbType.VarChar);
                cmd.Parameters["@CelFunc"].Value = mtbCelularFuncionario.Text;

                cmd.Parameters.Add("@FuncaoFunc", SqlDbType.VarChar);
                cmd.Parameters["@FuncaoFunc"].Value = cboFuncao.Text;

                cmd.Parameters.Add("@SalarioFunc", SqlDbType.VarChar);
                cmd.Parameters["@SalarioFunc"].Value = mtbSalarioFuncionario.Text;


                MessageBox.Show("Cadastro concluido com sucesso");

                cmd.ExecuteNonQuery();
                txtIdadeFuncionario.Text = "";
                txtNomeFuncionario.Text = "";
                txtBairroFuncionario.Text = "";
                txtEnderecoFuncionario.Text = "";
                mtbCelularFuncionario.Text = "";
                mtbCPFfuncionario.Text = "";
                mtbRGfuncionario.Text = "";
                mtbSalarioFuncionario.Text = "";
                mtbTelefoneFuncionario.Text = "";
                cboFuncao.SelectedIndex = -1;
                cboSexoFuncionario.SelectedIndex = -1;
            }
            catch (MySqlException erro) {

                MessageBox.Show(erro + "");
                                        }


            }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mtbCPFfuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mtbTelefoneFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mtbCelularFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void maskedTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtIdadeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEnderecoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            conexao cn = new conexao();

            MySqlConnection sqlc = new MySqlConnection(cn.conn);

            sqlc.Open();


            // SqlCommand cqlc = new SqlCommand("insert into Usuarios(senha,login,nome,endereco)values('1234','adm','alef','rua minie')", sqlc);
            MySqlCommand cmd = new MySqlCommand("insert into CadastroFuncionarios(NomeFuncionario,IdadeFuncionario,RGFuncionario,CPFfuncionario," +
    "SexoFuncionario,EnderecoFuncionario,BairroFuncionario,TelefoneFuncionario,CelularFuncinario,FuncaoFuncionario,SalarioFuncionario)" +
             " values(@NomeFunc,@IdadeFunc,@RGFunc,@CPFfunc,@SexoFunc,@EnderecoFunc,@BairroFunc,@TelFunc,@CelFunc,@FuncaoFunc,@SalarioFunc)", sqlc);

            //padão antigo
            // txtsenha.Text = "@sen";
            //cmd.Parameters.Add("@sen", txtsenha.Text);

            // padrão novo
            cmd.Parameters.Add("@NomeFunc", MySqlDbType.VarChar);
            cmd.Parameters["@NomeFunc"].Value = txtNomeFuncionario.Text;

            cmd.Parameters.Add("@IdadeFunc", MySqlDbType.VarChar);
            cmd.Parameters["@IdadeFunc"].Value = txtIdadeFuncionario.Text;

            cmd.Parameters.Add("@RGFunc", MySqlDbType.VarChar);
            cmd.Parameters["@RGFunc"].Value = mtbRGfuncionario.Text;

            cmd.Parameters.Add("@CPFfunc", MySqlDbType.VarChar);
            cmd.Parameters["@CPFfunc"].Value = mtbCPFfuncionario.Text;


            cmd.Parameters.Add("@SexoFunc", MySqlDbType.VarChar);
            cmd.Parameters["@SexoFunc"].Value = cboSexoFuncionario.Text;


            cmd.Parameters.Add("@EnderecoFunc", MySqlDbType.VarChar);
            cmd.Parameters["@EnderecoFunc"].Value = txtEnderecoFuncionario.Text;



            cmd.Parameters.Add("@BairroFunc", MySqlDbType.VarChar);
            cmd.Parameters["@BairroFunc"].Value = txtBairroFuncionario.Text;


            cmd.Parameters.Add("@TelFunc", MySqlDbType.VarChar);
            cmd.Parameters["@TelFunc"].Value = mtbTelefoneFuncionario.Text;

            cmd.Parameters.Add("@CelFunc", MySqlDbType.VarChar);
            cmd.Parameters["@CelFunc"].Value = mtbCelularFuncionario.Text;

            cmd.Parameters.Add("@FuncaoFunc", MySqlDbType.VarChar);
            cmd.Parameters["@FuncaoFunc"].Value = cboFuncao.Text;

            cmd.Parameters.Add("@SalarioFunc", MySqlDbType.VarChar);
            cmd.Parameters["@SalarioFunc"].Value = mtbSalarioFuncionario.Text;




            cmd.ExecuteNonQuery();
            MessageBox.Show("Dados Cadastrados com Sucesso !!");
            txtIdadeFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtBairroFuncionario.Text = "";
            txtEnderecoFuncionario.Text = "";
            mtbCelularFuncionario.Text = "";
            mtbCPFfuncionario.Text = "";
            mtbRGfuncionario.Text = "";
            mtbSalarioFuncionario.Text = "";
            mtbTelefoneFuncionario.Text = "";
            cboFuncao.SelectedIndex = -1;
            cboSexoFuncionario.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeFuncionario_Leave(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text == "")
            {
               txtNomeFuncionario.BackColor = Color.Red;
                MessageBox.Show("O Nome do funcionario não foi preenchido!!","Informação");


            }
        }

        private void txtIdadeFuncionario_Leave(object sender, EventArgs e)
        {
            if (txtIdadeFuncionario.Text == "")
            {
                txtIdadeFuncionario.BackColor = Color.Red;
                MessageBox.Show("A idade do(a) funcionario(a) não foi preenchida!!", "Informação");


            }
        }

        private void cboSexoFuncionario_Leave(object sender, EventArgs e)
        {
            if (cboSexoFuncionario.Text == "")
            {
                cboSexoFuncionario.BackColor = Color.Red;
                MessageBox.Show("O Sexo do(a) funcionario(a) não foi preenchido!!", "Informação");


            }
        }
    }
}
