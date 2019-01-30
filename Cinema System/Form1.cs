using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cinema_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBoxMovie.Image = Properties.Resources.NotFoundImage;
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
