namespace WindowsFormsApp1
{
    partial class izbrisKraja
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
            this.izbrisKrajaComboBox = new System.Windows.Forms.ComboBox();
            this.izbrisiKrajBtn = new System.Windows.Forms.Button();
            this.nazajBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izberi kraj za izbris:";
            // 
            // izbrisKrajaComboBox
            // 
            this.izbrisKrajaComboBox.FormattingEnabled = true;
            this.izbrisKrajaComboBox.Location = new System.Drawing.Point(117, 31);
            this.izbrisKrajaComboBox.Name = "izbrisKrajaComboBox";
            this.izbrisKrajaComboBox.Size = new System.Drawing.Size(121, 21);
            this.izbrisKrajaComboBox.TabIndex = 1;
            // 
            // izbrisiKrajBtn
            // 
            this.izbrisiKrajBtn.Location = new System.Drawing.Point(163, 181);
            this.izbrisiKrajBtn.Name = "izbrisiKrajBtn";
            this.izbrisiKrajBtn.Size = new System.Drawing.Size(75, 23);
            this.izbrisiKrajBtn.TabIndex = 2;
            this.izbrisiKrajBtn.Text = "Izbrisi";
            this.izbrisiKrajBtn.UseVisualStyleBackColor = true;
            this.izbrisiKrajBtn.Click += new System.EventHandler(this.izbrisiKrajBtn_Click);
            // 
            // nazajBtn
            // 
            this.nazajBtn.Location = new System.Drawing.Point(15, 181);
            this.nazajBtn.Name = "nazajBtn";
            this.nazajBtn.Size = new System.Drawing.Size(75, 23);
            this.nazajBtn.TabIndex = 3;
            this.nazajBtn.Text = "Nazaj";
            this.nazajBtn.UseVisualStyleBackColor = true;
            this.nazajBtn.Click += new System.EventHandler(this.nazajBtn_Click);
            // 
            // izbrisKraja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 216);
            this.Controls.Add(this.nazajBtn);
            this.Controls.Add(this.izbrisiKrajBtn);
            this.Controls.Add(this.izbrisKrajaComboBox);
            this.Controls.Add(this.label1);
            this.Name = "izbrisKraja";
            this.Text = "izbrisKraja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.izbrisKraja_FormClosing);
            this.Load += new System.EventHandler(this.izbrisKraja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox izbrisKrajaComboBox;
        private System.Windows.Forms.Button izbrisiKrajBtn;
        private System.Windows.Forms.Button nazajBtn;
    }
}