using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tela_infor
{
    public partial class Sprite : Form
    {
        Send envi = new Send();

        Consult con = new Consult();
        public Sprite()
        {
            InitializeComponent();
        }

        //###### SEND PAGE SHOW ######
        private void button1_Click(object sender, EventArgs e)
        {
            envi.ShowDialog();
        }

        //###### CONSULT PAGE SHOW ######
        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
