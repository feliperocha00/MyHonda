using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tela_infor
{
    public partial class Consult : Form
    {
        public Consult()
        {
            InitializeComponent();
        }

        //###### DATAGRID CONSULT ACTION ######
        private void button1_Click_1(object sender, EventArgs e)
        {
            //###### SELECT FROM DATABASE ######
            MySqlConnection conexao = new MySqlConnection("server=localhost; UserId=root; database=honda; password=''");
            MySqlCommand sqlQuery = new MySqlCommand("SELECT * FROM costumer", conexao);


            dataGridView1.Rows.Clear();

            int n_reg = 0;

            try
            {
                conexao.Open();
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                while (dataReader.Read())
                {
                    object[] registro = new object[dataReader.FieldCount];

                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            dataGridView1.Columns.Add(dataReader.GetName(i), dataReader.GetName(i));
                        }
                    }

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        registro[i] = dataReader.GetValue(i); //# REGISTER MOUNT #                      
                    }
                    dataGridView1.Rows.Add(registro); //# ADD LINE #

                    n_reg++;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

