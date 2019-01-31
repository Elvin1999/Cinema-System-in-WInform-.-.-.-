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
    public partial class MovieHall : Form
    {
        public MovieHall()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.blurred;
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            int i = 0;
            foreach (var item in this.Controls)
            {
                if(item is MetroFramework.Controls.MetroButton mb)
                {
                    mb.ForeColor = Color.Gray;
                    mb.TextAlign = ContentAlignment.MiddleCenter;
                    
                }
            }

        }    
        private void MovieHall_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
