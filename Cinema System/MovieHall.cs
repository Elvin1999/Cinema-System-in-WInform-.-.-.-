using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.BackgroundImage = Properties.Resources.blurred;
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
        public DialogResult ShowDialoq(dynamic data)
        {
            Data = data;
            labelFilmName.Text = Data.Title;
            
            return base.ShowDialog();
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
        }
    }
}
