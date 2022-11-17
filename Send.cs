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
namespace Tela_infor
{
    public partial class Send : Form
    {


        Costumer envi = new Costumer();
        public Send()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            envi.setId(int.Parse(textBox1.Text));
            envi.setName(textBox2.Text);
            envi.setLastn(textBox3.Text);
            envi.setCpf(textBox4.Text);
            envi.setCell(textBox5.Text);
            envi.setEmail(textBox6.Text);
            envi.setConfemail(textBox7.Text);
            envi.setPasswd(textBox8.Text);
            envi.setConfpasswd(textBox9.Text);
            envi.setBorn(DateTime.Parse(textBox10.Text));



            MySqlConnection conexao = new MySqlConnection("server=localhost; UserId=root; database=honda; password=''");
            MySqlCommand sqlQuery = new MySqlCommand($"INSERT INTO costumer VALUES({envi.getId()},'{envi.getName()}','{envi.getLastn()}','{envi.getCpf()}','{envi.getCell()}','{envi.getEmail()}','{envi.getConfemail()}','{envi.getPasswd()}','{envi.getConfpasswd()}','{envi.getBorn()}');", conexao);

            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

            MessageBox.Show("Data successfully sent to the database", "Data Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
