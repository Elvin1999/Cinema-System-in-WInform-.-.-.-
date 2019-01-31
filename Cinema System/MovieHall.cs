using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;

namespace Cinema_System
{
    public partial class MovieHall : Form
    {
        public MovieHall()
        {
            InitializeComponent();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            foreach (var item in this.Controls)
            {
                if (item is MetroFramework.Controls.MetroButton mb)
                {
                    mb.ForeColor = Color.Gray;
                    mb.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }
        public dynamic Data { get; set; }
        public string Ratings { get; set; }
        public DialogResult ShowDialoq(dynamic data)
        {
            Data = data;
            labelFilmName.Text = Data.Title;
            labelPlot.Text = Data.Plot;
            Width = labelFilmName.Width;
            Ratings = Data.imdbRating;


            return base.ShowDialog();
        }
        int X = 0;
        private void MovieHall_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Start();
            timer.Tick += Timer_Tick;
            point = labelFilmName.Location;
            X = point.X;
            Width = labelFilmName.Width;
            string ratings = Data.Value;
            //var nratings = ratings.Split('/');

            MessageBox.Show(ratings);
            pictureBoxStar1.Image = Properties.Resources.starempty;
            pictureBoxStar2.Image = Properties.Resources.starempty;
            pictureBoxStar3.Image = Properties.Resources.starempty;
            pictureBoxStar4.Image = Properties.Resources.starempty;
            pictureBoxStar5.Image = Properties.Resources.starempty;
            pictureBoxStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStar5.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        Point point = new Point();
        int Width;
        private void Timer_Tick(object sender, EventArgs e)
        {

            X -= 2;
            labelFilmName.Location = new Point(X, point.Y);
            labelFilmName.Width += 4;
            if (X == point.X - 250)
            {
                X = point.X;
                labelFilmName.Width = Width;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
        private void metroButton71_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        private void MovieHall_Shown(object sender, EventArgs e)
        {
            VideoSearch videos = new VideoSearch();
            var tmpUrl = videos.SearchQuery($"{labelFilmName.Text} trailer", 1);
            var embed = "<html>" +
                    "<head>" +
        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
        "</head>" +
        "<body>" +
        "<iframe width=260px height=165px src =\"{0}\"frameborder = \"0\" encrypted-media\" allowfullscreen></iframe>" +
        "</body>" +
        "</html>";
            var url = $@"https://www.youtube.com/embed/{tmpUrl[0].Url.ToString().Split('=').Last()}";
            webBrowserYoutube.DocumentText = string.Format(embed, url);
            int iterator;
            double d = double.Parse(Data.imdbRating, CultureInfo.InvariantCulture);
            MessageBox.Show(d.ToString());
            return;
            if (int.Parse(Data.imdbRating) / 2 == 1)
            {
                iterator = 1;
            }
            else if (int.Parse(Data.imdbRating) / 2 == 2)
            {
                iterator = 2;
            }
            else if (int.Parse(Data.imdbRating) / 2 == 3)
            {
                iterator = 3;
            }
            else if (int.Parse(Data.imdbRating) / 2 == 4)
            {
                iterator = 4;
            }
            else if (int.Parse(Data.imdbRating) / 2 == 5)
            {
                iterator = 5;
            }
            else
            {
                iterator = 0;
            }
            int i = 0;
            if (iterator != 0)
            {
                foreach (var item in this.Controls)
                {
                    if (item is PictureBox pb)
                    {
                        if (i < iterator)
                        {
                            pb.Image = Properties.Resources.star;
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            ++i;
                        }

                    }
                }
            }


        }
    }
}
