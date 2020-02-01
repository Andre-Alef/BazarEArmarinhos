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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Visible = (false); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Resp;

            Resp = MessageBox.Show("Tem certeza de que deseja Deslogar?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                Application.Exit();

            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                MySqlCommand cmd = new MySqlCommand("select* from CadastroUsuarios where senha = @sen and login =@log", sqlc);

                cmd.Parameters.Add("@sen", MySqlDbType.VarChar);
                cmd.Parameters["@sen"].Value = txtsenha.Text;

                cmd.Parameters.Add("@log", MySqlDbType.VarChar);
                cmd.Parameters["@log"].Value = txtlogin.Text;



                int es = Convert.ToInt16(cmd.ExecuteScalar());

                if (es > 0)
                {


                    FrmSplash sp = new FrmSplash();
                    sp.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Informações incorretas");
                    button4.Visible = (true);
                }

            } catch (Exception erro)
            {

                MessageBox.Show(erro+"");

            }

    
        }

   
    }

}