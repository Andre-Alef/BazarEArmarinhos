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
    public partial class FrmCadastroDeUsuarios : Form
    {
        public String IDUsuario ;
        public FrmCadastroDeUsuarios()
        {
            InitializeComponent();
        }
        
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);


                sqlc.Open();


                //  SqlCommand cqlc = new SqlCommand("insert into Usuarios(senha,login,nome,endereco)values('1234','adm','alef','rua minie')", sqlc);
                MySqlCommand cmd = new MySqlCommand("insert into CadastroUsuarios(login,senha)values(@log,@sen)", sqlc);

             
                //padrão novo
                cmd.Parameters.Add("@log", MySqlDbType.VarChar);
                cmd.Parameters["@log"].Value = txtNomeUsuario.Text;

                cmd.Parameters.Add("@sen", MySqlDbType.VarChar);
                cmd.Parameters["@sen"].Value = txtSenha.Text;
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados cadastrados com sucesso!!");
                txtNomeUsuario.Text="";
                txtSenha.Text = "";
                txtConfirmacao.Text = "";

               
                   
                
                }
            catch (MySqlException erro)
            {
                MessageBox.Show(" "+erro);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == "")
            {
                txtNomeUsuario.BackColor = Color.Red;
                MessageBox.Show("O Complemento não foi preenchida!!");


            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("A Senha não foi preenchida!!");


            }
        }

   

        private void txtNomeUsuario_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.BackColor = Color.White;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }

        private void txtConfirmacao_Click(object sender, EventArgs e)
        {
            txtConfirmacao.BackColor = Color.White;
        }
    }
}
