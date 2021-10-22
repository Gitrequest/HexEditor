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


            // Awesome looking Panel to the left as button marker
            pnl_nav.Height = btn_texttohex.Height;
            pnl_nav.Top = btn_texttohex.Top;
            pnl_nav.Left = btn_texttohex.Left;

            //Changing label -> User can see what exactly now happens
            label_title.Text = "Text to Hex";

            //Colorize the world, background button color for idiot proof readability
            btn_texttohex.BackColor = Color.FromArgb(46, 51, 73);




        }



        public class Global
        {
            //public static int flag;
            public static string Flag { get; set; }
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
                    
                    //Console.WriteLine($"Hexadecimal value of {letter} is {value:X}");
                    
                    result += ($"{value:X}");

                    
                }

                result = Regex.Replace(result, ".{2}", "$0 ");
                txt_output.Text = result;

            }
        }


        private void HexToText()
        {


            // Check if box is empty / Not really nescessary tho
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



        //UI / Button
        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_HexToText_Click(object sender, EventArgs e)
        {
            // I love global variables, OOP..... NAH. - Sets a flag for the converter -> No need for formloader then
            Global.Flag = "2";

            //Delete artifacts from input/ouput box
            txt_input.Clear();
            txt_output.Clear();
            // Awesome looking Panel to the left as button marker
            pnl_nav.Height = btn_HexToText.Height;
            pnl_nav.Top = btn_HexToText.Top;
            pnl_nav.Left = btn_HexToText.Left;

            //Changing label -> User can see what exactly now happens
            label_title.Text = "Hex to Text";

            //Colorize the world, background button color for idiot proof readability
            btn_HexToText.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btn_texttohex_Click(object sender, EventArgs e)
        {
            // I love global variables, OOP..... NAH. - Sets a flag for the converter -> No need for formloader then
            Global.Flag = "1";

            txt_input.Clear();
            txt_output.Clear();

            // Awesome looking Panel to the left as button marker
            pnl_nav.Height = btn_texttohex.Height;
            pnl_nav.Top = btn_texttohex.Top;
            pnl_nav.Left = btn_texttohex.Left;

            //Changing label -> User can see what exactly now happens
            label_title.Text = "Text to Hex";

            //Colorize the world, background button color for idiot proof readability
            btn_texttohex.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void TextToBase64_Click(object sender, EventArgs e)
        {
            // I love global variables, OOP..... NAH. - Sets a flag for the converter -> No need for formloader then
            Global.Flag = "3";

            txt_input.Clear();
            txt_output.Clear();

            // Awesome looking Panel to the left as button marker
            pnl_nav.Height = TextToBase64.Height;
            pnl_nav.Top = TextToBase64.Top;
            pnl_nav.Left = TextToBase64.Left;

            //Changing label -> User can see what exactly now happens
            label_title.Text = "Text to BASE64";

            //Colorize the world, background button color for idiot proof readability
            TextToBase64.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Base64ToText_Click(object sender, EventArgs e)
        {
            // I love global variables, OOP..... NAH. - Sets a flag for the converter -> No need for formloader then
            Global.Flag = "4";

            txt_input.Clear();
            txt_output.Clear();

            // Awesome looking Panel to the left as button marker
            pnl_nav.Height = Base64ToText.Height;
            pnl_nav.Top = Base64ToText.Top;
            pnl_nav.Left = Base64ToText.Left;

            //Changing label -> User can see what exactly now happens
            label_title.Text = "BASE64 to Text";

            //Colorize the world, background button color for idiot proof readability
            Base64ToText.BackColor = Color.FromArgb(46, 51, 73);
        }






        // Convert Button Press - Depending on what "site" one is one, different event will triggered
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
            else
            {

            }
        }




        // Leave Fokus Events - Button Background change
        private void btn_texttohex_DragLeave(object sender, EventArgs e)
        {

        }

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
    }
}
