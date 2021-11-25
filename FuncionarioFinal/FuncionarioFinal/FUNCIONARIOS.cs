using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FuncionarioFinal
{
    public partial class FUNCIONARIOS : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        
        public FUNCIONARIOS()
        {
            InitializeComponent();
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=HOME_PC\SQLEXPRESS ;Database=Empresa02 ;User Id=sa ;Password= Sqlserver;");

                strSQL = "INSERT INTO Funcionario (NOME, SALARIO, EMPRESA, CARGO) VALUES (@NOME, @SALARIO, @EMPRESA, @CARGO)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNOME2.Text);
                comando.Parameters.AddWithValue("@SALARIO", msbSALARIO2.Text);
                comando.Parameters.AddWithValue("@EMPRESA", txtEMPRESA2.Text);
                comando.Parameters.AddWithValue("@CARGO", cbbCARGO2.SelectedText);


               

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }


        }
        
        private void btnEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=HOME_PC\SQLEXPRESS ;Database=Empresa02 ;User Id=sa ;Password= Sqlserver;");

                strSQL = "UPDATE funcionario SET NOME = @NOME, SALARIO = @SALARIO, EMPRESA = @EMPRESA, CARGO = @CARGO WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID2.Text);
                comando.Parameters.AddWithValue("@NOME", txtNOME2.Text);
                comando.Parameters.AddWithValue("@SALARIO", msbSALARIO2.Text);
                comando.Parameters.AddWithValue("@EMPRESA", txtEMPRESA2.Text);
                comando.Parameters.AddWithValue("@CARGO", cbbCARGO2.SelectedValue);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Alterado com Sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=HOME_PC\SQLEXPRESS ;Database=Empresa02 ;User Id=sa ;Password= Sqlserver;");

                strSQL = "DELETE funcionario WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID2.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Excluido com Sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btnEXIBIR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=HOME_PC\SQLEXPRESS ;Database=Empresa02 ;User Id=sa ;Password= Sqlserver;");

                strSQL = "SELECT * FROM funcionario";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dgnDados.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=HOME_PC\SQLEXPRESS ;Database=Empresa02 ;User Id=sa ;Password= Sqlserver;");

                strSQL = "SELECT * FROM funcionario WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", txtID2.Text);


                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNOME2.Text = (string)dr["nome"];
                    txtEMPRESA2.Text = (string)dr["empresa"];
                    msbSALARIO2.Text = (string)dr["salario"];
                    cbbCARGO2.Text = (string)dr["cargo"];

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void cbxCARGO2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCARGO2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aDMINISTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgnDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

