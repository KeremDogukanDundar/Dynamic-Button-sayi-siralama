namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rndm = new Random(); //random say� olu�turdum
        int[] sonuc = new int[6]; // 6 karakterlik dizi olu�turdum
        int p = 0; // p de�eri 0 olarak tan�mlad�m
        int rastgeleSayi;// rastgele say� isimli int de�er tan�mlar
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayilar();//sayilar metodunu �a��rd�m

            for (int i = 0; i < 6; i++) //for d�ng�s� ile i 0'dan ba�lar 6'ya kadar birer �ekilde artar
            {
                Button buton = new Button(); //buton olu�turma

                buton.Name = "Button" + i.ToString(); //butonun ad�n� Button0, Button1... gibi artt�r�r olu�turulan buton say�s�na g�re
                buton.Text = sonuc[i].ToString(); //butonun textine diziyi aktar�r
                buton.Size = new Size(100, 50); // butonlar�n boyutunu belirler
                buton.Location = new Point(p, 0); //butonlar�n konumunu belirler
                this.Controls.Add(buton); //butonlar� forma ekler
                p += 110; //110 birim art�r�l�r. Bu d��melerin birbirlerinin aras�ndaki bo�lu�u ayarlar.
            }
        }
        private void sayilar() // sayilar isimli metot olu�turdum
        {
            for (int sayi = 0; sayi < sonuc.Length; sayi++) //sayi 0 olarak tan�mlar sayi < sonucun.Length kadar birer artt�r�r
            {
                do
                {
                    rastgeleSayi = rndm.Next(1, 36); //rastgeleSayi i�inde 1-36 aras�nda de�er olabilir
                } while (Array.IndexOf(sonuc, rastgeleSayi) != -1); //dizide belirli bir de�eri arar ve dizide bulursa bu de�erin dizindeki indeksini d�nd�r�r. E�er bu de�eri dizide bulamazsa -1 d�nd�r�r. Yani, bu ifade, rastgeleSayi'nin sonuc dizisinde bulunup bulunmad���n� kontrol eder.
                sonuc[sayi] = rastgeleSayi; // rastgelesay� sonu� dizisine atan�r
            }
            Array.Sort(sonuc);
            Array.Reverse(sonuc);//b�y�kten k����e s�ralar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart(); //application yeniden ba�lat�r
        }
    }
}