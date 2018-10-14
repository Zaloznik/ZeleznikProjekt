namespace WindowsFormsApp1
{
    partial class ustvariPot
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zacetekTextBox = new System.Windows.Forms.TextBox();
            this.konecTextBox = new System.Windows.Forms.TextBox();
            this.casTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.strosekTextBox = new System.Windows.Forms.TextBox();
            this.ustvariPotBtn = new System.Windows.Forms.Button();
            this.nazajBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Začetek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Čas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Strošek:";
            // 
            // zacetekTextBox
            // 
            this.zacetekTextBox.Location = new System.Drawing.Point(158, 32);
            this.zacetekTextBox.Name = "zacetekTextBox";
            this.zacetekTextBox.Size = new System.Drawing.Size(100, 20);
            this.zacetekTextBox.TabIndex = 5;
            // 
            // konecTextBox
            // 
            this.konecTextBox.Location = new System.Drawing.Point(158, 64);
            this.konecTextBox.Name = "konecTextBox";
            this.konecTextBox.Size = new System.Drawing.Size(100, 20);
            this.konecTextBox.TabIndex = 6;
            // 
            // casTextBox
            // 
            this.casTextBox.Location = new System.Drawing.Point(158, 105);
            this.casTextBox.Name = "casTextBox";
            this.casTextBox.Size = new System.Drawing.Size(100, 20);
            this.casTextBox.TabIndex = 7;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(158, 145);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(100, 20);
            this.opisTextBox.TabIndex = 8;
            // 
            // strosekTextBox
            // 
            this.strosekTextBox.Location = new System.Drawing.Point(158, 182);
            this.strosekTextBox.Name = "strosekTextBox";
            this.strosekTextBox.Size = new System.Drawing.Size(100, 20);
            this.strosekTextBox.TabIndex = 9;
            // 
            // ustvariPotBtn
            // 
            this.ustvariPotBtn.Location = new System.Drawing.Point(216, 256);
            this.ustvariPotBtn.Name = "ustvariPotBtn";
            this.ustvariPotBtn.Size = new System.Drawing.Size(75, 23);
            this.ustvariPotBtn.TabIndex = 10;
            this.ustvariPotBtn.Text = "Ustvari pot";
            this.ustvariPotBtn.UseVisualStyleBackColor = true;
            this.ustvariPotBtn.Click += new System.EventHandler(this.ustvariPotBtn_Click);
            // 
            // nazajBtn
            // 
            this.nazajBtn.Location = new System.Drawing.Point(35, 256);
            this.nazajBtn.Name = "nazajBtn";
            this.nazajBtn.Size = new System.Drawing.Size(75, 23);
            this.nazajBtn.TabIndex = 11;
            this.nazajBtn.Text = "Nazaj";
            this.nazajBtn.UseVisualStyleBackColor = true;
            this.nazajBtn.Click += new System.EventHandler(this.nazajBtn_Click);
            // 
            // ustvariPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 306);
            this.Controls.Add(this.nazajBtn);
            this.Controls.Add(this.ustvariPotBtn);
            this.Controls.Add(this.strosekTextBox);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.casTextBox);
            this.Controls.Add(this.konecTextBox);
            this.Controls.Add(this.zacetekTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ustvariPot";
            this.Text = "ustvariPot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ustvariPot_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zacetekTextBox;
        private System.Windows.Forms.TextBox konecTextBox;
        private System.Windows.Forms.TextBox casTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox strosekTextBox;
        private System.Windows.Forms.Button ustvariPotBtn;
        private System.Windows.Forms.Button nazajBtn;
    }
}