namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, ders, ogrencinumarasi;
            double ortalama, sinav1, sinav2, proje,sinav1agirlik, sinav2agirlik, projeagirlik;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            ders = textBox6.Text;
            ogrencinumarasi = maskedTextBox1.Text;
            sinav1 = Convert.ToDouble(textBox3.Text);
            sinav2 = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text);
            sinav1agirlik = Convert.ToDouble(textBox7.Text);
            sinav2agirlik = Convert.ToDouble(textBox8.Text);
            projeagirlik = Convert.ToDouble(textBox9.Text);
            ortalama = (sinav1 * sinav1agirlik) + (sinav2 * sinav2agirlik) + (proje * projeagirlik);
            listBox1.Items.Add(ad + " " + soyad + " " + ogrencinumarasi + " " + ders + " " + "Ortalama: " + ortalama);
        }
    }
}
