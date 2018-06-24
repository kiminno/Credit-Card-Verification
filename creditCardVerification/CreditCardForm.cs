using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CreditCardForm : Form
    {
        public CreditCardForm()
        {
            InitializeComponent();
        }

        #region Methods

        #region CheckSum
        private int CheckSum(string cardNumber)
        {
            int sum = 0;

            // Add the elements at the odd indices, counting from right to left
            for (int i = cardNumber.Length - 1; i >= 0; i -= 2)
            {
                sum += Convert.ToInt32(cardNumber[i].ToString());
            }
                      
            // Add the elements at the even indices after multiplying by 2 and modifying it to be a single digit, counting from right to left
            for (int i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int currentDigit=Convert.ToInt32(cardNumber[i].ToString());
                sum += currentDigit * 2 / 10 + currentDigit * 2 % 10;
            }
            return sum;
        }
        #endregion

        #region CardType
        private string CardType(string cardNumber)
        {
            if (CheckSum(cardNumber) % 10 == 0)
            {
                int length = cardNumber.Length;
                string firstTwoDigits = cardNumber.Substring(0, 2);

                // Determine the card type
                if (length == 16)
                {
                    if (cardNumber[0] == '4')
                    {
                        return "Visa";
                    }
                    else if (firstTwoDigits == "51" || firstTwoDigits == "52" || firstTwoDigits == "53" || firstTwoDigits == "54" || firstTwoDigits == "55")
                    {
                        return "Master Card";
                    }
                    else if (cardNumber.Substring(0, 4) == "6011")
                    {
                        return "Discover";
                    }
                }
                else if (length == 15 && (firstTwoDigits == "34" || firstTwoDigits == "37"))
                {
                    return "American Express";
                }
                else if (length == 14 && firstTwoDigits == "36")
                {
                    return "Diners Club";
                }
            }

            return "Unknown";
        }
        #endregion

        #region GenerateNumber
        private string GenerateNumber(int numLength, string prefix)
        {
            Random rand = new Random();

            // Determines the length of the random number that must be generated excluding prefix and rightmost digit
            int numDigitsToGenerate = numLength - prefix.Length - 1;
            byte[] byteArray = new byte[numDigitsToGenerate];
            
            // Fill "byteArray" with random bytes
            rand.NextBytes(byteArray);

            // "num" can have from "numDigitsToGenerate" to 19 digits
            long num = Math.Abs(BitConverter.ToInt64(byteArray, 0));

            // Repeatedly divide num by 2 until a number with the desired number of digits is obtained
            while (num / Math.Pow(10, numDigitsToGenerate) >= 1)
            {
                num >>= 1;
            }

            string cardNum = prefix + num.ToString();

            // Concatenate the appropriate rightmost digit that guarantees a valid checksum
            cardNum = cardNum + ((10 - CheckSum(cardNum + "0") % 10) % 10).ToString();
           
            return cardNum;
        }
        #endregion

        #endregion

        #region Event Handlers

        #region numberTextBox
        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numberTextBox.Text.Length > 1)
            {
                cardTypeLabel.Text = CardType(numberTextBox.Text);
            }
        }
        #endregion

        #region generateButton
        private void generateButton_Click(object sender, EventArgs e)
        {
            Random randNumGen = new Random();
            
            // print the appropriate credit card number to the "cardNumLabel"
            if (visaRadioButton.Checked)
            {
                cardNumLabel.Text = GenerateNumber(16, "4");
            }
            else if (mastercardRadioButton.Checked)
            {
                cardNumLabel.Text = GenerateNumber(16, randNumGen.Next(51,56).ToString());
            }
            else if (americanRadioButton.Checked)
            {
                cardNumLabel.Text = GenerateNumber(15, (randNumGen.Next(0,2) == 0) ? "34": "37");
            }
            else if (discoverRadioButton.Checked)
            {
                cardNumLabel.Text = GenerateNumber(16, "6011");
            }
            else if (dinersRadioButton.Checked)
            {
                cardNumLabel.Text = GenerateNumber(14, "36");
            }
        }
        #endregion

        #region keyDown
        private void numberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // all key presses are suppressed
            e.SuppressKeyPress = true;

            // array of all valid keys
            Keys[] validKey = new Keys[24] {Keys.Back, Keys.A | Keys.Control, Keys.C | Keys.Control, Keys.X | Keys.Control,
                                            Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4,
                                            Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, 
                                            Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4,
                                            Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9};

            // loop through the elements of the "validKey" array and allow the key if the pressed key is an element in the array
            foreach (Keys key in validKey)
            {
                if (e.KeyData == key)
                {
                    e.SuppressKeyPress = false;
                }
            }
        }
        #endregion

        #endregion

    }
}
