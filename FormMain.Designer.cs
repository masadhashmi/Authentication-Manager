namespace MaxAuthenticationManager
{
    partial class FormMain
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
            this.textBox_Mac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CompanyNameFor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_ClientGen_Date = new System.Windows.Forms.DateTimePicker();
            this.checkBox_LifeTime = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxEncryptvalue = new System.Windows.Forms.TextBox();
            this.textBoxEncryptResult = new System.Windows.Forms.TextBox();
            this.buttonDes3Encrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDesKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabpagedecryption = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDecryptButton = new System.Windows.Forms.Button();
            this.textBoxDecryptResult = new System.Windows.Forms.TextBox();
            this.textBoxDecryptkey = new System.Windows.Forms.TextBox();
            this.textBoxDecryptValue = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.labelEncryptcount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabpagedecryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Mac
            // 
            this.textBox_Mac.Location = new System.Drawing.Point(63, 10);
            this.textBox_Mac.Name = "textBox_Mac";
            this.textBox_Mac.Size = new System.Drawing.Size(199, 20);
            this.textBox_Mac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exp Date:";
            // 
            // textBox_CompanyNameFor
            // 
            this.textBox_CompanyNameFor.Location = new System.Drawing.Point(63, 111);
            this.textBox_CompanyNameFor.Name = "textBox_CompanyNameFor";
            this.textBox_CompanyNameFor.Size = new System.Drawing.Size(280, 20);
            this.textBox_CompanyNameFor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lic For:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate Signed Signature File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 64);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MAXxEMV Authentication Manger";
            // 
            // dateTimePickerExpiryDate
            // 
            this.dateTimePickerExpiryDate.Location = new System.Drawing.Point(63, 61);
            this.dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            this.dateTimePickerExpiryDate.Size = new System.Drawing.Size(280, 20);
            this.dateTimePickerExpiryDate.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gen Date:";
            // 
            // dateTimePicker_ClientGen_Date
            // 
            this.dateTimePicker_ClientGen_Date.Location = new System.Drawing.Point(63, 36);
            this.dateTimePicker_ClientGen_Date.Name = "dateTimePicker_ClientGen_Date";
            this.dateTimePicker_ClientGen_Date.Size = new System.Drawing.Size(280, 20);
            this.dateTimePicker_ClientGen_Date.TabIndex = 5;
            // 
            // checkBox_LifeTime
            // 
            this.checkBox_LifeTime.AutoSize = true;
            this.checkBox_LifeTime.Location = new System.Drawing.Point(63, 88);
            this.checkBox_LifeTime.Name = "checkBox_LifeTime";
            this.checkBox_LifeTime.Size = new System.Drawing.Size(69, 17);
            this.checkBox_LifeTime.TabIndex = 6;
            this.checkBox_LifeTime.Text = "Life Time";
            this.checkBox_LifeTime.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Txt|*.txt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabpagedecryption);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 228);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBox_LifeTime);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePicker_ClientGen_Date);
            this.tabPage1.Controls.Add(this.textBox_Mac);
            this.tabPage1.Controls.Add(this.dateTimePickerExpiryDate);
            this.tabPage1.Controls.Add(this.textBox_CompanyNameFor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Licencing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelEncryptcount);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonDes3Encrypt);
            this.tabPage2.Controls.Add(this.textBoxEncryptResult);
            this.tabPage2.Controls.Add(this.textBoxDesKey);
            this.tabPage2.Controls.Add(this.textBoxEncryptvalue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxEncryptvalue
            // 
            this.textBoxEncryptvalue.Location = new System.Drawing.Point(57, 53);
            this.textBoxEncryptvalue.Name = "textBoxEncryptvalue";
            this.textBoxEncryptvalue.Size = new System.Drawing.Size(228, 20);
            this.textBoxEncryptvalue.TabIndex = 0;
            // 
            // textBoxEncryptResult
            // 
            this.textBoxEncryptResult.Location = new System.Drawing.Point(57, 80);
            this.textBoxEncryptResult.Name = "textBoxEncryptResult";
            this.textBoxEncryptResult.Size = new System.Drawing.Size(228, 20);
            this.textBoxEncryptResult.TabIndex = 1;
            // 
            // buttonDes3Encrypt
            // 
            this.buttonDes3Encrypt.Location = new System.Drawing.Point(57, 107);
            this.buttonDes3Encrypt.Name = "buttonDes3Encrypt";
            this.buttonDes3Encrypt.Size = new System.Drawing.Size(137, 23);
            this.buttonDes3Encrypt.TabIndex = 2;
            this.buttonDes3Encrypt.Text = "DES 3 Encrypt";
            this.buttonDes3Encrypt.UseVisualStyleBackColor = true;
            this.buttonDes3Encrypt.Click += new System.EventHandler(this.buttonDes3Encrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Result:";
            // 
            // textBoxDesKey
            // 
            this.textBoxDesKey.Location = new System.Drawing.Point(57, 27);
            this.textBoxDesKey.Name = "textBoxDesKey";
            this.textBoxDesKey.Size = new System.Drawing.Size(228, 20);
            this.textBoxDesKey.TabIndex = 0;
            this.textBoxDesKey.TextChanged += new System.EventHandler(this.textBoxDesKey_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Key:";
            // 
            // tabpagedecryption
            // 
            this.tabpagedecryption.Controls.Add(this.label_count);
            this.tabpagedecryption.Controls.Add(this.label9);
            this.tabpagedecryption.Controls.Add(this.label10);
            this.tabpagedecryption.Controls.Add(this.label11);
            this.tabpagedecryption.Controls.Add(this.buttonDecryptButton);
            this.tabpagedecryption.Controls.Add(this.textBoxDecryptResult);
            this.tabpagedecryption.Controls.Add(this.textBoxDecryptkey);
            this.tabpagedecryption.Controls.Add(this.textBoxDecryptValue);
            this.tabpagedecryption.Location = new System.Drawing.Point(4, 22);
            this.tabpagedecryption.Name = "tabpagedecryption";
            this.tabpagedecryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagedecryption.Size = new System.Drawing.Size(391, 202);
            this.tabpagedecryption.TabIndex = 2;
            this.tabpagedecryption.Text = "Decryption";
            this.tabpagedecryption.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Result:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Key:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Value:";
            // 
            // buttonDecryptButton
            // 
            this.buttonDecryptButton.Location = new System.Drawing.Point(56, 98);
            this.buttonDecryptButton.Name = "buttonDecryptButton";
            this.buttonDecryptButton.Size = new System.Drawing.Size(137, 23);
            this.buttonDecryptButton.TabIndex = 8;
            this.buttonDecryptButton.Text = "DES 3 Encrypt";
            this.buttonDecryptButton.UseVisualStyleBackColor = true;
            this.buttonDecryptButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDecryptResult
            // 
            this.textBoxDecryptResult.Location = new System.Drawing.Point(56, 71);
            this.textBoxDecryptResult.Name = "textBoxDecryptResult";
            this.textBoxDecryptResult.Size = new System.Drawing.Size(228, 20);
            this.textBoxDecryptResult.TabIndex = 7;
            // 
            // textBoxDecryptkey
            // 
            this.textBoxDecryptkey.Location = new System.Drawing.Point(56, 18);
            this.textBoxDecryptkey.Name = "textBoxDecryptkey";
            this.textBoxDecryptkey.Size = new System.Drawing.Size(228, 20);
            this.textBoxDecryptkey.TabIndex = 5;
            this.textBoxDecryptkey.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxDecryptValue
            // 
            this.textBoxDecryptValue.Location = new System.Drawing.Point(56, 44);
            this.textBoxDecryptValue.Name = "textBoxDecryptValue";
            this.textBoxDecryptValue.Size = new System.Drawing.Size(228, 20);
            this.textBoxDecryptValue.TabIndex = 6;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(290, 21);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(13, 13);
            this.label_count.TabIndex = 12;
            this.label_count.Text = "0";
            // 
            // labelEncryptcount
            // 
            this.labelEncryptcount.AutoSize = true;
            this.labelEncryptcount.Location = new System.Drawing.Point(291, 30);
            this.labelEncryptcount.Name = "labelEncryptcount";
            this.labelEncryptcount.Size = new System.Drawing.Size(13, 13);
            this.labelEncryptcount.TabIndex = 5;
            this.labelEncryptcount.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 328);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabpagedecryption.ResumeLayout(false);
            this.tabpagedecryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Mac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CompanyNameFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ClientGen_Date;
        private System.Windows.Forms.CheckBox checkBox_LifeTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDes3Encrypt;
        private System.Windows.Forms.TextBox textBoxEncryptResult;
        private System.Windows.Forms.TextBox textBoxEncryptvalue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDesKey;
        private System.Windows.Forms.TabPage tabpagedecryption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDecryptButton;
        private System.Windows.Forms.TextBox textBoxDecryptResult;
        private System.Windows.Forms.TextBox textBoxDecryptkey;
        private System.Windows.Forms.TextBox textBoxDecryptValue;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label labelEncryptcount;
    }
}