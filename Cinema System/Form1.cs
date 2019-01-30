using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
        private void textBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search movie . . .")
            {
                textBoxSearch.Text = String.Empty;
            }
        }

        private void textBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == String.Empty)
            {
                textBoxSearch.Text = "Search movie . . .";
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //maybe here i do that
           
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search movie . . .")
            {
                textBoxSearch.Text = String.Empty;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == String.Empty)
            {
                textBoxSearch.Text = "Search movie . . .";
            }
        }

        private void metroBtnSearch_Click(object sender, EventArgs e)
        {
           // HttpClient http = new HttpClient();
           // var response =
           //http.GetAsync($@"http://www.omdbapi.com/?i=tt3896198&apikey=interstealler").Result;
           // var str = response.Content.ReadAsStringAsync().Result;
           // dynamic data = JsonConvert.DeserializeObject(str);
           // MessageBox.Show(data.Poster);
            //string url = data.Poster;
            //pictureBoxMovie.Load(url);
        }
    }
}
