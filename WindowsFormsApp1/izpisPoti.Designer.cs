namespace WindowsFormsApp1
{
    partial class izpisPoti
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
            this.nazajBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.izpisZacetekTextBox = new System.Windows.Forms.TextBox();
            this.izpisKonecTextBox = new System.Windows.Forms.TextBox();
            this.izpisCasTextBox = new System.Windows.Forms.TextBox();
            this.izpisOpisTextBox = new System.Windows.Forms.TextBox();
            this.izpisUporabnikTextBox = new System.Windows.Forms.TextBox();
            this.izpisZnamkaTextBox = new System.Windows.Forms.TextBox();
            this.izpisModelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nazajBtn
            // 
            this.nazajBtn.Location = new System.Drawing.Point(12, 275);
            this.nazajBtn.Name = "nazajBtn";
            this.nazajBtn.Size = new System.Drawing.Size(75, 23);
            this.nazajBtn.TabIndex = 0;
            this.nazajBtn.Text = "Nazaj";
            this.nazajBtn.UseVisualStyleBackColor = true;
            this.nazajBtn.Click += new System.EventHandler(this.nazajBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zacetek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Čas potovanja (min):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Uporabnik:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Znamka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Model:";
            // 
            // izpisZacetekTextBox
            // 
            this.izpisZacetekTextBox.Location = new System.Drawing.Point(198, 71);
            this.izpisZacetekTextBox.Name = "izpisZacetekTextBox";
            this.izpisZacetekTextBox.ReadOnly = true;
            this.izpisZacetekTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisZacetekTextBox.TabIndex = 9;
            // 
            // izpisKonecTextBox
            // 
            this.izpisKonecTextBox.Location = new System.Drawing.Point(198, 119);
            this.izpisKonecTextBox.Name = "izpisKonecTextBox";
            this.izpisKonecTextBox.ReadOnly = true;
            this.izpisKonecTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisKonecTextBox.TabIndex = 10;
            // 
            // izpisCasTextBox
            // 
            this.izpisCasTextBox.Location = new System.Drawing.Point(198, 164);
            this.izpisCasTextBox.Name = "izpisCasTextBox";
            this.izpisCasTextBox.ReadOnly = true;
            this.izpisCasTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisCasTextBox.TabIndex = 11;
            // 
            // izpisOpisTextBox
            // 
            this.izpisOpisTextBox.Location = new System.Drawing.Point(198, 221);
            this.izpisOpisTextBox.Name = "izpisOpisTextBox";
            this.izpisOpisTextBox.ReadOnly = true;
            this.izpisOpisTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisOpisTextBox.TabIndex = 12;
            // 
            // izpisUporabnikTextBox
            // 
            this.izpisUporabnikTextBox.Location = new System.Drawing.Point(503, 71);
            this.izpisUporabnikTextBox.Name = "izpisUporabnikTextBox";
            this.izpisUporabnikTextBox.ReadOnly = true;
            this.izpisUporabnikTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisUporabnikTextBox.TabIndex = 14;
            // 
            // izpisZnamkaTextBox
            // 
            this.izpisZnamkaTextBox.Location = new System.Drawing.Point(503, 119);
            this.izpisZnamkaTextBox.Name = "izpisZnamkaTextBox";
            this.izpisZnamkaTextBox.ReadOnly = true;
            this.izpisZnamkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisZnamkaTextBox.TabIndex = 15;
            // 
            // izpisModelTextBox
            // 
            this.izpisModelTextBox.Location = new System.Drawing.Point(503, 164);
            this.izpisModelTextBox.Name = "izpisModelTextBox";
            this.izpisModelTextBox.ReadOnly = true;
            this.izpisModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.izpisModelTextBox.TabIndex = 16;
            // 
            // izpisPoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 312);
            this.Controls.Add(this.izpisModelTextBox);
            this.Controls.Add(this.izpisZnamkaTextBox);
            this.Controls.Add(this.izpisUporabnikTextBox);
            this.Controls.Add(this.izpisOpisTextBox);
            this.Controls.Add(this.izpisCasTextBox);
            this.Controls.Add(this.izpisKonecTextBox);
            this.Controls.Add(this.izpisZacetekTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazajBtn);
            this.Name = "izpisPoti";
            this.Text = "izpisPoti";
            this.Load += new System.EventHandler(this.izpisPoti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazajBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox izpisZacetekTextBox;
        private System.Windows.Forms.TextBox izpisKonecTextBox;
        private System.Windows.Forms.TextBox izpisCasTextBox;
        private System.Windows.Forms.TextBox izpisOpisTextBox;
        private System.Windows.Forms.TextBox izpisUporabnikTextBox;
        private System.Windows.Forms.TextBox izpisZnamkaTextBox;
        private System.Windows.Forms.TextBox izpisModelTextBox;
    }
}