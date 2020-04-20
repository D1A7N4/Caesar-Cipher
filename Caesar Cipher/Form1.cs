using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Encrypt_Click(object sender, EventArgs e)
        {
            string plaintext = TBX_Input.Text.ToUpper();
            if (int.TryParse(TBX_Key.Text, out int key) == false)
            {
                MessageBox.Show("Please enter a valid integer key");
            }
            if (key >= 26)
            {
                MessageBox.Show("Please enter an integer key less than 26");
                key = 0;
            }
            if (key < 0)
            {
                MessageBox.Show("Please enter an integer key greater than 0");
                key = 0;
            }
            char[] plainchars = plaintext.ToCharArray();
            int[] plainints = new int[plainchars.Length];
            char[] cypherchars = new char[plainchars.Length];
            string output="";
            for (int i = 0; i < plainchars.Length; i++)
            {
                plainints[i] = plainchars[i];
                if((plainints[i] + key) <= 90)
                {
                    cypherchars[i] = Convert.ToChar(plainints[i] + key);
                }
                else
                {
                    cypherchars[i] = Convert.ToChar(plainints[i] + key - 26);
                }
                output = output + cypherchars[i];
            }
            TBX_Output.Text = output;
        }
        private void BTN_Decrypt_Click(object sender, EventArgs e)
        {
            string plaintext = TBX_Input.Text.ToUpper();
            if (int.TryParse(TBX_Key.Text, out int key) == false)
            {
                MessageBox.Show("Please enter a valid integer key");
            }
            if (key >= 26)
            {
                MessageBox.Show("Please enter an integer key less than 26");
                key = 0;
            }
            if (key < 0)
            {
                MessageBox.Show("Please enter an integer key greater than 0");
                key = 0;
            }
            char[] plainchars = plaintext.ToCharArray();
            int[] plainints = new int[plainchars.Length];
            char[] cypherchars = new char[plainchars.Length];
            string output = "";
            for (int i = 0; i < plainchars.Length; i++)
            {
                plainints[i] = plainchars[i];
                if ((plainints[i] - key) >= 65)
                {
                    cypherchars[i] = Convert.ToChar(plainints[i] - key);
                }
                else
                {
                    cypherchars[i] = Convert.ToChar(plainints[i] - key + 26);
                }
                output = output + cypherchars[i];
            }
            TBX_Output.Text = output;
        }
        private void BTN_CEncrypt_Click(object sender, EventArgs e)
        {
            List<char> alphabet = new List<char>();
            for (int i = 65; i < 91; i++)
            {
                alphabet.Add(Convert.ToChar(i));
            }
            if (TBX_CKey.TextLength == 26)
            {
                foreach (char c in TBX_CKey.Text.ToUpper().ToCharArray())
                {
                    if (alphabet.Contains(c))
                    {
                        alphabet.Remove(c);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a key that contains every letter of the alphabet.");
                        TBX_CKey.Text = "abcdefghijklmnopqrstuvwxyz";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a key that contains all 26 letters of the alphabet.");
                TBX_CKey.Text = "abcdefghijklmnopqrstuvwxyz";
            }
            if (int.TryParse(TBX_CShift.Text, out int shift) == false)
            {
                MessageBox.Show("Please enter a valid integer shift");
            }
            if (shift >= 26)
            {
                MessageBox.Show("Please enter an integer shift less than 26");
                shift = 0;
            }
            if (shift < 0)
            {
                MessageBox.Show("Please enter an integer shift greater than 0");
                shift = 0;
            }
            Complex_converter convert = new Complex_converter(TBX_CKey.Text, shift);
            TBX_COutput.Text = convert.encrypt(TBX_CInput.Text);
        }
        private void BTN_CDecrypt_Click(object sender, EventArgs e)
        {
            List<char> alphabet = new List<char>();
            for (int i = 65; i < 91; i++)
            {
                alphabet.Add(Convert.ToChar(i));
            }
            if (TBX_CKey.TextLength == 26)
            {
                foreach (char c in TBX_CKey.Text.ToUpper().ToCharArray())
                {
                    if (alphabet.Contains(c))
                    {
                        alphabet.Remove(c);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a key that contains every letter of the alphabet.");
                        TBX_CKey.Text = "abcdefghijklmnopqrstuvwxyz";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a key that contains all 26 letters of the alphabet.");
                TBX_CKey.Text = "abcdefghijklmnopqrstuvwxyz";
            }
            if (int.TryParse(TBX_CShift.Text, out int shift) == false)
            {
                MessageBox.Show("Please enter a valid integer key");
            }
            if (shift >= 26)
            {
                MessageBox.Show("Please enter an integer key less than 26");
                shift = 0;
            }
            if (shift < 0)
            {
                MessageBox.Show("Please enter an integer key greater than 0");
                shift = 0;
            }
            Complex_converter convert = new Complex_converter(TBX_CKey.Text, shift);
            TBX_COutput.Text = convert.decrypt(TBX_CInput.Text);
        }
    }
}