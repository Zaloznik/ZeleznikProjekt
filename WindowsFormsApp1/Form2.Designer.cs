namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.izbiraComboBox = new System.Windows.Forms.ComboBox();
            this.ustvariPotBtn = new System.Windows.Forms.Button();
            this.izbrisiPotButton = new System.Windows.Forms.Button();
            this.odjavaButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.izbira2ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijavljeni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priimek:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(599, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(599, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mesto začetka:";
            // 
            // izbiraComboBox
            // 
            this.izbiraComboBox.FormattingEnabled = true;
            this.izbiraComboBox.Location = new System.Drawing.Point(143, 40);
            this.izbiraComboBox.Name = "izbiraComboBox";
            this.izbiraComboBox.Size = new System.Drawing.Size(121, 21);
            this.izbiraComboBox.TabIndex = 6;
            this.izbiraComboBox.SelectedIndexChanged += new System.EventHandler(this.izbiraComboBox_SelectedIndexChanged);
            // 
            // ustvariPotBtn
            // 
            this.ustvariPotBtn.Location = new System.Drawing.Point(599, 195);
            this.ustvariPotBtn.Name = "ustvariPotBtn";
            this.ustvariPotBtn.Size = new System.Drawing.Size(75, 23);
            this.ustvariPotBtn.TabIndex = 7;
            this.ustvariPotBtn.Text = "Ustvari pot";
            this.ustvariPotBtn.UseVisualStyleBackColor = true;
            this.ustvariPotBtn.Click += new System.EventHandler(this.ustvariPotBtn_Click);
            // 
            // izbrisiPotButton
            // 
            this.izbrisiPotButton.Location = new System.Drawing.Point(496, 195);
            this.izbrisiPotButton.Name = "izbrisiPotButton";
            this.izbrisiPotButton.Size = new System.Drawing.Size(75, 23);
            this.izbrisiPotButton.TabIndex = 8;
            this.izbrisiPotButton.Text = "Izbrisi pot";
            this.izbrisiPotButton.UseVisualStyleBackColor = true;
            this.izbrisiPotButton.Visible = false;
            // 
            // odjavaButton
            // 
            this.odjavaButton.Location = new System.Drawing.Point(1, 218);
            this.odjavaButton.Name = "odjavaButton";
            this.odjavaButton.Size = new System.Drawing.Size(75, 23);
            this.odjavaButton.TabIndex = 9;
            this.odjavaButton.Text = "Odjava";
            this.odjavaButton.UseVisualStyleBackColor = true;
            this.odjavaButton.Click += new System.EventHandler(this.odjavaButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mesto zaklucka:";
            // 
            // izbira2ComboBox
            // 
            this.izbira2ComboBox.FormattingEnabled = true;
            this.izbira2ComboBox.Location = new System.Drawing.Point(143, 88);
            this.izbira2ComboBox.Name = "izbira2ComboBox";
            this.izbira2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.izbira2ComboBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 242);
            this.Controls.Add(this.izbira2ComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odjavaButton);
            this.Controls.Add(this.izbrisiPotButton);
            this.Controls.Add(this.ustvariPotBtn);
            this.Controls.Add(this.izbiraComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox izbiraComboBox;
        private System.Windows.Forms.Button ustvariPotBtn;
        private System.Windows.Forms.Button izbrisiPotButton;
        private System.Windows.Forms.Button odjavaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox izbira2ComboBox;
    }
}