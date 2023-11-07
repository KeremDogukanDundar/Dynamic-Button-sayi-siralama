namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rndm = new Random(); //random sayý oluþturdum
        int[] sonuc = new int[6]; // 6 karakterlik dizi oluþturdum
        int p = 0; // p deðeri 0 olarak tanýmladým
        int rastgeleSayi;// rastgele sayý isimli int deðer tanýmlar
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayilar();//sayilar metodunu çaðýrdým

            for (int i = 0; i < 6; i++) //for döngüsü ile i 0'dan baþlar 6'ya kadar birer þekilde artar
            {
                Button buton = new Button(); //buton oluþturma

                buton.Name = "Button" + i.ToString(); //butonun adýný Button0, Button1... gibi arttýrýr oluþturulan buton sayýsýna göre
                buton.Text = sonuc[i].ToString(); //butonun textine diziyi aktarýr
                buton.Size = new Size(100, 50); // butonlarýn boyutunu belirler
                buton.Location = new Point(p, 0); //butonlarýn konumunu belirler
                this.Controls.Add(buton); //butonlarý forma ekler
                p += 110; //110 birim artýrýlýr. Bu düðmelerin birbirlerinin arasýndaki boþluðu ayarlar.
            }
        }
        private void sayilar() // sayilar isimli metot oluþturdum
        {
            for (int sayi = 0; sayi < sonuc.Length; sayi++) //sayi 0 olarak tanýmlar sayi < sonucun.Length kadar birer arttýrýr
            {
                do
                {
                    rastgeleSayi = rndm.Next(1, 36); //rastgeleSayi içinde 1-36 arasýnda deðer olabilir
                } while (Array.IndexOf(sonuc, rastgeleSayi) != -1); //dizide belirli bir deðeri arar ve dizide bulursa bu deðerin dizindeki indeksini döndürür. Eðer bu deðeri dizide bulamazsa -1 döndürür. Yani, bu ifade, rastgeleSayi'nin sonuc dizisinde bulunup bulunmadýðýný kontrol eder.
                sonuc[sayi] = rastgeleSayi; // rastgelesayý sonuç dizisine atanýr
            }
            Array.Sort(sonuc);
            Array.Reverse(sonuc);//büyükten küçüðe sýralar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart(); //application yeniden baþlatýr
        }
    }
}