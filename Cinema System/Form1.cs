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
            pictureBoxLeft.Image = Properties.Resources.left;
            pictureBoxLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRight.Image = Properties.Resources.right;
            pictureBoxRight.SizeMode = PictureBoxSizeMode.StretchImage;

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
        List<string> datalist = new List<string>();
        private void metroBtnSearch_Click(object sender, EventArgs e)
        {

            HttpClient http = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            response =
                                  http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={textBoxSearch.Text}&plot=full").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            dynamic data = JsonConvert.DeserializeObject(str);
            datalist.Add(str);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.Load($@"{data.Poster}");
            textBoxTitle.Text = data.Title;
            textBoxGenre.Text = data.Genre;
            textBoxYear.Text = data.Year;
            textBoxRuntime.Text = data.Runtime;
            textBxLanguage.Text = data.Language;
        }
        int max;
        int count = 0;
        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            dynamic data = JsonConvert.DeserializeObject(datalist[count]);
            pictureBoxMovie.Load($@"{data.Poster}");
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            dynamic data = JsonConvert.DeserializeObject(datalist[count]);
            pictureBoxMovie.Load($@"{data.Poster}");
        }
    }
}
