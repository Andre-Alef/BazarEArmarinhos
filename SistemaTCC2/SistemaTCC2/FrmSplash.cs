using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTCC2
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {









            /*if (barradeprogresso.Value < 100)
            {
                barradeprogresso.Value = barradeprogresso.Value + 2;

            }
                 else
                 {
                     timer1.Enabled = false;
                     Menu mn = new Menu();
                     mn.Show();


                     this.Hide();
                 }*/

            try
            {

                //  for (int i = 0; i < 100; i++)
                
                {
                    barradeprogresso.Value = barradeprogresso.Value + 2;

                   // barradeprogresso.Value = (i);

                    if (barradeprogresso.Value <= 50)
                    {

                        txtprogresso.Text = (" Carregando informações");


                    }
                    else if (barradeprogresso.Value <= 80)
                    {

                        txtprogresso.Text = (" Carregando sistema....");


                    }
                    else if (barradeprogresso.Value <= 90)
                    {


                        txtprogresso.Text = (" Carregando banco de dados... ");

                    }
                    else if (barradeprogresso.Value <100)
                    {

                        txtprogresso.Text = (" Iniciando tela.....");

                    }
                    else
                    {
                        timer1.Enabled = false;
                        Menu mn = new Menu();
                        mn.Show();


                        this.Hide();
                    }
                }
            }




            catch (Exception erro)
            {

                MessageBox.Show(erro + " Tempo de inicialização excedido!\n Tente Novamente ");

            }

            }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void barradeprogresso_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
    }

   

