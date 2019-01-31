using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;

namespace Cinema_System
{
    public partial class MovieHall : Form
    {
        public double Money { get; set; }
        public MovieHall()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
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
        public string Filename { get; set; }
        public double ImdbPoint { get; private set; }

        MetroFramework.Controls.MetroButton metro;
        private void MovieHall_Load(object sender, EventArgs e)
        {
            Filename = Data.Title + ".json";
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Start();
            timer.Tick += Timer_Tick;
            point = labelFilmName.Location;
            X = point.X;
            Width = labelFilmName.Width;

            int iterator;
            string s = Data.imdbRating.ToString();
            string newstr = s.Replace('.', ',');
            double result = double.Parse(newstr);
            ImdbPoint = result;
            //split
            iterator = Convert.ToInt32(result) / 2;
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
                        else
                        {
                            pb.Image = Properties.Resources.starempty;
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                    }
                }
            }


            cinema.MovieTitle = Data.Title.ToString();
            cinema.Seats = new List<CinemaSeat>();
            CinemaSeat seat;
            if (File.Exists(Filename))
            {
                var text = File.ReadAllText(Filename);
                var item = JsonConvert.DeserializeObject<Cinema>(text);
                cinema = item;
            }
            else
            {
                for (int k = 1; k <= 60; k++)
                {
                    seat = new CinemaSeat();
                    seat.Number = k;
                    seat.IsFull = false;
                    seat.IsWheerchairAccess = false;
                    cinema.Seats.Add(seat);
                }

            }
            cinema.Seats[38].IsWheerchairAccess = true;
            cinema.Seats[39].IsWheerchairAccess = true;
            cinema.Seats[50].IsWheerchairAccess = true;
            cinema.Seats[51].IsWheerchairAccess = true;
            int x = 0; int y = 0;
            for (int k = 1; k <= 60; k++)
            {

                metro = new MetroFramework.Controls.MetroButton();

                metro.Size = new Size(41, 30);
                metro.Highlight = true;
                metro.UseCustomBackColor = true;
                metro.UseCustomForeColor = true;
                metro.UseStyleColors = true;
                metro.Location = new Point(530 + x, 159 + y);
                metro.Text = cinema.Seats[k - 1].Number.ToString();
                metro.TextAlign = ContentAlignment.MiddleCenter;
                if (cinema.Seats[k - 1].IsWheerchairAccess)
                {
                    metro.BackColor = Color.Orange;
                }
                else if (cinema.Seats[k - 1].IsFull)
                {
                    metro.BackColor = Color.Red;
                }
                else
                {
                    metro.BackColor = Color.FromArgb(16, 20, 30);
                }
                metro.ForeColor = Color.Blue;
                x += 42;
                if (k % 10 == 0)
                {
                    x = 0;
                    y += 32;
                }
                metro.Click += Metro_Click;
                this.Controls.Add(metro);

            }
        }
        private void Metro_Click(object sender, EventArgs e)
        {
            int number;
            var mb = sender as MetroFramework.Controls.MetroButton;
            if (mb.BackColor == Color.FromArgb(16, 20, 30))
            {
                mb.BackColor = Color.Lime;
                number = int.Parse(mb.Text);
                cinema.Seats[number - 1].IsFull = true;
                Money += ImdbPoint;
                labelMoney1.Text = Money.ToString();
            }

        }

        Cinema cinema = new Cinema();
        Point point = new Point();
        int Width;
        private void Timer_Tick(object sender, EventArgs e)
        {

            X -= 2;
            labelFilmName.Location = new Point(X, point.Y);
            labelFilmName.Width += 3;
            if (X == point.X - 200)
            {
                X = point.X + 20;
                labelFilmName.Width = Width;
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void metroButtonReturn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void MovieHall_Shown(object sender, EventArgs e)
        {
            //    VideoSearch videos = new VideoSearch();
            //    var tmpUrl = videos.SearchQuery($"{labelFilmName.Text} trailer", 1);
            //    var embed = "<html>" +
            //            "<head>" +
            //"<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            //"</head>" +
            //"<body>" +
            //"<iframe width=260px height=165px src =\"{0}\"frameborder = \"0\" encrypted-media\" allowfullscreen></iframe>" +
            //"</body>" +
            //"</html>";
            //    var url = $@"https://www.youtube.com/embed/{tmpUrl[0].Url.ToString().Split('=').Last()}";
            //    webBrowserYoutube.DocumentText = string.Format(embed, url);            
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            var feedback = JsonConvert.SerializeObject(cinema);
            File.WriteAllText(Filename, feedback);
            DialogResult = DialogResult.Cancel;
        }

    }
}
