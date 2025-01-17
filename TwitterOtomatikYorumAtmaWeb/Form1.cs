﻿using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;

namespace TwitterOtomatikYorumAtmaWeb
{
    public partial class frmHome : Form
    {
        public static ListBox hashtagler, hazirmesajlar;
        Color _color = Color.SlateBlue;
        private int hashtag_sayisi, tweet_sayisi, tweet_sayisi_temp;
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hashtag_sayisi = Convert.ToInt32(txt_hashtag_sayisi.Value) - 1;
            tweet_sayisi = Convert.ToInt32(txt_tweet_sayisi.Value);
            tweet_sayisi_temp = Convert.ToInt32(txt_tweet_sayisi.Value);

        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            if (txt_tweet_sayisi.Value == 0)
            {
                MessageBox.Show("Lütfen tweetlere atılacak yorum sayısını, 0(Sıfır)'dan farklı bir rakam seçin.");
            }
            else if (txt_hashtag_sayisi.Value == 0)
            {
                MessageBox.Show("Lütfen en az 1(bir) adet hashtag belirleyin.");
            }
            else if (list_hashtag.Items.Count == 0)
            {
                MessageBox.Show("Lütfen hashtag girişi yapınız.");
            } 
            else if(txt_mail.Text.Equals("") || txt_mail.Text.Equals(null))
            {
                MessageBox.Show("Lütfen hesap adresinizi giriniz.");
            }
            else if(txt_pass.Text.Equals("") || txt_pass.Text.Equals(null))
            {
                MessageBox.Show("Lütfen hesap şifrenizi giriniz.");
            }
            else
            {
                trendlereDon();
                hashtag_sayisi = Convert.ToInt32(txt_hashtag_sayisi.Value) - 1;
                tweet_sayisi = Convert.ToInt32(txt_tweet_sayisi.Value);
                tweet_sayisi_temp = Convert.ToInt32(txt_tweet_sayisi.Value);
                timer_trend.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                timer_hashtagegir.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                timer_yanitla.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                timer_tweeti_yaz.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                timer_tweeti_gonder.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                timer_tweet_dongusu.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                timer_aramayap.Interval = Convert.ToInt32(txt_islem_suresi.Value) * 1000;
                log_box.Clear();
                log_box.SelectionColor = _color;
                log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Ayarlar kaydedildi." + Environment.NewLine);
                log_box.SelectionColor = _color;
                log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Uygulama çalıştırılıyor..." + Environment.NewLine);
                log_box.ScrollToCaret();
                btnBaslat.Enabled = false;
                txt_hashtag_sayisi.Enabled = false;
                txt_tweet_sayisi.Enabled = false;
                txt_islem_suresi.Enabled = false;
                btn_durdur.Enabled = true;
                btnHashtag.Enabled = false;
                btnCikisYap.Enabled = false;
                txt_mail.Enabled = false;
                txt_pass.Enabled = false;


                foreach (HtmlElement element in webBrowser1.Document.All)
                {
                    if (element.Name == "session[username_or_email]")
                    {
                        element.InnerText = txt_mail.Text;
                    }
                    if (element.Name == "session[password]")
                    {
                        element.InnerText = txt_pass.Text;
                    }
                    if (element.Name == "commit")
                    {
                        element.InvokeMember("click");
                        Thread.Sleep(1000);
                        //await Task.Delay(1000);
                        //webBrowser1.Navigate("https://mobile.twitter.com/trends");
                        _color = Color.DarkGreen;
                        log_box.SelectionColor = _color;
                        log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Giriş yapıldı." + Environment.NewLine);
                        log_box.ScrollToCaret();
                    }
                }
                timer_tweet_dongusu.Start();
            }
        }

        private void trendListesiniCek()
        {
            list_hashtag.Items.Clear();
            foreach (HtmlElement element in webBrowser1.Document.All)
            {
                if (element.GetAttribute("classname") == "topic")
                {
                    Thread.Sleep(1);
                    //await Task.Delay(1);
                    ListViewItem lvi = new ListViewItem(element.OuterText);
                    list_hashtag.Items.Add(lvi.Text);
                }
            }
            _color = Color.SlateBlue;
            log_box.SelectionColor = _color;
            log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Hashtag'ler hafızaya kayıt edildi." + Environment.NewLine);
            log_box.ScrollToCaret();
        }

        private void aramaKutucugunaYaz()
        {
            foreach (HtmlElement element in webBrowser1.Document.All)
            {
                if (element.Name == "q")
                {
                    element.InnerText = list_hashtag.Items[hashtag_sayisi].ToString();
                    _color = Color.SlateBlue;
                    log_box.SelectionColor = _color;
                    log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - " + list_hashtag.Items[hashtag_sayisi].ToString() + " isimli hashtag için işlem yapılacak." + Environment.NewLine);
                    log_box.ScrollToCaret();
                }
                if (element.GetAttribute("type") == "image")
                {
                    element.InvokeMember("click");
                    _color = Color.SlateBlue;
                    log_box.SelectionColor = _color;
                    log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - " + list_hashtag.Items[hashtag_sayisi].ToString() + " isimli hashtag için tweetler listelendi." + Environment.NewLine);
                    log_box.ScrollToCaret();
                }
            }
            timer_yanitla.Start();
        }


