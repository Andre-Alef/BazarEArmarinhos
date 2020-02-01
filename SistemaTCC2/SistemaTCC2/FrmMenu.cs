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
    public partial class Menu : Form
    {
        FrmCaixa cx = new FrmCaixa();
        AbrirFechar abrirFechar = new AbrirFechar();
        int X = 0;
        int Y = 0;
        public Menu()
        {
            InitializeComponent();
            timer1.Enabled = true;
          

            conexao cn = new conexao();
            MySqlConnection sqlc = new MySqlConnection(cn.conn);

            /*sqlc.Open();


            MySqlCommand cmd = new MySqlCommand("select login from CadastroUsuarios ", sqlc);
            MySqlDataReader leitor = cmd.ExecuteReader();



            while (leitor.Read())
            {
                //para cada iteração adiciono o nome 
                //ao listbox 
                label6.Text = (leitor["login"].ToString());
            }

            */
            /*
           Form1 frm1 = new Form1();

            cmd.Parameters.Add("@log", MySqlDbType.VarChar);
            cmd.Parameters["@log"].Value = frm1.txtlogin.Text;

            string login = (string)cmd.ExecuteScalar();

            label6.Text = frm1.txtlogin.Text;

        */
        }







        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmCaixa)));
          
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmCadastroTelinha)));
            
        }

     

        private void button4_Click(object sender, EventArgs e)
        {

            abrirFechar.OpenForm((typeof(FrmFerramentasTelinha)));

        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            this.WindowState = FormWindowState.Normal;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_KeyUp(object sender, KeyEventArgs e)
        {
          

          if (e.KeyCode == Keys.D1)
            {
                button1_Click(sender, e);
            }

            if (e.KeyCode == Keys.D2)
            {
                button2_Click(sender, e);

            }


            if (e.KeyCode == Keys.D3)
            {
                BtnConsultas_Click(sender, e);

            }

            if (e.KeyCode == Keys.D4)
            {
                button4_Click(sender, e);

            }


            if (e.KeyCode == Keys.D5)
            {
                button5_click(sender, e);

            }

            if (e.KeyCode == Keys.D6)
            {
                BtnSobre_Click(sender, e);

            }


            if (e.KeyCode == Keys.D7)
            {
                BtnAjuda_Click(sender, e);

            }


            if (e.KeyCode == Keys.D8)
            {
                BtnSite_Click(sender, e);

            }

            if (e.KeyCode == Keys.Escape)
            {
                label2_Click(sender, e);

            }
            
        }

        private void button5_click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmRelatoriosTelinha2)));
         

        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
       
            abrirFechar.OpenForm((typeof(FrmSobre)));

        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            
            abrirFechar.OpenForm((typeof(FrmRelatoriosTelinha)));
            
        }

        private void BtnSite_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\andre\Desktop\Site Empresa Cliente\index.html");

        System.Diagnostics.Process.Start(@"http://www.microsoft.com.br");
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


  

        private void Menu_Load(object sender, EventArgs e)
        {

        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd  dd 'de' MMMM 'de' yyyy  \nhh:mm:ss");
        }

 

       

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            abrirFechar.OpenForm((typeof(FrmConsultaTelinha)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult Resp;

            Resp = MessageBox.Show("Tem certeza de que deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

      
        private void button1_Click_2(object sender, EventArgs e)
        {

           

            DialogResult Resp;

            Resp = MessageBox.Show("Tem certeza de que deseja Deslogar?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {

                this.Close();
           
            
                
            }

        }
       

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
    }
    }
