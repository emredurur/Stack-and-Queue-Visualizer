
namespace Veri_Yapilari_Final_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button3 = new Button();
            listBox3 = new ListBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            listBox4 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Arial Black", 9F);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(423, 45);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 0;
            button1.Text = "İşlemci Başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("Arial Black", 9F);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(423, 120);
            button2.Name = "button2";
            button2.Size = new Size(141, 49);
            button2.TabIndex = 1;
            button2.Text = "İşlemci Durdur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 77);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 64);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(14, 52);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 4;
            label1.Text = "Proses Kuyruğu";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(179, 230);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(92, 208);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(323, 230);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(92, 208);
            listBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 210);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 8;
            label2.Text = "Proses 3";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 210);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 9;
            label3.Text = "Proses 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 210);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 10;
            label4.Text = "Proses 1";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(695, 73);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 21);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Proses 1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(816, 73);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 21);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Proses 2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(944, 73);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 21);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "Proses 3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(695, 114);
            button3.Name = "button3";
            button3.Size = new Size(332, 27);
            button3.TabIndex = 17;
            button3.Text = "Bitirilen Prosesleri Görüntüle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 17;
            listBox3.Location = new Point(695, 147);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(235, 293);
            listBox3.TabIndex = 18;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(154, 555);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 19;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(311, 555);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(104, 45);
            trackBar2.TabIndex = 20;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(476, 555);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(104, 45);
            trackBar3.TabIndex = 21;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(633, 555);
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(104, 45);
            trackBar4.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 521);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 23;
            label5.Text = "İşlemci";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(654, 521);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 24;
            label6.Text = "Proses 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 521);
            label7.Name = "label7";
            label7.Size = new Size(64, 17);
            label7.TabIndex = 24;
            label7.Text = "Proses 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(500, 521);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 25;
            label8.Text = "Proses 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 482);
            label9.Name = "label9";
            label9.Size = new Size(298, 17);
            label9.TabIndex = 26;
            label9.Text = "Hız Ayarları (1 saniyede yapılan işlem sayısı)";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 17;
            listBox4.Location = new Point(44, 232);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(92, 208);
            listBox4.TabIndex = 27;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 612);
            Controls.Add(listBox4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(trackBar4);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(listBox3);
            Controls.Add(button3);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button3;
        private ListBox listBox3;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox listBox4;
        private System.Windows.Forms.Timer timer1;
    }
}
