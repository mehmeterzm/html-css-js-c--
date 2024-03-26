namespace çalışma3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TxtOyuncu = new TextBox();
            txtIrk = new TextBox();
            txtBrans = new TextBox();
            txtSilah = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            lblDusmanCanı = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtOyuncu
            // 
            TxtOyuncu.Location = new Point(261, 104);
            TxtOyuncu.Name = "TxtOyuncu";
            TxtOyuncu.Size = new Size(125, 27);
            TxtOyuncu.TabIndex = 0;
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(261, 159);
            txtIrk.Name = "txtIrk";
            txtIrk.Size = new Size(125, 27);
            txtIrk.TabIndex = 1;
            // 
            // txtBrans
            // 
            txtBrans.Location = new Point(261, 222);
            txtBrans.Name = "txtBrans";
            txtBrans.Size = new Size(125, 27);
            txtBrans.TabIndex = 2;
            // 
            // txtSilah
            // 
            txtSilah.Location = new Point(261, 274);
            txtSilah.Name = "txtSilah";
            txtSilah.Size = new Size(125, 27);
            txtSilah.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 111);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 4;
            label1.Text = "Oyuncu İsmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 166);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 5;
            label2.Text = "Irk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 229);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 6;
            label3.Text = "brans:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 281);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "silah:";
            // 
            // button1
            // 
            button1.Location = new Point(440, 109);
            button1.Name = "button1";
            button1.Size = new Size(139, 55);
            button1.TabIndex = 8;
            button1.Text = "seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDusmanCanı
            // 
            lblDusmanCanı.BackColor = Color.Maroon;
            lblDusmanCanı.Location = new Point(697, 126);
            lblDusmanCanı.Name = "lblDusmanCanı";
            lblDusmanCanı.Size = new Size(300, 29);
            lblDusmanCanı.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(697, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(440, 198);
            button2.Name = "button2";
            button2.Size = new Size(139, 55);
            button2.TabIndex = 11;
            button2.Text = "saldır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(lblDusmanCanı);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSilah);
            Controls.Add(txtBrans);
            Controls.Add(txtIrk);
            Controls.Add(TxtOyuncu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtOyuncu;
        private TextBox txtIrk;
        private TextBox txtBrans;
        private TextBox txtSilah;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label lblDusmanCanı;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
