namespace WindowsFormsApp1
{
    partial class Form1
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
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pokaziGesloCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // prijavaBtn
            // 
            this.prijavaBtn.Location = new System.Drawing.Point(33, 184);
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.Size = new System.Drawing.Size(100, 23);
            this.prijavaBtn.TabIndex = 0;
            this.prijavaBtn.Text = "Prijava";
            this.prijavaBtn.UseVisualStyleBackColor = true;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(156, 50);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(156, 93);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uporabniško ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geslo:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(156, 184);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pokaziGesloCheckBox
            // 
            this.pokaziGesloCheckBox.AutoSize = true;
            this.pokaziGesloCheckBox.Location = new System.Drawing.Point(262, 96);
            this.pokaziGesloCheckBox.Name = "pokaziGesloCheckBox";
            this.pokaziGesloCheckBox.Size = new System.Drawing.Size(86, 17);
            this.pokaziGesloCheckBox.TabIndex = 6;
            this.pokaziGesloCheckBox.Text = "Pokaži geslo";
            this.pokaziGesloCheckBox.UseVisualStyleBackColor = true;
            this.pokaziGesloCheckBox.CheckedChanged += new System.EventHandler(this.pokaziGesloCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 262);
            this.Controls.Add(this.pokaziGesloCheckBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.prijavaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavaBtn;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox pokaziGesloCheckBox;
    }
}

