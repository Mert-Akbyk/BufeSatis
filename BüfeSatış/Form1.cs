namespace BüfeSatış
{
    public partial class Form1 : Form
    {
        int kasa = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, mısır, su, kola, toplam;

            bilet = Convert.ToInt32(textBox1.Text);
            mısır = Convert.ToInt32(textBox2.Text);
            su = Convert.ToInt32(textBox3.Text);
            kola = Convert.ToInt32(textBox4.Text);
            if (
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text)
               )
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            if (
                bilet < 0 ||
                mısır < 0 ||
                su < 0 ||
                kola < 0
               )
            {
                MessageBox.Show("Lütfen negatif değer girmeyin.");
                return;
            }

            Ürünler.Items.Add("Bilet: " + bilet.ToString() + " Adet");
            Ürünler.Items.Add("Mısır: " + mısır.ToString() + " Adet");
            Ürünler.Items.Add("Su: " + su.ToString() + " Adet");
            Ürünler.Items.Add("Kola: " + kola.ToString() + " Adet");
            Ürünler.Items.Add("===================================");
            Ürünler.Items.Add("Toplam: " + (bilet * 50 + mısır * 15 + su * 5 + kola * 20).ToString() + " TL");
            Ürünler.Items.Add("===================================");
            Ürünler.ClearSelected();

            toplam = bilet * 50 + mısır * 15 + su * 5 + kola * 20;
            label11.Text = toplam.ToString() + " TL";

            kasa += toplam;
            label12.Text = kasa.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
            Ürünler.Items.Clear();
        }
    }
}
