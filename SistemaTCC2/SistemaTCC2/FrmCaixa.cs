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
    public partial class FrmCaixa : Form
    {
        double[] X = new double[3];
        string[] Y = new string[3];
        string[] R = new string[6];
        double[] W = new double[3];
        double[] Z = new double[6];
       // string cdm2;
        public FrmCaixa()
        {
            InitializeComponent();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            Menu mn = new Menu();
            mn.FLP1.Visible = (true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCupom cp = new FrmCupom();
            cp.listBox1.Items.AddRange(lstItens.Items);
            cp.LblPag.Text = cboForma.Text;
        
            cp.TopMost = true;
            cp.Show();
            this.Close();
            
            //mudei aqui lup
            try
            {
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                //lstItens






            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
               
            }
        }

        double subtotal = 0;

     public String a, b, c;

        private void btnADD_Click(object sender, EventArgs e)
        {
          

            lblFormadePagamento.Visible = true;
            lblParcelas.Visible = true;
            cboForma.Visible = true;
            cboParcelas.Visible = true;

            

            for (int i = 0; i < 3; i++)
            {
                // Console.Write("Digite a temperatura {0}: ", i);
                X[i] = double.Parse(txtQuantidade.Text);
            }


            for (int i = 0; i < 3; i++)
            {
                // Console.Write("Digite a temperatura {0}: ", i);
                Y[i] = (cboForma.Text);
            }

            for (int i = 0; i < 3; i++)
            {
                // Console.Write("Digite a temperatura {0}: ", i);
                R[i] = (cboParcelas.Text);
            }



            for (int i = 0; i < 3; i++)
            {
                // Console.Write("Digite a temperatura {0}: ", i);
                W[i] = double.Parse(txtDesconto.Text);
            }



          

            try
            {

                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();
                subtotal += (double.Parse(txtPrecoProduto.Text) * int.Parse(txtQuantidade.Text) - double.Parse(txtDesconto.Text));
                txtTot.Text = subtotal.ToString();

                for (int i = 0; i < 3; i++)
                {
                    // Console.Write("Digite a temperatura {0}: ", i);
                    Z[i] = double.Parse(txtTot.Text);
                }

                a = rtbDesc.Text;
                b = txtPrecoProduto.Text;
                c = txtQuantidade.Text;

                lstItens.Items.Add(a + "          R$" + b + "              x" + c);
                // lstItens.Items.Add(rtbDesc.Text + "          R$" + txtPrecoProduto.Text + "              x" + txtQuantidade.Text);
                //   txtTot.Text = ("" + subtotal);


                MySqlCommand cmd2 = new MySqlCommand("insert into caixa(Quantidade,FormaDePagamento,Parcelas,Desconto," +
    "Total)" +
             " values(@Quant,@FormPagmt,@Parc,@Desc,@Tot)", sqlc);



                //  X = txtQuantidade.Text;


                cmd2.Parameters.Add("@Quant", MySqlDbType.Double);
                cmd2.Parameters["@Quant"].Value = X;

                cmd2.Parameters.Add("@FormPagmt", MySqlDbType.VarChar);
                cmd2.Parameters["@FormPagmt"].Value = Y;

                cmd2.Parameters.Add("@Parc", MySqlDbType.VarChar);
                cmd2.Parameters["@Parc"].Value = R;

                cmd2.Parameters.Add("@Desc", MySqlDbType.Double);
                cmd2.Parameters["@Desc"].Value = W;

                cmd2.Parameters.Add("@Tot", MySqlDbType.Double);
                cmd2.Parameters["@Tot"].Value = Z;

                txtQuantidade.Clear();
                txtPrecoProduto.Clear();
                txtNomeProduto.Clear();
                txtNomeCliente.Clear();
                txtDesconto.Clear();
                cboForma.SelectedIndex = -1;
                cboParcelas.SelectedIndex = -1;
                rtbDesc.Clear();

                // lstItens.Items.Add(cboForma.Text + "  " + cboParcelas.Text + "\n R$ " + txtDesconto.Text + "\n R$ " + txtTotal.Text+" " +txtNomeCliente.Text + "\n" + 

               

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

        private void txtNomeProduto_Leave(object sender, EventArgs e)
        {
            try
            {

               

                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

               
                    sqlc.Open();

                MySqlCommand cmd = new MySqlCommand("select PrecoProduto, DescricaoProduto from CadastroProdutos where NomeProduto like @NomeP", sqlc);


                    cmd.Parameters.Add("@NomeP", MySqlDbType.VarChar);
                cmd.Parameters["@NomeP"].Value = txtNomeProduto.Text;

                MySqlDataReader leitor = cmd.ExecuteReader();






              

                    while (leitor.Read())
                {
                    //para cada iteração adiciono o nome 
                    //ao listbox 

                    rtbDesc.Text = (leitor["DescricaoProduto"].ToString());
                    txtPrecoProduto.Text = (leitor["PrecoProduto"].ToString());
                    //  rtbDesc.Text = "@DescProd";
                }
                String dados = rtbDesc.Text;
                String dados2 = txtPrecoProduto.Text;




                // String[] dados = new String[ ];

                
/*
                int es = Convert.ToInt16(cmd.ExecuteScalar());


                if (es > 0)
                {



                }
                else
                {

                    MessageBox.Show("Esse Produto não esta cadastrado");
                    txtNomeProduto.BackColor = Color.GreenYellow;
                }
                */
                sqlc.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rtbDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            try
            {
               
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                MySqlCommand cmd = new MySqlCommand("select* from CadastroClientes where NomeCliente = @NomeC", sqlc);

                cmd.Parameters.Add("@NomeC", MySqlDbType.VarChar);
                cmd.Parameters["@NomeC"].Value = txtNomeCliente.Text;

                int es = Convert.ToInt16(cmd.ExecuteScalar());


                if (es > 0)
                {



                }
                else
                {

                    MessageBox.Show("Esse Cliente não esta cadastrado");
                    txtNomeCliente.BackColor = Color.GreenYellow;
                }
                sqlc.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro + "");

            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstItens.Items.RemoveAt(lstItens.SelectedIndex);
        }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
         
            try
            {
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);


                sqlc.Open();


               //cmd2.ExecuteNonQuery();
                MessageBox.Show("Compra Finalizada !!");
            }
            catch (Exception er) {
                MessageBox.Show("" + er);

               
            }
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
          
        }
    }
}