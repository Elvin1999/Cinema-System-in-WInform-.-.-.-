﻿using Newtonsoft.Json;
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
using YoutubeSearch;
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
                IsClickedToSearchButton = false;
            }
            else if (textBoxSearch.Text == String.Empty)
            {
                IsClickedToSearchButton = false;
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
        public dynamic SingleData { get; set; }
        HttpClient http = new HttpClient();
        public bool IsClickedToSearchButton { get; set; }
        private void metroBtnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != String.Empty && textBoxSearch.Text != "Search movie . . .")
            {
                IsClickedToSearchButton = true;
                metroLabelTitle.Text = String.Empty;
                metroLabelGenre.Text = String.Empty;
                metroLabelYear.Text = String.Empty;
                metroLabelTime.Text = String.Empty;
                metroLabelLanguage.Text = String.Empty;
                labelNamemovie.Text = String.Empty;
                HttpResponseMessage response = new HttpResponseMessage();
                response =
                                      http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&s={textBoxSearch.Text}&plot=full").Result;
                try
                {
                    var str = response.Content.ReadAsStringAsync().Result;
                    Data = JsonConvert.DeserializeObject(str);
                    pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagepath = Data.Search[count].Poster;
                    pictureBoxMovie.Load($@"{imagepath}");
                    metroLabelTitle.Text = Data.Search[count].Title;
                    metroLabelGenre.Text = Data.Search[count].Genre;
                    metroLabelYear.Text = Data.Search[count].Year;
                    metroLabelTime.Text = Data.Search[count].Runtime;
                    labelNamemovie.Text = metroLabelTitle.Text + " . . .";
                    metroLabelLanguage.Text = Data.Search[count].Language;

                    VideoSearch videos = new VideoSearch();
                    var tmpUrl = videos.SearchQuery($"{metroLabelTitle.Text} trailer", 1);
                    Embed = "<html>" +
                            "<head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head>" +
                "<body>" +
                "<iframe width=312px height=194px src =\"{0}\"frameborder = \"0\" encrypted-media\" allowfullscreen></iframe>" +
                "</body>" +
                "</html>";
                    URL = $@"https://www.youtube.com/embed/{tmpUrl[0].Url.ToString().Split('=').Last()}";
                    webBrowserYoutube.DocumentText = string.Format(Embed, URL);

                }
                catch (Exception)
                {
                    //IsNormal = true;
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
                    labelNamemovie.Text = metroLabelTitle.Text + " . . .";
                    metroLabelLanguage.Text = data.Language;
                    SingleData = data;
                }


            }
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
                if (data.poster != "N/A")
                {
                    pictureBoxMovie.Load($@"{data.Poster}");
                }
                else
                {
                    pictureBoxMovie.Image = Properties.Resources.NotFoundImage;
                }
                metroLabelTitle.Text = data.Title;
                metroLabelGenre.Text = data.Genre;
                metroLabelYear.Text = data.Year;
                metroLabelTime.Text = data.Runtime;
                labelNamemovie.Text = metroLabelTitle.Text + " . . .";
                metroLabelLanguage.Text = data.Language;
                SingleData = data;
                VideoSearch videos = new VideoSearch();
                var tmpUrl = videos.SearchQuery($"{metroLabelTitle.Text} trailer", 1);
                Embed = "<html>" +
                        "<head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head>" +
            "<body>" +
            "<iframe width=312px height=194px src =\"{0}\"frameborder = \"0\" encrypted-media\" allowfullscreen></iframe>" +
            "</body>" +
            "</html>";
                URL = $@"https://www.youtube.com/embed/{tmpUrl[0].Url.ToString().Split('=').Last()}";
                webBrowserYoutube.DocumentText = string.Format(Embed, URL);

            }
        }
        public string Url { get; set; }
        private void metroBtRight_Click(object sender, EventArgs e)
        {
            ++count;
            if (count < Data.Search.Count)
            {
                try
                {
                    var response =
                                                                       http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={Data.Search[count].Title}&plot=full").Result;
                    var str = response.Content.ReadAsStringAsync().Result;
                    dynamic data = JsonConvert.DeserializeObject(str);
                    pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (data.Poster != "N/A")
                    {
                        pictureBoxMovie.Load($@"{data.Poster}");
                    }
                    else
                    {
                        pictureBoxMovie.Image = Properties.Resources.NotFoundImage;
                    }
                    metroLabelTitle.Text = data.Title;
                    metroLabelGenre.Text = data.Genre;
                    metroLabelYear.Text = data.Year;
                    metroLabelTime.Text = data.Runtime;
                    metroLabelLanguage.Text = data.Language;
                    labelNamemovie.Text = metroLabelTitle.Text + " . . .";
                    SingleData = data;
                    VideoSearch videos = new VideoSearch();
                    var tmpUrl = videos.SearchQuery($"{metroLabelTitle.Text} trailer", 1);
                    Embed = "<html>" +
                            "<head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head>" +
                "<body>" +
                "<iframe width=312px height=194px src =\"{0}\"frameborder = \"0\" encrypted-media\" allowfullscreen></iframe>" +
                "</body>" +
                "</html>";
                    URL = $@"https://www.youtube.com/embed/{tmpUrl[0].Url.ToString().Split('=').Last()}";
                    webBrowserYoutube.DocumentText = string.Format(Embed, URL);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }
        public string URL { get; set; }
        public string Embed { get; set; }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (IsClickedToSearchButton)
            {
                //IsClickedToSearchButton = false;

                MovieHall hall = new MovieHall();
                this.Hide();
                webBrowserYoutube.DocumentText = null;
                if (hall.ShowDialoq(SingleData) == DialogResult.Cancel)
                {
                    webBrowserYoutube.DocumentText = string.Format(Embed, URL);
                    this.Show();
                }

            }

        }
    }
}
