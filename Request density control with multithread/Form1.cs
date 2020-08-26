using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        
        List<Sunucular> AltSunucular;
        int sayacProgresbar = 0, kontrolSayac = 0, forSayac = 0;
        List<ProgressBar> progressBarList = new List<ProgressBar>();
        Thread mainThread, altThread1, altThread2;

        Sunucular ana_sunucu;
        Sunucular alt_sunucu1;
        Sunucular alt_sunucu2;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            ana_sunucu = new Sunucular(10000, 500, 200, 170, 50, 1);
            alt_sunucu1 = new Sunucular(5000, 500, 300, 70, 50, 1);
            alt_sunucu2 = new Sunucular(5000, 500, 300, 50, 50, 1);
            mainThread = new Thread(MainThreadBaslat);
            AltSunucular = new List<Sunucular>();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mainThread.Start();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //mainThread.Interrupt();
            //progresbarOlustur();
            //mainThread.Abort();
        }

        private void MainThreadBaslat()
        {

            while (mainThread.IsAlive)
            {
                Thread istekal = new Thread(ana_sunucu.SIstekGonderme);
                if (!istekal.IsAlive && !(ana_sunucu.istek_sayisi > ana_sunucu.kapasite))
                {
                    istekal.Start();
                   int sayi = ana_sunucu.istek_sayisi * 100 / (ana_sunucu.kapasite +70); // kapasite değiştirildiğinde burası değiştiriliyor
                    if (sayi <= 0)
                    {
                        progressBar2.Value = 0;
                    }
                    else
                    {
                        progressBar2.Value = sayi;
                    }
                    
                   
                }
                else if (ana_sunucu.istek_sayisi >= ana_sunucu.kapasite)
                {
                    progressBar2.Value = 100;
                }
                Thread istekyoket = new Thread(ana_sunucu.SIstekYoketme);
                if(!istekyoket.IsAlive && ana_sunucu.istek_sayisi != 1)
                    istekyoket.Start();
                
                
                if (ana_sunucu.kapasite <= ana_sunucu.istek_sayisi)
                {
                    label4.Text = "Doldu";
                    //mainThread.Abort();
                }
                if(ana_sunucu.istek_sayisi <= 0)
                {
                    label4.Text = "Boşaldı";
                   // mainThread.Abort();
                }

                Thread alt1istekSomur = new Thread(() => alt_sunucu1.SunucuSomur(ana_sunucu));
                if (!alt1istekSomur.IsAlive && ana_sunucu.istek_sayisi != 1 && !(alt_sunucu1.istek_sayisi >= alt_sunucu1.kapasite))
                {
                    alt1istekSomur.Start();
                    progressBar3.Value = alt_sunucu1.istek_sayisi * 100 / (alt_sunucu1.kapasite+20); // kapasite değiştirildiğinde değiştir
                    label3.Text = "Alt Sunucu 1 Sömürüyor";
                }
                else if (alt_sunucu1.istek_sayisi >= alt_sunucu1.kapasite)
                {
                    label3.Text = "Alt Sunucu 1 doldu";
                    progressBar3.Value = alt_sunucu1.istek_sayisi * 100 / (alt_sunucu1.kapasite) ; 
                }

                Thread alt2istekSomur = new Thread(() => alt_sunucu2.SunucuSomur(ana_sunucu));
                if (!alt2istekSomur.IsAlive && ana_sunucu.istek_sayisi != 1 && !(alt_sunucu2.istek_sayisi >= alt_sunucu2.kapasite))
                {
                    alt2istekSomur.Start();
                    progressBar4.Value = alt_sunucu2.istek_sayisi * 100 / alt_sunucu2.kapasite; // kapasite değiştirildiğinde değiştir
                    label4.Text = "Alt Sunucu 2 Sömürüyor";
                }
                else if (alt_sunucu2.istek_sayisi >= alt_sunucu2.kapasite)
                {
                    label4.Text = "Alt Sunucu 2 doldu";
                    progressBar4.Value = alt_sunucu2.istek_sayisi * 100 / (alt_sunucu2.kapasite ); 
                }

                Thread A1istekyoket = new Thread(alt_sunucu1.SIstekYoketme);
                if (!A1istekyoket.IsAlive && alt_sunucu1.istek_sayisi != 1)
                    A1istekyoket.Start();

                Thread A2istekyoket = new Thread(alt_sunucu2.SIstekYoketme);
                if (!A2istekyoket.IsAlive && alt_sunucu2.istek_sayisi != 1)
                    A2istekyoket.Start();


                if (alt_sunucu1.SunucuKontrol() && kontrolSayac == 0)
                {
                    AltSunucular.Add(alt_sunucu1.AltSunucOlustur());
                    kontrolSayac++;
                    Thread olustur1 = new Thread(ProgresbarOlustur);
                    if (!olustur1.IsAlive)
                    {
                        olustur1.Start();
                        kontrolSayac = 0;
                    }
                    
                }

                if (alt_sunucu2.SunucuKontrol() && kontrolSayac == 0)
                {
                    AltSunucular.Add(alt_sunucu1.AltSunucOlustur());
                    kontrolSayac++;
                    Thread olustur2 = new Thread(ProgresbarOlustur);
                    if (!olustur2.IsAlive)
                    {
                        olustur2.Start();
                        kontrolSayac = 0;
                    }

                }

                AltSunucular.ForEach((s) => AltSunucuCalistir(s));
                forSayac = 0;
                AltSunucular.ForEach((s) => AltSunucuTuket(s));
                forSayac = 0;
                if(sayacProgresbar <= 8)
                for (int i= 0; i < AltSunucular.Count; i++)
                {
                    AltSunucuKontrol(AltSunucular.ElementAt(i));
                }



                progressBarGuncelle();
            }
            
            //Thread.Sleep(Timeout.Infinite);

        }

        private void AltSunucuKontrol(Sunucular s)
        {
            if (s.SunucuKontrol())
            {
                AltSunucular.Add(s.AltSunucOlustur());
                //kontrolSayac++;
                Thread olustur = new Thread(ProgresbarOlustur);
                if (!olustur.IsAlive)
                {
                    olustur.Start();
                    //kontrolSayac = 0;
                }

            }
        }


        private void AltSunucuCalistir(Sunucular s)
        {
            Thread altsomuru = new Thread(() => s.SunucuSomur(ana_sunucu));
            if (!altsomuru.IsAlive && !(s.istek_sayisi >= s.kapasite))
            {
                altsomuru.Start();
                ProgressBar progress = this.Controls.Find("progressBar" + ((forSayac) + 5).ToString(), true).FirstOrDefault() as ProgressBar;
                progress.Value = s.istek_sayisi * 100 / (s.kapasite);  // kapasite değiştirildiğinde değiştir

            }
            else if (s.istek_sayisi >= s.kapasite)
            {
                //label4.Text = "Alt Sunucu 2 doldu";
                ProgressBar progress = this.Controls.Find("progressBar" + ((forSayac) + 5).ToString(), true).FirstOrDefault() as ProgressBar;
                progress.Value = s.istek_sayisi * 100 / (s.kapasite );  
            }
            forSayac++;
        }

        private void AltSunucuTuket(Sunucular s)
        {
            Thread altTuketim = new Thread(s.SIstekYoketme);
            if (!altTuketim.IsAlive && (s.istek_sayisi > 0))
            {
                altTuketim.Start();
                ProgressBar progress = this.Controls.Find("progressBar" + ((forSayac) + 5).ToString(), true).FirstOrDefault() as ProgressBar;
                progress.Value = s.istek_sayisi * 100 / (s.kapasite);  // kapasite değiştirildiğinde değiştir

            }
            else if (s.istek_sayisi <= 0)
            {
                //label4.Text = "Alt Sunucu 2 doldu";
                ProgressBar progress = this.Controls.Find("progressBar" + ((forSayac) + 5).ToString(), true).FirstOrDefault() as ProgressBar;
                progress.Value = s.istek_sayisi * 100 / (s.kapasite );  
                AltSunucular.Remove(s);
                sayacProgresbar--;
                altTuketim.Abort();
            }
            forSayac++;
        }

        private void progressBarGuncelle()
        {
            for(int i=0; i<sayacProgresbar; i++)
            {
                ProgressBar progress = this.Controls.Find("progressBar" + ((i) + 5).ToString(), true).FirstOrDefault() as ProgressBar;
                progress.Value = AltSunucular.ElementAt(i).istek_sayisi * 100 / (AltSunucular.ElementAt(i).kapasite );  // kapasite değiştirildiğinde değiştir
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private  void ProgresbarOlustur()
        {
            //Label label = this.Controls.Find("label" + (sayacProgresbar+7).ToString(), true).FirstOrDefault() as Label;
            ProgressBar progress = this.Controls.Find("progressBar" + (sayacProgresbar + 5).ToString(), true).FirstOrDefault() as ProgressBar;
            progress.Value = AltSunucular.ElementAt(sayacProgresbar).istek_sayisi * 100 / AltSunucular.ElementAt(sayacProgresbar).kapasite ;
            sayacProgresbar++;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        /*System.Windows.Forms.ProgressBar progressBar = new ProgressBar();
                    progressBar.Name = "progressBar" + k.ToString();
                    progressBar.Location = new System.Drawing.Point(57, 90);
                    progressBar.Size = new System.Drawing.Size(325, 30);
                    progressBar.TabIndex = 0;
                    Controls.Add(progressBar);
                    k++;*/

    }
}