        private void hashtageGir(int sira)
        {
            foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("a"))
            {
                if (element.OuterText == list_hashtag.Items[sira].ToString())
                {
                    element.InvokeMember("click");
                    Thread.Sleep(1000);
                    //await Task.Delay(1000);
                    _color = Color.Teal;
                    log_box.SelectionColor = _color;
                    log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - " + list_hashtag.Items[sira].ToString() + " hashtag açıldı." + Environment.NewLine);
                    log_box.ScrollToCaret();
                }
            }
        }

        int sayac = 0, temp = 0;
        private void yanitlayaTikla()
        {
            if (txt_tweet_sayisi.Value > 0)
            {
                foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("a"))
                {
                    if (element.GetAttribute("classname") == "first")
                    {
                        if (temp > 0)
                        {
                            temp -= 1;
                            continue;
                        }
                        else
                        {
                            element.InvokeMember("click");
                            Thread.Sleep(500);
                            //await Task.Delay(500);
                            _color = Color.SlateBlue;
                            log_box.SelectionColor = _color;
                            log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Tweet'e giriş yapıldı." + Environment.NewLine);
                            log_box.ScrollToCaret();
                            sayac += 1;
                            temp = sayac;
                            break;
                        }
                    }
                }
            }
            else
            {
                timer_tweet_dongusu.Stop();
                timer_hashtagegir.Stop();
                timer_yanitla.Stop();
                timer_tweeti_yaz.Stop();
                timer_tweeti_gonder.Stop();
                trendlereDon();
                //log_box.AppendText("[BITTI] - İşlemler Tamamlandı!" + Environment.NewLine);
            }
        }

        Random rnd = new Random();
        private void tweetiYaz()
        {
            foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("TEXTAREA"))
            {
                if (element.GetAttribute("classname") == "tweetbox")
                {
                    element.InvokeMember("click");
                    element.InnerText = txtTweetIcerigi.Text + "\n" + listHazirMesajlar.Items[rnd.Next(0, listHazirMesajlar.Items.Count)].ToString();
                    _color = Color.SlateBlue;
                    log_box.SelectionColor = _color;
                    log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Mesaj metniniz kutucuğa yazıldı." + Environment.NewLine);
                    log_box.ScrollToCaret();
                    Thread.Sleep(500);
                    //await Task.Delay(500);
                    break;
                }
            }
        }

        private void tweetiGonder()
        {
            foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("input"))
            {
                if (element.GetAttribute("type") == "submit")
                {
                    element.InvokeMember("click");
                    _color = Color.DarkCyan;
                    log_box.SelectionColor = _color;
                    log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Tweet'e yorum yazıldı." + Environment.NewLine);
                    log_box.ScrollToCaret();
                    txt_tweet_sayisi.Value -= 1;
                    Thread.Sleep(500);
                    trendlereDon();
                    //await Task.Delay(500);
                    break;
                }
            }
        }

        private void trendlereDon()
        {
            if (txt_tweet_sayisi.Value > 0)
            {
                Thread.Sleep(500);
                //await Task.Delay(500);
                webBrowser1.Navigate("https://mobile.twitter.com/trends");
                _color = Color.SlateBlue;
                log_box.SelectionColor = _color;
                log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Trend Listesine dönüldü." + Environment.NewLine);
                log_box.ScrollToCaret();
            }
            else if (txt_hashtag_sayisi.Value > 0)
            {
                Thread.Sleep(500);
                //await Task.Delay(500);
                webBrowser1.Navigate("https://mobile.twitter.com/trends");
                _color = Color.SlateBlue;
                log_box.SelectionColor = _color;
                log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[OK] - Trend Listesine dönüldü." + Environment.NewLine);
                log_box.ScrollToCaret();
            }
            else
            {
                timer_tweet_dongusu.Stop();
                timer_hashtagegir.Stop();
                timer_yanitla.Stop();
                timer_tweeti_yaz.Stop();
                timer_tweeti_gonder.Stop();
                timer_hashtagegir.Enabled = false;
                webBrowser1.Navigate("https://mobile.twitter.com/trends");
                _color = Color.Sienna;
                log_box.SelectionColor = _color;
                log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[FINISH] - İşlemler tamamlandı ve program durdu." + Environment.NewLine);
                log_box.ScrollToCaret();
                btnBaslat.Enabled = true;
                sayac = 0; temp = 0;
                txt_hashtag_sayisi.Enabled = true;
                txt_tweet_sayisi.Enabled = true;
                txt_islem_suresi.Enabled = true;
                btn_durdur.Enabled = false;
            }
        }






        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0)
            {
                //progress_wbrowser.Maximum = (int)e.MaximumProgress;
                //progress_wbrowser.Value = (int)e.CurrentProgress;

            }
        }


        private void timer_trend_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Çalışıyor mu bu 6");
            trendListesiniCek();
            timer_trend.Stop();
            timer_hashtagegir.Start();
        }

        private void timer_hashtagegir_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Çalışıyor mu bu 5");
            hashtageGir(Convert.ToInt32(txt_hashtag_sayisi.Value));
            timer_hashtagegir.Stop();
            timer_yanitla.Start();
        }

        private void timer_yanitla_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Çalışıyor mu bu 4");
            yanitlayaTikla();
            timer_yanitla.Stop();
            timer_tweeti_yaz.Start();

        }

        private void timer_tweeti_yaz_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Çalışıyor mu bu 3");
            tweetiYaz();
            timer_tweeti_yaz.Stop();
            timer_tweeti_gonder.Start();

        }

        private void timer_tweeti_gonder_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Çalışıyor mu bu 2");
            tweetiGonder();
            timer_tweeti_gonder.Stop();
            timer_tweet_dongusu.Start();
        }



        private void timer_tweet_dongusu_Tick(object sender, EventArgs e)
        {
            if (txt_tweet_sayisi.Value > 0)
            {
                Console.WriteLine("Çalışıyor mu bu 1");
                //Thread.Sleep(500);
                timer_aramayap.Start();
                timer_tweet_dongusu.Stop();
            }
            else if (hashtag_sayisi > 0)
            {
                hashtag_sayisi -= 1;
                txt_tweet_sayisi.Value = tweet_sayisi_temp;
                timer_aramayap.Start();
                timer_tweet_dongusu.Stop();
            }
            else
            {
                trendlereDon();
                islemleriDurdur();
            }
        }

        

        private void btnHazirMesajlar_Click(object sender, EventArgs e)
        {
            hazirmesajlar = listHazirMesajlar;
            frm_HazirMesajEkle frm = new frm_HazirMesajEkle();
            frm.ShowDialog();
            listHazirMesajlar.Items.Clear();
            if (frm_HazirMesajEkle.mesajlar.Items.Count > 0)
            {
                for (int i = 0; i < frm_HazirMesajEkle.mesajlar.Items.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(frm_HazirMesajEkle.mesajlar.Items[i].ToString());
                    listHazirMesajlar.Items.Add(lvi.Text);
                }
            }
        }

        private void islemleriDurdur()
        {
            timer_trend.Stop();
            timer_hashtagegir.Stop();
            timer_yanitla.Stop();
            timer_tweeti_yaz.Stop();
            timer_tweeti_gonder.Stop();
            timer_tweet_dongusu.Stop();
            timer_aramayap.Stop();
            btnBaslat.Enabled = true;
            btn_durdur.Enabled = false;
            txt_hashtag_sayisi.Enabled = true;
            txt_islem_suresi.Enabled = true;
            txt_tweet_sayisi.Enabled = true;
            btnHashtag.Enabled = true;
            btnCikisYap.Enabled = true;
            txt_mail.Enabled = true;
            txt_pass.Enabled = true;
            _color = Color.Sienna;
            log_box.SelectionColor = _color;
            log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[FINISH] - İşlemler tamamlandı!" + Environment.NewLine);
            log_box.ScrollToCaret();
            trendlereDon();
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            timer_trend.Stop();
            timer_hashtagegir.Stop();
            timer_yanitla.Stop();
            timer_tweeti_yaz.Stop();
            timer_tweeti_gonder.Stop();
            timer_tweet_dongusu.Stop();
            timer_aramayap.Stop();
            btnBaslat.Enabled = true;
            btn_durdur.Enabled = false;
            txt_hashtag_sayisi.Enabled = true;
            txt_islem_suresi.Enabled = true;
            txt_tweet_sayisi.Enabled = true;
            btnHashtag.Enabled = true;
            btnCikisYap.Enabled = true;
            txt_mail.Enabled = true;
            txt_pass.Enabled = true;
            _color = Color.Sienna;
            log_box.SelectionColor = _color;
            log_box.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "[STOP] - İşlemler kullanıcı tarafından iptal edildi." + Environment.NewLine);
            log_box.ScrollToCaret();
            trendlereDon();
        }

        private void timer_aramayap_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Çalışıyor mu bu 0");
            aramaKutucugunaYaz();
            Thread.Sleep(500);
            timer_aramayap.Stop();
        }



        private void btnHashtag_Click(object sender, EventArgs e)
        {
            hashtagler = list_hashtag;
            frm_hashtagEkle frm = new frm_hashtagEkle();
            frm.ShowDialog();
            list_hashtag.Items.Clear();
            if (frm_hashtagEkle.hashtagler.Items.Count > 0)
            {
                for (int i = 0; i < frm_hashtagEkle.hashtagler.Items.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(frm_hashtagEkle.hashtagler.Items[i].ToString());
                    list_hashtag.Items.Add(lvi.Text);
                }
            }
        }

        private void txtTweetIcerigi_TextChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Kalan Karakter Sayısı: " + (txtTweetIcerigi.MaxLength - txtTweetIcerigi.TextLength);
        }

    }
}
