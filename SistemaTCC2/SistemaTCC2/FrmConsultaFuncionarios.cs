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
    public partial class FrmConsultaFuncionarios : Form
    {
        public FrmConsultaFuncionarios()
        {
            InitializeComponent();
            btnAlterar.Visible = (false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();


                String SQL = "Delete  From CadastroFuncionarios Where IDFuncionario = @ID";
               
                MySqlCommand cmd = new MySqlCommand(SQL, sqlc);

                cmd.Parameters.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!!");
                   btnConsultarFuncionarios_Click(sender, e);


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }


        }

        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                String SQL = "Select*from CadastroFuncionarios where NomeFuncionario like @NomeFunc";
                conexao cn = new conexao();
                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();




                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, cn.conn);


               
                Adapter.SelectCommand.Parameters.Add("@NomeFunc", MySqlDbType.VarChar).Value = TxtDesc.Text + "%";


                DataSet DS = new DataSet();

                Adapter.Fill(DS, "CadastroFuncionarios");
                DgConsulta.DataSource = DS.Tables["CadastroFuncionarios"];



                DgConsulta.ContextMenuStrip = contextMenuStrip1;
                btnAlterar.Visible = (true);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao cn = new conexao();

                MySqlConnection sqlc = new MySqlConnection(cn.conn);

                sqlc.Open();



                MySqlCommand cmd = new MySqlCommand("Update CadastroFuncionarios Set NomeFuncionario = @NomeFunc, IdadeFuncionario = @IdadeFunc, RGFuncionario = @RGFunc,CPFfuncionario = @CPFfunc," +
            "SexoFuncionario = @SexoFunc,EnderecoFuncionario =@EnderecoFunc,BairroFuncionario = @BairroFunc, TelefoneFuncionario =@TelFunc,CelularFuncinario = @CelFunc, FuncaoFuncionario = @FuncaoFunc, SalarioFuncionario = @SalarioFunc" +
                     "  Where IDFuncionario = @ID", sqlc);
                //    String SQL = "Update Produtos Set Descricao=@desc,Unidade=@unid,Categoria=@cat,Valor=@val Where ID = @ID";


                var pr = cmd.Parameters;
                pr.Add("@NomeFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[1].Value.ToString(); 

                pr.Add("@IdadeFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[2].Value.ToString();

                pr.Add("@RGFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[3].Value.ToString();

                pr.Add("@CPFfunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[4].Value.ToString();

                pr.Add("@SexoFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[5].Value.ToString();

                pr.Add("@EnderecoFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[6].Value.ToString();

                pr.Add("@BairroFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[7].Value.ToString();

                pr.Add("@TelFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[8].Value.ToString();

                pr.Add("@CelFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[9].Value.ToString();

                pr.Add("@FuncaoFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[10].Value.ToString();

                pr.Add("@SalarioFunc", MySqlDbType.VarChar).Value = DgConsulta.SelectedCells[11].Value.ToString();

                pr.Add("@ID", MySqlDbType.Int16).Value = DgConsulta.SelectedCells[0].Value.ToString();


                DialogResult Resp;

                Resp = MessageBox.Show("Tem certeza de que deseja Alterar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resp == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Alteração teve sucesso");
                }
                else
                {


                    TxtDesc.Text = "";
                    MessageBox.Show("Alteração Cancelada");
                    btnConsultarFuncionarios_Click(sender, e);
                }

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
    }
}
