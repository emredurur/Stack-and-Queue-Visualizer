using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;



namespace Veri_Yapilari_Final_Projesi
{


    public partial class Form1 : Form
    {
        Queue<string> kuyruklar = new Queue<string>();
      // Queue<string> kuyruklar2 = new Queue<string>();

        Queue<string> kuyruk1 = new Queue<string>();
        Queue<string> kuyruk2 = new Queue<string>();
        Queue<string> kuyruk3 = new Queue<string>();

        Stack<string> bitenProses = new Stack<string>();

        public void timer1_Tick(object sender, EventArgs e)  // timer iþlem baþlat/durdur butonlarý
        {

            // P1- 3    

            string n1 = kuyruk1.Peek();
            string n2 = kuyruk2.Peek();
            string n3 = kuyruk3.Peek();

            var list = new List<(string metin, int sayi)>
            {
                      (n1,int.Parse(n1.Split('-')[1])),
                      (n2,int.Parse(n2.Split("-")[1])),
                      (n3,int.Parse(n3.Split("-")[1])),
            };

            list = list.OrderBy(x => x.sayi).ToList();

            string enkucuk = list[0].metin;
            string ortanca = list[1].metin;
            string enbuyuk = list[2].metin;

            kuyruklar.Enqueue(enkucuk);
            kuyruklar.Enqueue(ortanca);
            kuyruklar.Enqueue(enbuyuk);

          //  kuyruklar2.Enqueue(enkucuk);
          //  kuyruklar2.Enqueue(ortanca);
           // kuyruklar2.Enqueue(enbuyuk);

            bitenProses.Push(enkucuk);
            bitenProses.Push(ortanca);
            bitenProses.Push(enbuyuk);

            kuyruk1.Dequeue();
            kuyruk2.Dequeue();
            kuyruk3.Dequeue();

            foreach (var item in kuyruklar)
            {
                textBox2.AppendText(item + " >>>");
                Thread.Sleep(500);
               
            }
            kuyruklar.Dequeue();
            kuyruklar.Dequeue();
            kuyruklar.Dequeue();

        }


        public void button2_Click(object sender, EventArgs e)  // iþlemci durdur
        {

            timer1.Stop();


        }
        public void button1_Click(object sender, EventArgs e)   // iþlemci baþlat
        {
            // iþlemci baþlat bastýðýmda true dönücek
            
            timer1.Start();
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proses_list1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;

            Random rnd = new Random();

            // P1- 3 

            kuyruk1.Clear();
            listBox4.Items.Clear();
            for (int i = 0; i < 70; i++)
            {
                int derece1 = rnd.Next(0, 6);
                int derece2 = rnd.Next(0, 6);
                int derece3 = rnd.Next(0, 6);

                kuyruk1.Enqueue("P1- " + derece1);
                kuyruk2.Enqueue("P2- " + derece2);
                kuyruk3.Enqueue("P3- " + derece3);
            }

            foreach (string item in kuyruk1)
            {
                listBox4.Items.Add(item); // ilk proses
            }
            foreach (string item in kuyruk2)
            {
                listBox1.Items.Add(item); // ikinci proses
            }
            foreach (string item in kuyruk3)
            {
                listBox2.Items.Add(item); // üçüncü proses
            }
            listBox4.BackColor = Color.Blue;
            listBox1.BackColor = Color.Violet;
            listBox2.BackColor = Color.Orange;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)  // bitirilen prosesler
        {
        }

        private void button3_Click(object sender, EventArgs e)  // bitirilen prosesleri göster butonu
        {
            listBox3.Items.Clear();

            foreach (var item in bitenProses)
            {
                string proses_adi = item.Split('-')[0];

                if (checkBox1.Checked && proses_adi == "P1")
                {
                    listBox3.Items.Add(item);
                }
                else if (checkBox2.Checked && proses_adi == "P2")
                {
                    listBox3.Items.Add(item);
                }
                else if (checkBox3.Checked && proses_adi == "P3")
                {
                    listBox3.Items.Add(item);
                }




            }





        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int hiz = trackBar1.Value;

            // hýz arttýkça interval azalýr (daha hýzlý iþlem)
            timer1.Interval = 1000 / hiz;
        }
    }
}
