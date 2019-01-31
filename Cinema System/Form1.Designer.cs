namespace Cinema_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroBtSelect = new MetroFramework.Controls.MetroButton();
            this.metroLbTitle = new MetroFramework.Controls.MetroLabel();
            this.metroBtnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLbGenre = new MetroFramework.Controls.MetroLabel();
            this.metroLbYear = new MetroFramework.Controls.MetroLabel();
            this.metroLbTime = new MetroFramework.Controls.MetroLabel();
            this.metroLbLanguage = new MetroFramework.Controls.MetroLabel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.metroLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabelGenre = new MetroFramework.Controls.MetroLabel();
            this.metroLabelYear = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLanguage = new MetroFramework.Controls.MetroLabel();
            this.metroBtLeft = new MetroFramework.Controls.MetroButton();
            this.metroBtRight = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.webBrowserYoutube = new System.Windows.Forms.WebBrowser();
            this.labelNamemovie = new System.Windows.Forms.Label();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // metroBtSelect
            // 
            this.metroBtSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroBtSelect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtSelect.ForeColor = System.Drawing.Color.Yellow;
            this.metroBtSelect.Highlight = true;
            this.metroBtSelect.Location = new System.Drawing.Point(179, 544);
            this.metroBtSelect.Name = "metroBtSelect";
            this.metroBtSelect.Size = new System.Drawing.Size(126, 43);
            this.metroBtSelect.TabIndex = 0;
            this.metroBtSelect.Text = "Select movie";
            this.metroBtSelect.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBtSelect.UseCustomBackColor = true;
            this.metroBtSelect.UseCustomForeColor = true;
            this.metroBtSelect.UseSelectable = true;
            this.metroBtSelect.UseStyleColors = true;
            this.metroBtSelect.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLbTitle
            // 
            this.metroLbTitle.BackColor = System.Drawing.Color.Black;
            this.metroLbTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLbTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLbTitle.ForeColor = System.Drawing.Color.Yellow;
            this.metroLbTitle.Location = new System.Drawing.Point(537, 59);
            this.metroLbTitle.Name = "metroLbTitle";
            this.metroLbTitle.Size = new System.Drawing.Size(124, 26);
            this.metroLbTitle.TabIndex = 5;
            this.metroLbTitle.Text = "Title";
            this.metroLbTitle.UseCustomBackColor = true;
            this.metroLbTitle.UseCustomForeColor = true;
            this.metroLbTitle.UseStyleColors = true;
            // 
            // metroBtnSearch
            // 
            this.metroBtnSearch.BackColor = System.Drawing.Color.Black;
            this.metroBtnSearch.DisplayFocus = true;
            this.metroBtnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtnSearch.ForeColor = System.Drawing.Color.Yellow;
            this.metroBtnSearch.Highlight = true;
            this.metroBtnSearch.Location = new System.Drawing.Point(537, 4);
            this.metroBtnSearch.Name = "metroBtnSearch";
            this.metroBtnSearch.Size = new System.Drawing.Size(124, 26);
            this.metroBtnSearch.TabIndex = 0;
            this.metroBtnSearch.Text = "Search";
            this.metroBtnSearch.UseCustomBackColor = true;
            this.metroBtnSearch.UseCustomForeColor = true;
            this.metroBtnSearch.UseSelectable = true;
            this.metroBtnSearch.UseStyleColors = true;
            this.metroBtnSearch.Click += new System.EventHandler(this.metroBtnSearch_Click);
            // 
            // metroLbGenre
            // 
            this.metroLbGenre.BackColor = System.Drawing.Color.Black;
            this.metroLbGenre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLbGenre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLbGenre.ForeColor = System.Drawing.Color.Yellow;
            this.metroLbGenre.Location = new System.Drawing.Point(537, 131);
            this.metroLbGenre.Name = "metroLbGenre";
            this.metroLbGenre.Size = new System.Drawing.Size(124, 26);
            this.metroLbGenre.TabIndex = 5;
            this.metroLbGenre.Text = "Genre";
            this.metroLbGenre.UseCustomBackColor = true;
            this.metroLbGenre.UseCustomForeColor = true;
            this.metroLbGenre.UseStyleColors = true;
            // 
            // metroLbYear
            // 
            this.metroLbYear.BackColor = System.Drawing.Color.Black;
            this.metroLbYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLbYear.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLbYear.ForeColor = System.Drawing.Color.Yellow;
            this.metroLbYear.Location = new System.Drawing.Point(536, 213);
            this.metroLbYear.Name = "metroLbYear";
            this.metroLbYear.Size = new System.Drawing.Size(124, 26);
            this.metroLbYear.TabIndex = 5;
            this.metroLbYear.Text = "Year";
            this.metroLbYear.UseCustomBackColor = true;
            this.metroLbYear.UseCustomForeColor = true;
            this.metroLbYear.UseStyleColors = true;
            // 
            // metroLbTime
            // 
            this.metroLbTime.BackColor = System.Drawing.Color.Black;
            this.metroLbTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLbTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLbTime.ForeColor = System.Drawing.Color.Yellow;
            this.metroLbTime.Location = new System.Drawing.Point(536, 254);
            this.metroLbTime.Name = "metroLbTime";
            this.metroLbTime.Size = new System.Drawing.Size(124, 26);
            this.metroLbTime.TabIndex = 5;
            this.metroLbTime.Text = "RunTime";
            this.metroLbTime.UseCustomBackColor = true;
            this.metroLbTime.UseCustomForeColor = true;
            this.metroLbTime.UseStyleColors = true;
            // 
            // metroLbLanguage
            // 
            this.metroLbLanguage.BackColor = System.Drawing.Color.Black;
            this.metroLbLanguage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLbLanguage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLbLanguage.ForeColor = System.Drawing.Color.Yellow;
            this.metroLbLanguage.Location = new System.Drawing.Point(536, 295);
            this.metroLbLanguage.Name = "metroLbLanguage";
            this.metroLbLanguage.Size = new System.Drawing.Size(124, 26);
            this.metroLbLanguage.TabIndex = 5;
            this.metroLbLanguage.Text = "Language";
            this.metroLbLanguage.UseCustomBackColor = true;
            this.metroLbLanguage.UseCustomForeColor = true;
            this.metroLbLanguage.UseStyleColors = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Black;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxSearch.Location = new System.Drawing.Point(28, 4);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(460, 26);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.Text = "Search movie . . .";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            this.textBoxSearch.MouseEnter += new System.EventHandler(this.textBoxSearch_MouseEnter);
            this.textBoxSearch.MouseLeave += new System.EventHandler(this.textBoxSearch_MouseLeave);
            // 
            // metroLabelTitle
            // 
            this.metroLabelTitle.BackColor = System.Drawing.Color.Black;
            this.metroLabelTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelTitle.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabelTitle.Location = new System.Drawing.Point(666, 59);
            this.metroLabelTitle.Name = "metroLabelTitle";
            this.metroLabelTitle.Size = new System.Drawing.Size(236, 60);
            this.metroLabelTitle.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabelTitle.TabIndex = 5;
            this.metroLabelTitle.UseCustomBackColor = true;
            this.metroLabelTitle.UseCustomForeColor = true;
            this.metroLabelTitle.UseStyleColors = true;
            // 
            // metroLabelGenre
            // 
            this.metroLabelGenre.BackColor = System.Drawing.Color.Black;
            this.metroLabelGenre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelGenre.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabelGenre.Location = new System.Drawing.Point(666, 131);
            this.metroLabelGenre.Name = "metroLabelGenre";
            this.metroLabelGenre.Size = new System.Drawing.Size(236, 69);
            this.metroLabelGenre.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabelGenre.TabIndex = 5;
            this.metroLabelGenre.UseCustomBackColor = true;
            this.metroLabelGenre.UseCustomForeColor = true;
            this.metroLabelGenre.UseStyleColors = true;
            // 
            // metroLabelYear
            // 
            this.metroLabelYear.BackColor = System.Drawing.Color.Black;
            this.metroLabelYear.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelYear.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabelYear.Location = new System.Drawing.Point(666, 213);
            this.metroLabelYear.Name = "metroLabelYear";
            this.metroLabelYear.Size = new System.Drawing.Size(124, 26);
            this.metroLabelYear.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabelYear.TabIndex = 5;
            this.metroLabelYear.UseCustomBackColor = true;
            this.metroLabelYear.UseCustomForeColor = true;
            this.metroLabelYear.UseStyleColors = true;
            // 
            // metroLabelTime
            // 
            this.metroLabelTime.BackColor = System.Drawing.Color.Black;
            this.metroLabelTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelTime.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabelTime.Location = new System.Drawing.Point(666, 254);
            this.metroLabelTime.Name = "metroLabelTime";
            this.metroLabelTime.Size = new System.Drawing.Size(124, 26);
            this.metroLabelTime.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabelTime.TabIndex = 5;
            this.metroLabelTime.UseCustomBackColor = true;
            this.metroLabelTime.UseCustomForeColor = true;
            this.metroLabelTime.UseStyleColors = true;
            // 
            // metroLabelLanguage
            // 
            this.metroLabelLanguage.BackColor = System.Drawing.Color.Black;
            this.metroLabelLanguage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelLanguage.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabelLanguage.Location = new System.Drawing.Point(666, 295);
            this.metroLabelLanguage.Name = "metroLabelLanguage";
            this.metroLabelLanguage.Size = new System.Drawing.Size(124, 26);
            this.metroLabelLanguage.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabelLanguage.TabIndex = 5;
            this.metroLabelLanguage.UseCustomBackColor = true;
            this.metroLabelLanguage.UseCustomForeColor = true;
            this.metroLabelLanguage.UseStyleColors = true;
            // 
            // metroBtLeft
            // 
            this.metroBtLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroBtLeft.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroBtLeft.ForeColor = System.Drawing.Color.Yellow;
            this.metroBtLeft.Highlight = true;
            this.metroBtLeft.Location = new System.Drawing.Point(99, 544);
            this.metroBtLeft.Name = "metroBtLeft";
            this.metroBtLeft.Size = new System.Drawing.Size(74, 43);
            this.metroBtLeft.TabIndex = 0;
            this.metroBtLeft.Text = " <<<";
            this.metroBtLeft.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBtLeft.UseCustomBackColor = true;
            this.metroBtLeft.UseCustomForeColor = true;
            this.metroBtLeft.UseSelectable = true;
            this.metroBtLeft.UseStyleColors = true;
            this.metroBtLeft.Click += new System.EventHandler(this.metroBtLeft_Click);
            // 
            // metroBtRight
            // 
            this.metroBtRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroBtRight.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroBtRight.ForeColor = System.Drawing.Color.Yellow;
            this.metroBtRight.Highlight = true;
            this.metroBtRight.Location = new System.Drawing.Point(311, 544);
            this.metroBtRight.Name = "metroBtRight";
            this.metroBtRight.Size = new System.Drawing.Size(73, 43);
            this.metroBtRight.TabIndex = 0;
            this.metroBtRight.Text = " >>>";
            this.metroBtRight.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBtRight.UseCustomBackColor = true;
            this.metroBtRight.UseCustomForeColor = true;
            this.metroBtRight.UseSelectable = true;
            this.metroBtRight.UseStyleColors = true;
            this.metroBtRight.Click += new System.EventHandler(this.metroBtRight_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Black;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.Color.Yellow;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(846, 4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(56, 34);
            this.metroButton3.TabIndex = 0;
            this.metroButton3.Text = "X";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // webBrowserYoutube
            // 
            this.webBrowserYoutube.Location = new System.Drawing.Point(583, 422);
            this.webBrowserYoutube.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserYoutube.Name = "webBrowserYoutube";
            this.webBrowserYoutube.ScrollBarsEnabled = false;
            this.webBrowserYoutube.Size = new System.Drawing.Size(312, 194);
            this.webBrowserYoutube.TabIndex = 7;
            // 
            // labelNamemovie
            // 
            this.labelNamemovie.AutoEllipsis = true;
            this.labelNamemovie.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamemovie.ForeColor = System.Drawing.Color.Silver;
            this.labelNamemovie.Location = new System.Drawing.Point(28, 459);
            this.labelNamemovie.Name = "labelNamemovie";
            this.labelNamemovie.Size = new System.Drawing.Size(460, 66);
            this.labelNamemovie.TabIndex = 8;
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxMovie.Image = global::Cinema_System.Properties.Resources.Cinemaimage;
            this.pictureBoxMovie.Location = new System.Drawing.Point(28, 59);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(460, 393);
            this.pictureBoxMovie.TabIndex = 1;
            this.pictureBoxMovie.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(907, 628);
            this.Controls.Add(this.labelNamemovie);
            this.Controls.Add(this.webBrowserYoutube);
            this.Controls.Add(this.metroLabelLanguage);
            this.Controls.Add(this.metroLbLanguage);
            this.Controls.Add(this.metroLabelTime);
            this.Controls.Add(this.metroLbTime);
            this.Controls.Add(this.metroLabelYear);
            this.Controls.Add(this.metroLabelGenre);
            this.Controls.Add(this.metroLbYear);
            this.Controls.Add(this.metroLabelTitle);
            this.Controls.Add(this.metroLbGenre);
            this.Controls.Add(this.metroLbTitle);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxMovie);
            this.Controls.Add(this.metroBtnSearch);
            this.Controls.Add(this.metroBtRight);
            this.Controls.Add(this.metroBtLeft);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroBtSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroBtSelect;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
        private MetroFramework.Controls.MetroLabel metroLbTitle;
        private MetroFramework.Controls.MetroButton metroBtnSearch;
        private MetroFramework.Controls.MetroLabel metroLbGenre;
        private MetroFramework.Controls.MetroLabel metroLbYear;
        private MetroFramework.Controls.MetroLabel metroLbTime;
        private MetroFramework.Controls.MetroLabel metroLbLanguage;
        private System.Windows.Forms.TextBox textBoxSearch;
        private MetroFramework.Controls.MetroLabel metroLabelTitle;
        private MetroFramework.Controls.MetroLabel metroLabelGenre;
        private MetroFramework.Controls.MetroLabel metroLabelYear;
        private MetroFramework.Controls.MetroLabel metroLabelTime;
        private MetroFramework.Controls.MetroLabel metroLabelLanguage;
        private MetroFramework.Controls.MetroButton metroBtLeft;
        private MetroFramework.Controls.MetroButton metroBtRight;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.WebBrowser webBrowserYoutube;
        private System.Windows.Forms.Label labelNamemovie;
    }
}

