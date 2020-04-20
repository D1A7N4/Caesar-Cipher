namespace Caesar_Cipher
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
            this.BTN_Encrypt = new System.Windows.Forms.Button();
            this.TBX_Input = new System.Windows.Forms.TextBox();
            this.TBX_Output = new System.Windows.Forms.TextBox();
            this.BTN_Decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_CInput = new System.Windows.Forms.TextBox();
            this.TBX_CKey = new System.Windows.Forms.TextBox();
            this.BTN_CEncrypt = new System.Windows.Forms.Button();
            this.BTN_CDecrypt = new System.Windows.Forms.Button();
            this.TBX_COutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBX_CShift = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Encrypt
            // 
            this.BTN_Encrypt.Location = new System.Drawing.Point(19, 111);
            this.BTN_Encrypt.Name = "BTN_Encrypt";
            this.BTN_Encrypt.Size = new System.Drawing.Size(100, 23);
            this.BTN_Encrypt.TabIndex = 0;
            this.BTN_Encrypt.Text = "Encrypt";
            this.BTN_Encrypt.UseVisualStyleBackColor = true;
            this.BTN_Encrypt.Click += new System.EventHandler(this.BTN_Encrypt_Click);
            // 
            // TBX_Input
            // 
            this.TBX_Input.Location = new System.Drawing.Point(19, 85);
            this.TBX_Input.Name = "TBX_Input";
            this.TBX_Input.Size = new System.Drawing.Size(191, 20);
            this.TBX_Input.TabIndex = 1;
            this.TBX_Input.Text = "Input";
            // 
            // TBX_Output
            // 
            this.TBX_Output.Location = new System.Drawing.Point(19, 140);
            this.TBX_Output.Name = "TBX_Output";
            this.TBX_Output.Size = new System.Drawing.Size(228, 20);
            this.TBX_Output.TabIndex = 3;
            this.TBX_Output.Text = "Output";
            // 
            // BTN_Decrypt
            // 
            this.BTN_Decrypt.Location = new System.Drawing.Point(147, 111);
            this.BTN_Decrypt.Name = "BTN_Decrypt";
            this.BTN_Decrypt.Size = new System.Drawing.Size(100, 23);
            this.BTN_Decrypt.TabIndex = 2;
            this.BTN_Decrypt.Text = "Decrypt";
            this.BTN_Decrypt.UseVisualStyleBackColor = true;
            this.BTN_Decrypt.Click += new System.EventHandler(this.BTN_Decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caesar Cipher Encoding/Decoder";
            // 
            // TBX_Key
            // 
            this.TBX_Key.Location = new System.Drawing.Point(216, 85);
            this.TBX_Key.Name = "TBX_Key";
            this.TBX_Key.Size = new System.Drawing.Size(31, 20);
            this.TBX_Key.TabIndex = 5;
            this.TBX_Key.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Basic Caesar Cipher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Complex Caesar Cipher";
            // 
            // TBX_CInput
            // 
            this.TBX_CInput.Location = new System.Drawing.Point(291, 85);
            this.TBX_CInput.Name = "TBX_CInput";
            this.TBX_CInput.Size = new System.Drawing.Size(261, 20);
            this.TBX_CInput.TabIndex = 8;
            this.TBX_CInput.Text = "Input";
            // 
            // TBX_CKey
            // 
            this.TBX_CKey.Location = new System.Drawing.Point(291, 111);
            this.TBX_CKey.Name = "TBX_CKey";
            this.TBX_CKey.Size = new System.Drawing.Size(226, 20);
            this.TBX_CKey.TabIndex = 9;
            this.TBX_CKey.Text = "Key";
            // 
            // BTN_CEncrypt
            // 
            this.BTN_CEncrypt.Location = new System.Drawing.Point(291, 137);
            this.BTN_CEncrypt.Name = "BTN_CEncrypt";
            this.BTN_CEncrypt.Size = new System.Drawing.Size(100, 23);
            this.BTN_CEncrypt.TabIndex = 10;
            this.BTN_CEncrypt.Text = "Encrypt";
            this.BTN_CEncrypt.UseVisualStyleBackColor = true;
            this.BTN_CEncrypt.Click += new System.EventHandler(this.BTN_CEncrypt_Click);
            // 
            // BTN_CDecrypt
            // 
            this.BTN_CDecrypt.Location = new System.Drawing.Point(452, 137);
            this.BTN_CDecrypt.Name = "BTN_CDecrypt";
            this.BTN_CDecrypt.Size = new System.Drawing.Size(100, 23);
            this.BTN_CDecrypt.TabIndex = 11;
            this.BTN_CDecrypt.Text = "Decrypt";
            this.BTN_CDecrypt.UseVisualStyleBackColor = true;
            this.BTN_CDecrypt.Click += new System.EventHandler(this.BTN_CDecrypt_Click);
            // 
            // TBX_COutput
            // 
            this.TBX_COutput.Location = new System.Drawing.Point(291, 166);
            this.TBX_COutput.Name = "TBX_COutput";
            this.TBX_COutput.Size = new System.Drawing.Size(261, 20);
            this.TBX_COutput.TabIndex = 12;
            this.TBX_COutput.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "In a complex caesar cipher, the key must be a string of \r\nletters, containing eac" +
    "h letter of the alphabet only once.\r\nThe complex shift is the same as the basic " +
    "cipher\'s key.";
            // 
            // TBX_CShift
            // 
            this.TBX_CShift.Location = new System.Drawing.Point(523, 111);
            this.TBX_CShift.Name = "TBX_CShift";
            this.TBX_CShift.Size = new System.Drawing.Size(29, 20);
            this.TBX_CShift.TabIndex = 14;
            this.TBX_CShift.Text = "Shift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 52);
            this.label5.TabIndex = 15;
            this.label5.Text = "In a basic caesar cipher, each letter is moved \r\nforward through the alphabet by " +
    "the number of \r\nletters equal to the key. for example: A would \r\nbecome D with a" +
    " key of 3 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_CShift);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBX_COutput);
            this.Controls.Add(this.BTN_CDecrypt);
            this.Controls.Add(this.BTN_CEncrypt);
            this.Controls.Add(this.TBX_CKey);
            this.Controls.Add(this.TBX_CInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX_Key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Output);
            this.Controls.Add(this.BTN_Decrypt);
            this.Controls.Add(this.TBX_Input);
            this.Controls.Add(this.BTN_Encrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Encrypt;
        private System.Windows.Forms.TextBox TBX_Input;
        private System.Windows.Forms.TextBox TBX_Output;
        private System.Windows.Forms.Button BTN_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_CInput;
        private System.Windows.Forms.TextBox TBX_CKey;
        private System.Windows.Forms.Button BTN_CEncrypt;
        private System.Windows.Forms.Button BTN_CDecrypt;
        private System.Windows.Forms.TextBox TBX_COutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBX_CShift;
        private System.Windows.Forms.Label label5;
    }
}

