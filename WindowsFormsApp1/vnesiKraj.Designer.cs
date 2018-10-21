namespace WindowsFormsApp1
{
    partial class vnesiKraj
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
            this.imeKrajaTextBox = new System.Windows.Forms.TextBox();
            this.vnesiButton = new System.Windows.Forms.Button();
            this.nazajButton = new System.Windows.Forms.Button();
            this.izbrisKrajaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime kraja:";
            // 
            // imeKrajaTextBox
            // 
            this.imeKrajaTextBox.Location = new System.Drawing.Point(129, 39);
            this.imeKrajaTextBox.Name = "imeKrajaTextBox";
            this.imeKrajaTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeKrajaTextBox.TabIndex = 1;
            // 
            // vnesiButton
            // 
            this.vnesiButton.Location = new System.Drawing.Point(154, 184);
            this.vnesiButton.Name = "vnesiButton";
            this.vnesiButton.Size = new System.Drawing.Size(75, 23);
            this.vnesiButton.TabIndex = 2;
            this.vnesiButton.Text = "Vnesi";
            this.vnesiButton.UseVisualStyleBackColor = true;
            this.vnesiButton.Click += new System.EventHandler(this.vnesiButton_Click);
            // 
            // nazajButton
            // 
            this.nazajButton.Location = new System.Drawing.Point(12, 184);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(75, 23);
            this.nazajButton.TabIndex = 3;
            this.nazajButton.Text = "Nazaj";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.Click += new System.EventHandler(this.nazajButton_Click);
            // 
            // izbrisKrajaButton
            // 
            this.izbrisKrajaButton.Location = new System.Drawing.Point(154, 213);
            this.izbrisKrajaButton.Name = "izbrisKrajaButton";
            this.izbrisKrajaButton.Size = new System.Drawing.Size(75, 23);
            this.izbrisKrajaButton.TabIndex = 4;
            this.izbrisKrajaButton.Text = "Izbrisi kraj";
            this.izbrisKrajaButton.UseVisualStyleBackColor = true;
            this.izbrisKrajaButton.Visible = false;
            this.izbrisKrajaButton.Click += new System.EventHandler(this.izbrisKrajaButton_Click);
            // 
            // vnesiKraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 240);
            this.Controls.Add(this.izbrisKrajaButton);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.vnesiButton);
            this.Controls.Add(this.imeKrajaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "vnesiKraj";
            this.Text = "vnesiKraj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vnesiKraj_FormClosing);
            this.Load += new System.EventHandler(this.vnesiKraj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imeKrajaTextBox;
        private System.Windows.Forms.Button vnesiButton;
        private System.Windows.Forms.Button nazajButton;
        private System.Windows.Forms.Button izbrisKrajaButton;
    }
}