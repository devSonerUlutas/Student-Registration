namespace OgrenciKayit
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
            this.NumbersComboB = new System.Windows.Forms.ComboBox();
            this.ShowAdressLbl = new System.Windows.Forms.Label();
            this.ShowNameLbl = new System.Windows.Forms.Label();
            this.ShowNumbersLbl = new System.Windows.Forms.Label();
            this.AdressLbl = new System.Windows.Forms.Label();
            this.NameSurnameTxtB = new System.Windows.Forms.TextBox();
            this.NameSurnameLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NumberTxtB = new System.Windows.Forms.TextBox();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.AdressTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumbersComboB
            // 
            this.NumbersComboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumbersComboB.FormattingEnabled = true;
            this.NumbersComboB.Location = new System.Drawing.Point(824, 57);
            this.NumbersComboB.Name = "NumbersComboB";
            this.NumbersComboB.Size = new System.Drawing.Size(147, 21);
            this.NumbersComboB.TabIndex = 21;
            // 
            // ShowAdressLbl
            // 
            this.ShowAdressLbl.AutoSize = true;
            this.ShowAdressLbl.BackColor = System.Drawing.Color.LightCoral;
            this.ShowAdressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowAdressLbl.Location = new System.Drawing.Point(788, 197);
            this.ShowAdressLbl.Name = "ShowAdressLbl";
            this.ShowAdressLbl.Size = new System.Drawing.Size(13, 20);
            this.ShowAdressLbl.TabIndex = 20;
            this.ShowAdressLbl.Text = " ";
            // 
            // ShowNameLbl
            // 
            this.ShowNameLbl.AutoSize = true;
            this.ShowNameLbl.BackColor = System.Drawing.Color.Salmon;
            this.ShowNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowNameLbl.Location = new System.Drawing.Point(788, 136);
            this.ShowNameLbl.Name = "ShowNameLbl";
            this.ShowNameLbl.Size = new System.Drawing.Size(13, 20);
            this.ShowNameLbl.TabIndex = 19;
            this.ShowNameLbl.Text = " ";
            // 
            // ShowNumbersLbl
            // 
            this.ShowNumbersLbl.AutoSize = true;
            this.ShowNumbersLbl.BackColor = System.Drawing.Color.Red;
            this.ShowNumbersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowNumbersLbl.Location = new System.Drawing.Point(624, 58);
            this.ShowNumbersLbl.Name = "ShowNumbersLbl";
            this.ShowNumbersLbl.Size = new System.Drawing.Size(177, 20);
            this.ShowNumbersLbl.TabIndex = 18;
            this.ShowNumbersLbl.Text = "Öğrencilerin Numaraları:";
            // 
            // AdressLbl
            // 
            this.AdressLbl.AutoSize = true;
            this.AdressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdressLbl.Location = new System.Drawing.Point(42, 184);
            this.AdressLbl.Name = "AdressLbl";
            this.AdressLbl.Size = new System.Drawing.Size(75, 26);
            this.AdressLbl.TabIndex = 16;
            this.AdressLbl.Text = "Adres:";
            // 
            // NameSurnameTxtB
            // 
            this.NameSurnameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameSurnameTxtB.Location = new System.Drawing.Point(219, 115);
            this.NameSurnameTxtB.Name = "NameSurnameTxtB";
            this.NameSurnameTxtB.Size = new System.Drawing.Size(191, 32);
            this.NameSurnameTxtB.TabIndex = 15;
            // 
            // NameSurnameLbl
            // 
            this.NameSurnameLbl.AutoSize = true;
            this.NameSurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameSurnameLbl.Location = new System.Drawing.Point(42, 118);
            this.NameSurnameLbl.Name = "NameSurnameLbl";
            this.NameSurnameLbl.Size = new System.Drawing.Size(143, 26);
            this.NameSurnameLbl.TabIndex = 14;
            this.NameSurnameLbl.Text = "İsim Soyisim:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBtn.Location = new System.Drawing.Point(114, 266);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(124, 44);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "KAYDET";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NumberTxtB
            // 
            this.NumberTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberTxtB.Location = new System.Drawing.Point(219, 58);
            this.NumberTxtB.Name = "NumberTxtB";
            this.NumberTxtB.Size = new System.Drawing.Size(191, 32);
            this.NumberTxtB.TabIndex = 12;
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumberLbl.Location = new System.Drawing.Point(42, 61);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(128, 26);
            this.NumberLbl.TabIndex = 11;
            this.NumberLbl.Text = "Öğrenci No:";
            // 
            // AdressTxtB
            // 
            this.AdressTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdressTxtB.Location = new System.Drawing.Point(218, 181);
            this.AdressTxtB.Name = "AdressTxtB";
            this.AdressTxtB.Size = new System.Drawing.Size(191, 32);
            this.AdressTxtB.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1115, 613);
            this.Controls.Add(this.AdressTxtB);
            this.Controls.Add(this.NumbersComboB);
            this.Controls.Add(this.ShowAdressLbl);
            this.Controls.Add(this.ShowNameLbl);
            this.Controls.Add(this.ShowNumbersLbl);
            this.Controls.Add(this.AdressLbl);
            this.Controls.Add(this.NameSurnameTxtB);
            this.Controls.Add(this.NameSurnameLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NumberTxtB);
            this.Controls.Add(this.NumberLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumbersComboB;
        private System.Windows.Forms.Label ShowAdressLbl;
        private System.Windows.Forms.Label ShowNameLbl;
        private System.Windows.Forms.Label ShowNumbersLbl;
        private System.Windows.Forms.Label AdressLbl;
        private System.Windows.Forms.TextBox NameSurnameTxtB;
        private System.Windows.Forms.Label NameSurnameLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox NumberTxtB;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.TextBox AdressTxtB;
    }
}

