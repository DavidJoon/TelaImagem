using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaImagem
{
    public partial class TelaImagem : Form
    {
        public TelaImagem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos bmp | *.bmp | Arquivos jpg | *.jpg";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
