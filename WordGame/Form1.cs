namespace WordGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Sayac = 0;
        int DogruSayisi = 0;
        int YanlisSayisi = 0;
        string Cevap;
        private string[] Sorular;
        private int SecilenButon;

        private void Form1_Load(object sender, EventArgs e)
        {
            SoruKontrolu();
        }

        private void SoruKontrolu()
        {
            if (Sorular == null)
            {
                string DosyaYolu = @"C:\\Users\\Elif\\Desktop\\WordGame\\Sorular.txt";
                Sorular = File.ReadAllLines(DosyaYolu);
            }

            if (Sayac >= 0 && Sayac < Sorular.Length)
            {
                string[] Soru = Sorular[Sayac].Split(';');
                Kelime.Text = Soru[0];
                button1.Text = Soru[1];
                button2.Text = Soru[2];
                button3.Text = Soru[3];
                button4.Text = Soru[4];
                Cevap = Soru[5];
            }
        }

        private void CevapKontrolu()
        {
            switch (Cevap)
            {
                case "1":
                    button1.BackColor = Color.Green;
                    break;
                case "2":
                    button2.BackColor = Color.Green;
                    break;
                case "3":
                    button3.BackColor = Color.Green;
                    break;
                case "4":
                    button4.BackColor = Color.Green;
                    break;
            }

            if (SecilenButon == int.Parse(Cevap))
            {
                DogruSayisi++;
                DogruCevapSayisi.Text = DogruSayisi.ToString();

            }
            else
            {
                YanlisSayisi++;
                YanlisCevapSayisi.Text = YanlisSayisi.ToString();

                switch (SecilenButon)
                {
                    case 1:
                        button1.BackColor = Color.Red;
                        break;
                    case 2:
                        button2.BackColor = Color.Red;
                        break;
                    case 3:
                        button3.BackColor = Color.Red;
                        break;
                    case 4:
                        button4.BackColor = Color.Red;
                        break;
                }
            }

            RenkDegisimZamanlayicisi.Interval = 700;
            RenkDegisimZamanlayicisi.Tick += new EventHandler(RenkDegisimZamanlayicisi_Tick);
            RenkDegisimZamanlayicisi.Start();
        }

        private void OyunuSonlandir()
        {
            Kelime.Text = "Son";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            SoruSayisi.Visible = false;
            label3.Visible = false;
        }

        private void SonrakiSoruyaGec()
        {
            Sayac++;

            if (Sayac > Sorular.Length)
            {
                OyunuSonlandir();
            }
            else
            {
                SoruSayisi.Text = (Sayac + 1).ToString();
                SoruDegistirmeZamanlayicisi.Interval = 1000;
                SoruDegistirmeZamanlayicisi.Tick += SoruDegistirmeZamanlayicisi_Tick;
                SoruDegistirmeZamanlayicisi.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecilenButon = 1;
            CevapKontrolu();
            SonrakiSoruyaGec();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecilenButon = 2;
            CevapKontrolu();
            SonrakiSoruyaGec();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecilenButon = 3;
            CevapKontrolu();
            SonrakiSoruyaGec();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SecilenButon = 4;
            CevapKontrolu();
            SonrakiSoruyaGec();
        }

        private void RenkDegisimZamanlayicisi_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button4.BackColor = Color.FromArgb(192, 192, 255);
            RenkDegisimZamanlayicisi.Stop();
        }

        private void SoruDegistirmeZamanlayicisi_Tick(object sender, EventArgs e)
        {
            SoruKontrolu();
            SoruDegistirmeZamanlayicisi.Stop();
        }
    }
}
