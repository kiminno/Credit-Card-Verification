namespace WindowsFormsApplication1
{
    partial class CreditCardForm
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.mastercardRadioButton = new System.Windows.Forms.RadioButton();
            this.americanRadioButton = new System.Windows.Forms.RadioButton();
            this.discoverRadioButton = new System.Windows.Forms.RadioButton();
            this.dinersRadioButton = new System.Windows.Forms.RadioButton();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardNumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(26, 52);
            this.numberTextBox.MaxLength = 16;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(140, 20);
            this.numberTextBox.TabIndex = 0;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            this.numberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter credit card number:";
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.Location = new System.Drawing.Point(26, 109);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(0, 13);
            this.verifyLabel.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(144, 143);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credit Card Type:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(26, 168);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(45, 17);
            this.visaRadioButton.TabIndex = 6;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastercardRadioButton
            // 
            this.mastercardRadioButton.AutoSize = true;
            this.mastercardRadioButton.Location = new System.Drawing.Point(26, 191);
            this.mastercardRadioButton.Name = "mastercardRadioButton";
            this.mastercardRadioButton.Size = new System.Drawing.Size(82, 17);
            this.mastercardRadioButton.TabIndex = 7;
            this.mastercardRadioButton.TabStop = true;
            this.mastercardRadioButton.Text = "Master Card";
            this.mastercardRadioButton.UseVisualStyleBackColor = true;
            // 
            // americanRadioButton
            // 
            this.americanRadioButton.AutoSize = true;
            this.americanRadioButton.Location = new System.Drawing.Point(26, 214);
            this.americanRadioButton.Name = "americanRadioButton";
            this.americanRadioButton.Size = new System.Drawing.Size(109, 17);
            this.americanRadioButton.TabIndex = 8;
            this.americanRadioButton.TabStop = true;
            this.americanRadioButton.Text = "American Express";
            this.americanRadioButton.UseVisualStyleBackColor = true;
            // 
            // discoverRadioButton
            // 
            this.discoverRadioButton.AutoSize = true;
            this.discoverRadioButton.Location = new System.Drawing.Point(26, 237);
            this.discoverRadioButton.Name = "discoverRadioButton";
            this.discoverRadioButton.Size = new System.Drawing.Size(67, 17);
            this.discoverRadioButton.TabIndex = 9;
            this.discoverRadioButton.TabStop = true;
            this.discoverRadioButton.Text = "Discover";
            this.discoverRadioButton.UseVisualStyleBackColor = true;
            // 
            // dinersRadioButton
            // 
            this.dinersRadioButton.AutoSize = true;
            this.dinersRadioButton.Location = new System.Drawing.Point(26, 258);
            this.dinersRadioButton.Name = "dinersRadioButton";
            this.dinersRadioButton.Size = new System.Drawing.Size(82, 17);
            this.dinersRadioButton.TabIndex = 10;
            this.dinersRadioButton.TabStop = true;
            this.dinersRadioButton.Text = "Diners Club ";
            this.dinersRadioButton.UseVisualStyleBackColor = true;
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.Location = new System.Drawing.Point(26, 99);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.cardTypeLabel.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select a credit card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Credit Card Number:";
            // 
            // cardNumLabel
            // 
            this.cardNumLabel.AutoSize = true;
            this.cardNumLabel.Location = new System.Drawing.Point(144, 207);
            this.cardNumLabel.Name = "cardNumLabel";
            this.cardNumLabel.Size = new System.Drawing.Size(0, 13);
            this.cardNumLabel.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nancy Ngo";
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(280, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cardNumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardTypeLabel);
            this.Controls.Add(this.dinersRadioButton);
            this.Controls.Add(this.discoverRadioButton);
            this.Controls.Add(this.americanRadioButton);
            this.Controls.Add(this.mastercardRadioButton);
            this.Controls.Add(this.visaRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.verifyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Name = "CreditCardForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label verifyLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton mastercardRadioButton;
        private System.Windows.Forms.RadioButton americanRadioButton;
        private System.Windows.Forms.RadioButton discoverRadioButton;
        private System.Windows.Forms.RadioButton dinersRadioButton;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cardNumLabel;
        private System.Windows.Forms.Label label5;
    }
}

