namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gocUI = new System.Windows.Forms.TextBox();
            this.khoaUI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reUI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.caesarUI = new System.Windows.Forms.RadioButton();
            this.playfairUI = new System.Windows.Forms.RadioButton();
            this.vigenereUI = new System.Windows.Forms.RadioButton();
            this.File = new System.Windows.Forms.Button();
            this.DESUI = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dichmaUI = new System.Windows.Forms.RadioButton();
            this.mahoaUI = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DESAUI = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gocUI
            // 
            this.gocUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gocUI.Location = new System.Drawing.Point(82, 12);
            this.gocUI.Name = "gocUI";
            this.gocUI.Size = new System.Drawing.Size(198, 20);
            this.gocUI.TabIndex = 0;
            // 
            // khoaUI
            // 
            this.khoaUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khoaUI.Location = new System.Drawing.Point(82, 38);
            this.khoaUI.Name = "khoaUI";
            this.khoaUI.Size = new System.Drawing.Size(140, 20);
            this.khoaUI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Văn bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khoá";
            // 
            // reUI
            // 
            this.reUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reUI.Location = new System.Drawing.Point(82, 253);
            this.reUI.Multiline = true;
            this.reUI.Name = "reUI";
            this.reUI.Size = new System.Drawing.Size(198, 43);
            this.reUI.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 193);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(268, 54);
            this.button.TabIndex = 6;
            this.button.Text = "DỊCH";
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseClick);
            // 
            // caesarUI
            // 
            this.caesarUI.AutoSize = true;
            this.caesarUI.Checked = true;
            this.caesarUI.Location = new System.Drawing.Point(12, 19);
            this.caesarUI.Name = "caesarUI";
            this.caesarUI.Size = new System.Drawing.Size(58, 17);
            this.caesarUI.TabIndex = 9;
            this.caesarUI.TabStop = true;
            this.caesarUI.Text = "Caesar";
            this.caesarUI.UseVisualStyleBackColor = true;
            // 
            // playfairUI
            // 
            this.playfairUI.AutoSize = true;
            this.playfairUI.Location = new System.Drawing.Point(99, 19);
            this.playfairUI.Name = "playfairUI";
            this.playfairUI.Size = new System.Drawing.Size(65, 17);
            this.playfairUI.TabIndex = 10;
            this.playfairUI.TabStop = true;
            this.playfairUI.Text = "Play Fair";
            this.playfairUI.UseVisualStyleBackColor = true;
            // 
            // vigenereUI
            // 
            this.vigenereUI.AutoSize = true;
            this.vigenereUI.Location = new System.Drawing.Point(12, 44);
            this.vigenereUI.Name = "vigenereUI";
            this.vigenereUI.Size = new System.Drawing.Size(67, 17);
            this.vigenereUI.TabIndex = 11;
            this.vigenereUI.TabStop = true;
            this.vigenereUI.Text = "Vigenere";
            this.vigenereUI.UseVisualStyleBackColor = true;
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(228, 38);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(52, 20);
            this.File.TabIndex = 14;
            this.File.Text = "FILE";
            this.File.UseVisualStyleBackColor = true;
            this.File.MouseClick += new System.Windows.Forms.MouseEventHandler(this.File_MouseClick);
            // 
            // DESUI
            // 
            this.DESUI.AutoSize = true;
            this.DESUI.Location = new System.Drawing.Point(182, 19);
            this.DESUI.Name = "DESUI";
            this.DESUI.Size = new System.Drawing.Size(69, 17);
            this.DESUI.TabIndex = 15;
            this.DESUI.TabStop = true;
            this.DESUI.Text = "DES Hex";
            this.DESUI.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DESAUI);
            this.groupBox2.Controls.Add(this.DESUI);
            this.groupBox2.Controls.Add(this.playfairUI);
            this.groupBox2.Controls.Add(this.caesarUI);
            this.groupBox2.Controls.Add(this.vigenereUI);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 67);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các loại mã hóa";
            // 
            // dichmaUI
            // 
            this.dichmaUI.AutoSize = true;
            this.dichmaUI.Location = new System.Drawing.Point(182, 19);
            this.dichmaUI.Name = "dichmaUI";
            this.dichmaUI.Size = new System.Drawing.Size(64, 17);
            this.dichmaUI.TabIndex = 8;
            this.dichmaUI.TabStop = true;
            this.dichmaUI.Text = "Dịch mã";
            this.dichmaUI.UseVisualStyleBackColor = true;
            // 
            // mahoaUI
            // 
            this.mahoaUI.AutoSize = true;
            this.mahoaUI.Checked = true;
            this.mahoaUI.Location = new System.Drawing.Point(12, 19);
            this.mahoaUI.Name = "mahoaUI";
            this.mahoaUI.Size = new System.Drawing.Size(61, 17);
            this.mahoaUI.TabIndex = 7;
            this.mahoaUI.TabStop = true;
            this.mahoaUI.Text = "Mã hoá";
            this.mahoaUI.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mahoaUI);
            this.groupBox1.Controls.Add(this.dichmaUI);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // DESAUI
            // 
            this.DESAUI.AutoSize = true;
            this.DESAUI.Location = new System.Drawing.Point(182, 44);
            this.DESAUI.Name = "DESAUI";
            this.DESAUI.Size = new System.Drawing.Size(77, 17);
            this.DESAUI.TabIndex = 16;
            this.DESAUI.TabStop = true;
            this.DESAUI.Text = "DES ASCII";
            this.DESAUI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 308);
            this.Controls.Add(this.File);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.khoaUI);
            this.Controls.Add(this.gocUI);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã Hoá";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gocUI;
        private System.Windows.Forms.TextBox khoaUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reUI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RadioButton caesarUI;
        private System.Windows.Forms.RadioButton playfairUI;
        private System.Windows.Forms.RadioButton vigenereUI;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.RadioButton DESUI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dichmaUI;
        private System.Windows.Forms.RadioButton mahoaUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DESAUI;
    }
}

