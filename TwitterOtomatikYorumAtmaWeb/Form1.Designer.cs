namespace TwitterOtomatikYorumAtmaWeb
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.frmHome = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_hashtag = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.log_box = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.progress_wbrowser = new System.Windows.Forms.ProgressBar();
            this.timer_trend = new System.Windows.Forms.Timer(this.components);
            this.timer_hashtagegir = new System.Windows.Forms.Timer(this.components);
            this.timer_yanitla = new System.Windows.Forms.Timer(this.components);
            this.timer_tweeti_yaz = new System.Windows.Forms.Timer(this.components);
            this.timer_tweeti_gonder = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_islem_suresi = new System.Windows.Forms.NumericUpDown();
            this.txt_tweet_sayisi = new System.Windows.Forms.NumericUpDown();
            this.txt_hashtag_sayisi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_tweet_dongusu = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem_suresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tweet_sayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hashtag_sayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail Adresi ve Şifre";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(3, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pass.Location = new System.Drawing.Point(3, 67);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(213, 30);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "1530740789";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(3, 31);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(213, 30);
            this.txt_mail.TabIndex = 0;
            this.txt_mail.Text = "insmuhbey@gmail.com";
            // 
            // frmHome
            // 
            this.frmHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmHome.Location = new System.Drawing.Point(313, 12);
            this.frmHome.Name = "frmHome";
            this.frmHome.Size = new System.Drawing.Size(117, 40);
            this.frmHome.TabIndex = 4;
            this.frmHome.Text = "Başlat";
            this.frmHome.UseVisualStyleBackColor = true;
            this.frmHome.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_hashtag);
            this.groupBox3.Location = new System.Drawing.Point(327, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 143);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hashtag";
            // 
            // list_hashtag
            // 
            this.list_hashtag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_hashtag.FormattingEnabled = true;
            this.list_hashtag.ItemHeight = 16;
            this.list_hashtag.Location = new System.Drawing.Point(3, 18);
            this.list_hashtag.Name = "list_hashtag";
            this.list_hashtag.Size = new System.Drawing.Size(152, 122);
            this.list_hashtag.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 143);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mesajınız";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 122);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.log_box);
            this.groupBox5.Controls.Add(this.webBrowser1);
            this.groupBox5.Location = new System.Drawing.Point(14, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1140, 592);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tarayıcı";
            // 
            // log_box
            // 
            this.log_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.log_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.log_box.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.log_box.Location = new System.Drawing.Point(597, 18);
            this.log_box.Name = "log_box";
            this.log_box.ReadOnly = true;
            this.log_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.log_box.Size = new System.Drawing.Size(540, 571);
            this.log_box.TabIndex = 20;
            this.log_box.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(588, 571);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("http://m.twitter.com/login", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // progress_wbrowser
            // 
            this.progress_wbrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress_wbrowser.Location = new System.Drawing.Point(12, 162);
            this.progress_wbrowser.Name = "progress_wbrowser";
            this.progress_wbrowser.Size = new System.Drawing.Size(1146, 23);
            this.progress_wbrowser.TabIndex = 9;
            // 
            // timer_trend
            // 
            this.timer_trend.Interval = 2001;
            this.timer_trend.Tick += new System.EventHandler(this.timer_trend_Tick);
            // 
            // timer_hashtagegir
            // 
            this.timer_hashtagegir.Interval = 2001;
            this.timer_hashtagegir.Tick += new System.EventHandler(this.timer_hashtagegir_Tick);
            // 
            // timer_yanitla
            // 
            this.timer_yanitla.Interval = 2001;
            this.timer_yanitla.Tick += new System.EventHandler(this.timer_yanitla_Tick);
            // 
            // timer_tweeti_yaz
            // 
            this.timer_tweeti_yaz.Interval = 2001;
            this.timer_tweeti_yaz.Tick += new System.EventHandler(this.timer_tweeti_yaz_Tick);
            // 
            // timer_tweeti_gonder
            // 
            this.timer_tweeti_gonder.Interval = 2001;
            this.timer_tweeti_gonder.Tick += new System.EventHandler(this.timer_tweeti_gonder_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_durdur);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_islem_suresi);
            this.groupBox2.Controls.Add(this.txt_tweet_sayisi);
            this.groupBox2.Controls.Add(this.txt_hashtag_sayisi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.frmHome);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(722, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 143);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AYARLAR";
            // 
            // btn_durdur
            // 
            this.btn_durdur.Enabled = false;
            this.btn_durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_durdur.Location = new System.Drawing.Point(312, 100);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(117, 40);
            this.btn_durdur.TabIndex = 19;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(81, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kaç saniyede\r\nbir işlem yapsın";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_islem_suresi
            // 
            this.txt_islem_suresi.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_islem_suresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_islem_suresi.Location = new System.Drawing.Point(9, 98);
            this.txt_islem_suresi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_islem_suresi.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txt_islem_suresi.Name = "txt_islem_suresi";
            this.txt_islem_suresi.Size = new System.Drawing.Size(67, 34);
            this.txt_islem_suresi.TabIndex = 17;
            this.txt_islem_suresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_islem_suresi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txt_tweet_sayisi
            // 
            this.txt_tweet_sayisi.BackColor = System.Drawing.Color.DarkKhaki;
            this.txt_tweet_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tweet_sayisi.Location = new System.Drawing.Point(9, 58);
            this.txt_tweet_sayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txt_tweet_sayisi.Name = "txt_tweet_sayisi";
            this.txt_tweet_sayisi.Size = new System.Drawing.Size(66, 34);
            this.txt_tweet_sayisi.TabIndex = 16;
            this.txt_tweet_sayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tweet_sayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_hashtag_sayisi
            // 
            this.txt_hashtag_sayisi.BackColor = System.Drawing.Color.RosyBrown;
            this.txt_hashtag_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hashtag_sayisi.Location = new System.Drawing.Point(9, 18);
            this.txt_hashtag_sayisi.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.txt_hashtag_sayisi.Name = "txt_hashtag_sayisi";
            this.txt_hashtag_sayisi.Size = new System.Drawing.Size(66, 34);
            this.txt_hashtag_sayisi.TabIndex = 15;
            this.txt_hashtag_sayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hashtag_sayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(81, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hashtag içerisinden kaç\r\ntweete yorum atılsın";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kaç Hashtag ile\r\nişlem yapalım?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_tweet_dongusu
            // 
            this.timer_tweet_dongusu.Interval = 2001;
            this.timer_tweet_dongusu.Tick += new System.EventHandler(this.timer_tweet_dongusu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 795);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progress_wbrowser);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Otomatik Yorum Yapıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_islem_suresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tweet_sayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hashtag_sayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button frmHome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ListBox list_hashtag;
        private System.Windows.Forms.ProgressBar progress_wbrowser;
        private System.Windows.Forms.Timer timer_trend;
        private System.Windows.Forms.Timer timer_hashtagegir;
        private System.Windows.Forms.Timer timer_yanitla;
        private System.Windows.Forms.Timer timer_tweeti_yaz;
        private System.Windows.Forms.Timer timer_tweeti_gonder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_tweet_sayisi;
        private System.Windows.Forms.NumericUpDown txt_hashtag_sayisi;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer_tweet_dongusu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_islem_suresi;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.RichTextBox log_box;
        private System.Windows.Forms.Button button1;
    }
}

