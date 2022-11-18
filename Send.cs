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

        //###### SEND BUTTON ACTION ######
        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "") ||
                (textBox3.Text == "") ||
                (textBox4.Text == "") ||
                (textBox5.Text == "") ||
                (textBox6.Text == "") ||
                (textBox7.Text == "") ||
                (textBox8.Text == "") ||
                (textBox9.Text == "") ||
                (textBox2.Text == "") ||
                (textBox10.Text == ""))
            {
                MessageBox.Show("Fields are empty. Please, fill'em with valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                envi.setBorn(textBox10.Text);

                if ((envi.getEmail() == envi.getConfemail()) && (envi.getPasswd() == envi.getConfpasswd()))//###### EMAIL AND PASSWORD CONFIRMATION ######
                {

                    //###### INSERT INTO DATABASE ######
                    MySqlConnection conexao = new MySqlConnection("server=localhost; UserId=root; database=honda; password=''");
                    MySqlCommand sqlQuery = new MySqlCommand($"INSERT INTO costumer VALUES({envi.getId()}," +
                                                                                        $"'{envi.getName()}'," +
                                                                                        $"'{envi.getLastn()}'," +
                                                                                        $"'{envi.getCpf()}'," +
                                                                                        $"'{envi.getCell()}'," +
                                                                                        $"'{envi.getEmail()}'," +
                                                                                        $"'{envi.getPasswd()}'," +
                                                                                        $"'{envi.getBorn()}');", conexao);

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
                else
                {
                    MessageBox.Show("Fields filled incorrectly. Unnable to send the data to database\nTry Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //###### EXIT BUTTON ACTION ######
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
