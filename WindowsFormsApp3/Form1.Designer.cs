namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.harcos_letrehozas = new System.Windows.Forms.Button();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepesseg_letrehozas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kepessegLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.modositButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.harcos_letrehozas);
            this.groupBox1.Controls.Add(this.harcosNeveTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcos létrehozása";
            // 
            // harcos_letrehozas
            // 
            this.harcos_letrehozas.Location = new System.Drawing.Point(150, 22);
            this.harcos_letrehozas.Name = "harcos_letrehozas";
            this.harcos_letrehozas.Size = new System.Drawing.Size(75, 23);
            this.harcos_letrehozas.TabIndex = 2;
            this.harcos_letrehozas.Text = "Létrehozás";
            this.harcos_letrehozas.UseVisualStyleBackColor = true;
            this.harcos_letrehozas.Click += new System.EventHandler(this.harcos_letrehozas_Click);
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(44, 24);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(100, 20);
            this.harcosNeveTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kepesseg_letrehozas);
            this.groupBox2.Controls.Add(this.leirasTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kepessegNeveTextBox);
            this.groupBox2.Controls.Add(this.hasznaloComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Képesség hozzáadása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Használó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Név:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hasznaloComboBox.Location = new System.Drawing.Point(66, 26);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(121, 21);
            this.hasznaloComboBox.TabIndex = 2;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(66, 52);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(121, 20);
            this.kepessegNeveTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leírás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(210, 33);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(219, 50);
            this.leirasTextBox.TabIndex = 5;
            // 
            // kepesseg_letrehozas
            // 
            this.kepesseg_letrehozas.Location = new System.Drawing.Point(10, 74);
            this.kepesseg_letrehozas.Name = "kepesseg_letrehozas";
            this.kepesseg_letrehozas.Size = new System.Drawing.Size(75, 23);
            this.kepesseg_letrehozas.TabIndex = 6;
            this.kepesseg_letrehozas.Text = "Hozzáad";
            this.kepesseg_letrehozas.UseVisualStyleBackColor = true;
            this.kepesseg_letrehozas.Click += new System.EventHandler(this.kepesseg_letrehozas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Harcosok:";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(15, 210);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 199);
            this.harcosokListBox.TabIndex = 3;
            this.harcosokListBox.SelectedIndexChanged += new System.EventHandler(this.harcosokListBox_SelectedIndexChanged);
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(150, 210);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(120, 199);
            this.kepessegekListBox.TabIndex = 5;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegekListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Képességei:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Képességek leírása:";
            // 
            // kepessegLeirasaTextBox
            // 
            this.kepessegLeirasaTextBox.Location = new System.Drawing.Point(295, 210);
            this.kepessegLeirasaTextBox.Multiline = true;
            this.kepessegLeirasaTextBox.Name = "kepessegLeirasaTextBox";
            this.kepessegLeirasaTextBox.Size = new System.Drawing.Size(146, 101);
            this.kepessegLeirasaTextBox.TabIndex = 7;
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(365, 318);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(75, 23);
            this.modositButton.TabIndex = 8;
            this.modositButton.Text = "Módosít";
            this.modositButton.UseVisualStyleBackColor = true;
            this.modositButton.Click += new System.EventHandler(this.modositButton_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(150, 416);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(75, 23);
            this.torlesButton.TabIndex = 9;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 456);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.modositButton);
            this.Controls.Add(this.kepessegLeirasaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button harcos_letrehozas;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kepesseg_letrehozas;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kepessegLeirasaTextBox;
        private System.Windows.Forms.Button modositButton;
        private System.Windows.Forms.Button torlesButton;
    }
}

