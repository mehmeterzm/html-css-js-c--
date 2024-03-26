namespace constructor
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
            btnDogum = new Button();
            txtBebek = new TextBox();
            SuspendLayout();
            // 
            // btnDogum
            // 
            btnDogum.Location = new Point(505, 101);
            btnDogum.Name = "btnDogum";
            btnDogum.Size = new Size(124, 45);
            btnDogum.TabIndex = 0;
            btnDogum.Text = "doğum";
            btnDogum.UseVisualStyleBackColor = true;
            btnDogum.Click += btnDogum_Click;
            // 
            // txtBebek
            // 
            txtBebek.Location = new Point(515, 203);
            txtBebek.Name = "txtBebek";
            txtBebek.Size = new Size(125, 27);
            txtBebek.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBebek);
            Controls.Add(btnDogum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDogum;
        private TextBox txtBebek;
    }
}
