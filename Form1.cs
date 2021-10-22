using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexKonverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Global.Flag = "1";
            InitializeComponent();

            //////////////////////////////// Initiating Navbar first Button for visual purposes only ////////////////////////////////
            pnl_nav.Height = btn_texttohex.Height;
            pnl_nav.Top = btn_texttohex.Top;
            pnl_nav.Left = btn_texttohex.Left;
            label_title.Text = "Text to Hex";
            btn_texttohex.BackColor = Color.FromArgb(46, 51, 73);
        }
////////////////////////////////////////////////////////////////////  Global Flag Variable ////////////////////////////////////////////////////////////////////////////////////
        public class Global
        {
            public static string Flag { get; set; }
        }

////////////////////////////////////////////////////////////////////  Convert Side Functions ////////////////////////////////////////////////////////////////////////////////////
        public string BinaryToString(string data)
        {
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < data.Length; i += 8)
                bytes.Add(Convert.ToByte(data.Substring(i, 8), 2));
            return Encoding.ASCII.GetString(bytes.ToArray());
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private string RemoveSpecialCharacters(string str)
        {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9')
                    || (str[i] >= 'A' && str[i] <= 'z'
                        || (str[i] == '.' || str[i] == '_')))
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////  Flag Functions - Convert Operations /////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
        private void TextToHex()
        {

            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = "";
                string toConvert = txt_input.Text;
                char[] values = toConvert.ToCharArray();
                foreach (char letter in values)
                {
                    int value = Convert.ToInt32(letter);
                    result += ($"{value:X}");
                }

                result = Regex.Replace(result, ".{2}", "$0 ");
                txt_output.Text = result;

            }
        }

        private void HexToText()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = "";
                string toConvert = txt_input.Text;
                // Deciding if its plausible hexcode
                List<string> listHexValidation = new List<string>();
                listHexValidation.Add("g");
                listHexValidation.Add("h");
                listHexValidation.Add("i");
                listHexValidation.Add("j");
                listHexValidation.Add("k");
                listHexValidation.Add("l");
                listHexValidation.Add("m");
                listHexValidation.Add("n");
                listHexValidation.Add("o");
                listHexValidation.Add("p");
                listHexValidation.Add("q");
                listHexValidation.Add("r");
                listHexValidation.Add("s");
                listHexValidation.Add("t");
                listHexValidation.Add("u");
                listHexValidation.Add("v");              
                listHexValidation.Add("w");
                listHexValidation.Add("x");
                listHexValidation.Add("y");
                listHexValidation.Add("z");
                // If "HexCode" contains any illegal hex chars, it will give error out.
                if (listHexValidation.Any(s => toConvert.Contains(s)))
                {
                    txt_output.Text = "No valid Hex Code!";
                }
                else
                {
                    // Cleaning up any special chars in string then removing all spaces and finally (---make space after every 2 char for hex convert/ one liner does that)
                    try
                    {
                        toConvert = RemoveSpecialCharacters(toConvert);
                        toConvert = Regex.Replace(toConvert, @"\s+", "");
                        //changed code below from foreach to .NET5 convert due to out of range exceptions 
                        //toConvert = Regex.Replace(toConvert, ".{2}", "$0 ");
                        result = Encoding.UTF8.GetString(Convert.FromHexString(toConvert));
                        txt_output.Text = result;
                    }
                    catch (Exception)
                    {
                        //Mostly getting not dividable /2 exception due to NO VALID HEXCODE -
                        txt_output.Text = "Unknown Error or no valid Hex Code!\n Please check if your input is really hexcode.";
                    }
                }
            }
        }

        private void texttobase64()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = "";
                string toConvert = txt_input.Text;
                //toConvert = Encoding.UTF8.GetBytes(System.Convert.ToBase64String(toConvert));
                var convertByte = System.Text.Encoding.UTF8.GetBytes(toConvert);
                result = Convert.ToBase64String(convertByte);
                txt_output.Text = result;

            }
        }

        private void base64totext()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = "";
                string toConvert = txt_input.Text;
                //var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                //return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                result = Encoding.UTF8.GetString(Convert.FromBase64String(toConvert));

                txt_output.Text = result;
            }
        }

        private void TextToAscii()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {

                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = string.Empty;
                string toConvert = txt_input.Text;
                var convertByte = Encoding.ASCII.GetBytes(toConvert);
                foreach (byte i in toConvert)
                {
                    result += i;
                }
                result = Regex.Replace(result, ".{3}", "$0 ");
                txt_output.Text = result;
            }
        }

////////////////// Needs fixing ////////////////////////////////////////////////////////////////////
        private void AsciiToText()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }                                                       
            else
            {
                string result = "";
                string toConvert = txt_input.Text;
                txt_output.Text = result;
            }
        }
