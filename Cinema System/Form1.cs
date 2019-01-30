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
            pictureBoxMovie.Image = Properties.Resources.Cinemaimage;
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
        public bool IsNormal { get; set; }
        int count = 0;
        public dynamic Data { get; set; }
        HttpClient http = new HttpClient();
        private void metroBtnSearch_Click(object sender, EventArgs e)
        {
            metroLabelTitle.Text = String.Empty;
            metroLabelGenre.Text = String.Empty;
            metroLabelYear.Text = String.Empty;
            metroLabelTime.Text = String.Empty;
            metroLabelLanguage.Text = String.Empty;

            HttpResponseMessage response = new HttpResponseMessage();
            response =
                                  http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&s={textBoxSearch.Text}&plot=full").Result;
            try
            {
                var str = response.Content.ReadAsStringAsync().Result;
                Data = JsonConvert.DeserializeObject(str);
                pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMovie.Load($@"{Data.Search[count].Poster}");
                metroLabelTitle.Text = Data.Search[count].Title;
                metroLabelGenre.Text = Data.Search[count].Genre;
                metroLabelYear.Text = Data.Search[count].Year;
                metroLabelTime.Text = Data.Search[count].Runtime;
                metroLabelLanguage.Text = Data.Search[count].Language;
            }
            catch (Exception ex)
            {
                IsNormal = true;
            }
            if (IsNormal)
            {
                IsNormal = false;
                pictureBoxMovie.Image = Properties.Resources.NotFoundImage;
                pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                response =
                                  http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[count].Title}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic data = JsonConvert.DeserializeObject(str);
                pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMovie.Load($@"{data.Poster}");
                metroLabelTitle.Text = data.Title;
                metroLabelGenre.Text = data.Genre;
                metroLabelYear.Text = data.Year;
                metroLabelTime.Text = data.Runtime;
                metroLabelLanguage.Text = data.Language;
            }
        }
        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            ++count;
            var response =
                                   http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[count].Title}&plot=full").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            dynamic data = JsonConvert.DeserializeObject(str);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.Load($@"{data.Poster}");
            metroLabelTitle.Text = data.Title;
            metroLabelGenre.Text = data.Genre;
            metroLabelYear.Text = data.Year;
            metroLabelTime.Text = data.Runtime;
            metroLabelLanguage.Text = data.Language;
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            --count;
            var response =
                                   http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[count].Title}&plot=full").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            dynamic data = JsonConvert.DeserializeObject(str);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.Load($@"{data.Poster}");
            metroLabelTitle.Text = data.Title;
            metroLabelGenre.Text = data.Genre;
            metroLabelYear.Text = data.Year;
            metroLabelTime.Text = data.Runtime;
            metroLabelLanguage.Text = data.Language;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroBtLeft_Click(object sender, EventArgs e)
        {
            --count;
            if (count >= 0)
            {
                var response =
                                                   http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[count].Title}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic data = JsonConvert.DeserializeObject(str);
                pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMovie.Load($@"{data.Poster}");
                metroLabelTitle.Text = data.Title;
                metroLabelGenre.Text = data.Genre;
                metroLabelYear.Text = data.Year;
                metroLabelTime.Text = data.Runtime;
                metroLabelLanguage.Text = data.Language;
            }

        }

        private void metroBtRight_Click(object sender, EventArgs e)
        {
            ++count;
            if (count < Data.Search.Count)
            {
                var response =
                                                   http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[count].Title}&plot=full").Result;
                var str = response.Content.ReadAsStringAsync().Result;
                dynamic data = JsonConvert.DeserializeObject(str);
                pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxMovie.Load($@"{data.Poster}");
                metroLabelTitle.Text = data.Title;
                metroLabelGenre.Text = data.Genre;
                metroLabelYear.Text = data.Year;
                metroLabelTime.Text = data.Runtime;
                metroLabelLanguage.Text = data.Language;
            }

        }
    }
}