////////////////// Needs fixing //////////////////////////////////////////////////////////////////

        private void TextToBinary()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = string.Empty;
                string toConvert = txt_input.Text;
                result = StringToBinary(toConvert);
                txt_output.Text = result;

            }
        }

        private void BinaryToText()
        {
            if (String.IsNullOrEmpty(txt_input.Text))
            {
                txt_output.Text = "Please enter something before trying to convert!";
            }
            else
            {
                string result = string.Empty;
                result =  BinaryToString(txt_input.Text);
                txt_output.Text = result;

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////  USER INTERFACE  //////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            //
        }

        /////////////////////////////////////////////////////////////////// Button Click Events Navbar //////////////////////////////////////////////////////////////////////////

        // Text to Hex
        private void btn_texttohex_Click(object sender, EventArgs e)
        {
            // I love global variables, OOP..... NAH. - Sets a flag for the converter -> No need for formloader then
            Global.Flag = "1";
            //Delete artifacts from input/ouput box
            txt_input.Clear();
            txt_output.Clear();
            // Awesome looking Panel to the left as button marker
            pnl_nav.Height = btn_texttohex.Height;
            pnl_nav.Top = btn_texttohex.Top;
            pnl_nav.Left = btn_texttohex.Left;
            //Changing label -> User can better see what the input will convert to
            label_title.Text = "Text to Hex";
            //Colorize the world, background button color for idiot proof readability
            btn_texttohex.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Hex to Text
        private void btn_HexToText_Click(object sender, EventArgs e)
        {
            Global.Flag = "2";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = btn_HexToText.Height;
            pnl_nav.Top = btn_HexToText.Top;
            pnl_nav.Left = btn_HexToText.Left;
            label_title.Text = "Hex to Text";
            btn_HexToText.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Text to Base64
        private void TextToBase64_Click(object sender, EventArgs e)
        {
            Global.Flag = "3";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = TextToBase64.Height;
            pnl_nav.Top = TextToBase64.Top;
            pnl_nav.Left = TextToBase64.Left;
            label_title.Text = "Text to BASE64";
            TextToBase64.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Base64 to Text
        private void Base64ToText_Click(object sender, EventArgs e)
        {
            Global.Flag = "4";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = Base64ToText.Height;
            pnl_nav.Top = Base64ToText.Top;
            pnl_nav.Left = Base64ToText.Left;
            label_title.Text = "BASE64 to Text";
            Base64ToText.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Text to Ascii - need bugfixing - removes 0 out of result for some reason?
        private void btn_TextToAscii_Click(object sender, EventArgs e)
        {
            Global.Flag = "5";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = btn_TextToAscii.Height;
            pnl_nav.Top = btn_TextToAscii.Top;
            pnl_nav.Left = btn_TextToAscii.Left;
            label_title.Text = "Text to ASCII Value";
            btn_TextToAscii.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Ascii to Text // Problems with converting - deactivate for now - need bugfixing/new code
        private void btn_AsciiToText_Click(object sender, EventArgs e)
        {
            Global.Flag = "6";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = btn_AsciiToText.Height;
            pnl_nav.Top = btn_AsciiToText.Top;
            pnl_nav.Left = btn_AsciiToText.Left;
            label_title.Text = "ASCII Value to Text";
            btn_AsciiToText.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Text to Binary
        private void btn_toBinary_Click(object sender, EventArgs e)
        {
            Global.Flag = "7";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = btn_toBinary.Height;
            pnl_nav.Top = btn_toBinary.Top;
            pnl_nav.Left = btn_toBinary.Left;
            label_title.Text = "Text to Binary";
            btn_toBinary.BackColor = Color.FromArgb(46, 51, 73);
        }

        // Binary to Text
        private void btn_binaryToText_Click(object sender, EventArgs e)
        {
            Global.Flag = "8";
            txt_input.Clear();
            txt_output.Clear();
            pnl_nav.Height = btn_binaryToText.Height;
            pnl_nav.Top = btn_binaryToText.Top;
            pnl_nav.Left = btn_binaryToText.Left;
            label_title.Text = "Binary to Text";
            btn_binaryToText.BackColor = Color.FromArgb(46, 51, 73);
        }

        ////////////////////////////////////////////////////////////////////  Convert Button  //////////////////////////////////////////////////////////////////////////////////
        // Depending on the active button on the navbar, different event will triggered due to flag set in global variable //
        private void btn_convert_Click(object sender, EventArgs e)
        {

            string flag = Global.Flag; 


            if (flag == "1")
            {
                TextToHex();

            }

            else if (flag == "2")
            {

                HexToText();
            }

            else if (flag == "3")
            {
                texttobase64();
            }
            else if (flag == "4")
            {

                base64totext();
            }
            else if (flag == "5")
            {
                TextToAscii();
                
            }
            else if (flag == "6")
            {
                AsciiToText();
            }
            else if (flag == "7")
            {
                TextToBinary();
            }
            else if (flag == "8")
            {
                BinaryToText();
            }
            else if (flag == "9")
            {
                
            }
            else if (flag == "10")
            {
                
            }
            else
            {
                txt_output.Text = @"ERROR. This should not have happened. ¯\_(ツ)_/¯ ";
            }
        }



        ////////////////////////////////////////////////////////////////////  Leave Focus Events  //////////////////////////////////////////////////////////////////////////////////
        // Button Background change mostly //

        private void btn_texttohex_Leave(object sender, EventArgs e)
        {
            btn_texttohex.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_HexToText_Leave(object sender, EventArgs e)
        {
            btn_HexToText.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void TextToBase64_Leave(object sender, EventArgs e)
        {
            TextToBase64.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Base64ToText_Leave(object sender, EventArgs e)
        {
            Base64ToText.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_AsciiToText_Leave(object sender, EventArgs e)
        {
            btn_AsciiToText.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_TextToAscii_Leave(object sender, EventArgs e)
        {
            btn_TextToAscii.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_toBinary_Leave(object sender, EventArgs e)
        {
            btn_toBinary.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_binaryToText_Leave(object sender, EventArgs e)
        {
            btn_binaryToText.BackColor = Color.FromArgb(24, 30, 54);
        }






        ////////////////////////////////////////////////////////////////////  Obsolete Code for now  /////////////////////////////////////////////////////////////////////////////////

        private void pnl_nav_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void btn_texttohex_DragLeave(object sender, EventArgs e)
        {
            //
        }







    }
}
