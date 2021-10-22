
namespace HexKonverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_navbar = new System.Windows.Forms.Panel();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_binaryToText = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_toBinary = new System.Windows.Forms.Button();
            this.btn_AsciiToText = new System.Windows.Forms.Button();
            this.btn_TextToAscii = new System.Windows.Forms.Button();
            this.Base64ToText = new System.Windows.Forms.Button();
            this.TextToBase64 = new System.Windows.Forms.Button();
            this.btn_HexToText = new System.Windows.Forms.Button();
            this.btn_texttohex = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.pnl_navbar.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_navbar
            // 
            this.pnl_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl_navbar.Controls.Add(this.pnl_nav);
            this.pnl_navbar.Controls.Add(this.btn_binaryToText);
            this.pnl_navbar.Controls.Add(this.button3);
            this.pnl_navbar.Controls.Add(this.button2);
            this.pnl_navbar.Controls.Add(this.btn_toBinary);
            this.pnl_navbar.Controls.Add(this.btn_AsciiToText);
            this.pnl_navbar.Controls.Add(this.btn_TextToAscii);
            this.pnl_navbar.Controls.Add(this.Base64ToText);
            this.pnl_navbar.Controls.Add(this.TextToBase64);
            this.pnl_navbar.Controls.Add(this.btn_HexToText);
            this.pnl_navbar.Controls.Add(this.btn_texttohex);
            this.pnl_navbar.Controls.Add(this.pnl_logo);
            this.pnl_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_navbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_navbar.Name = "pnl_navbar";
            this.pnl_navbar.Size = new System.Drawing.Size(200, 881);
            this.pnl_navbar.TabIndex = 0;
            // 
            // pnl_nav
            // 
            this.pnl_nav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_nav.BackColor = System.Drawing.Color.Coral;
            this.pnl_nav.Location = new System.Drawing.Point(3, 262);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(4, 150);
            this.pnl_nav.TabIndex = 1;
            this.pnl_nav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_nav_Paint);
            // 
            // btn_binaryToText
            // 
            this.btn_binaryToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_binaryToText.FlatAppearance.BorderSize = 0;
            this.btn_binaryToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_binaryToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_binaryToText.ForeColor = System.Drawing.Color.Coral;
            this.btn_binaryToText.Location = new System.Drawing.Point(0, 465);
            this.btn_binaryToText.Name = "btn_binaryToText";
            this.btn_binaryToText.Size = new System.Drawing.Size(200, 53);
            this.btn_binaryToText.TabIndex = 9;
            this.btn_binaryToText.Text = "Binary to Text";
            this.btn_binaryToText.UseVisualStyleBackColor = true;
            this.btn_binaryToText.Click += new System.EventHandler(this.btn_binaryToText_Click);
            this.btn_binaryToText.Leave += new System.EventHandler(this.btn_binaryToText_Leave);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(-3, 683);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 53);
            this.button3.TabIndex = 11;
            this.button3.Text = "Text to Binary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(0, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Text to Binary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btn_toBinary
            // 
            this.btn_toBinary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_toBinary.FlatAppearance.BorderSize = 0;
            this.btn_toBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_toBinary.ForeColor = System.Drawing.Color.Coral;
            this.btn_toBinary.Location = new System.Drawing.Point(0, 412);
            this.btn_toBinary.Name = "btn_toBinary";
            this.btn_toBinary.Size = new System.Drawing.Size(200, 53);
            this.btn_toBinary.TabIndex = 8;
            this.btn_toBinary.Text = "Text to Binary";
            this.btn_toBinary.UseVisualStyleBackColor = true;
            this.btn_toBinary.Click += new System.EventHandler(this.btn_toBinary_Click);
            this.btn_toBinary.Leave += new System.EventHandler(this.btn_toBinary_Leave);
            // 
            // btn_AsciiToText
            // 
            this.btn_AsciiToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AsciiToText.FlatAppearance.BorderSize = 0;
            this.btn_AsciiToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AsciiToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AsciiToText.ForeColor = System.Drawing.Color.Coral;
            this.btn_AsciiToText.Location = new System.Drawing.Point(0, 359);
            this.btn_AsciiToText.Name = "btn_AsciiToText";
            this.btn_AsciiToText.Size = new System.Drawing.Size(200, 53);
            this.btn_AsciiToText.TabIndex = 6;
            this.btn_AsciiToText.Text = "Ascii to Text";
            this.btn_AsciiToText.UseVisualStyleBackColor = true;
            this.btn_AsciiToText.Visible = false;
            this.btn_AsciiToText.Click += new System.EventHandler(this.btn_AsciiToText_Click);
            this.btn_AsciiToText.Leave += new System.EventHandler(this.btn_AsciiToText_Leave);
            // 
            // btn_TextToAscii
            // 
            this.btn_TextToAscii.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TextToAscii.FlatAppearance.BorderSize = 0;
            this.btn_TextToAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TextToAscii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TextToAscii.ForeColor = System.Drawing.Color.Coral;
            this.btn_TextToAscii.Location = new System.Drawing.Point(0, 306);
            this.btn_TextToAscii.Name = "btn_TextToAscii";
            this.btn_TextToAscii.Size = new System.Drawing.Size(200, 53);
            this.btn_TextToAscii.TabIndex = 5;
            this.btn_TextToAscii.Text = "Text to Ascii";
            this.btn_TextToAscii.UseVisualStyleBackColor = true;
            this.btn_TextToAscii.Click += new System.EventHandler(this.btn_TextToAscii_Click);
            this.btn_TextToAscii.Leave += new System.EventHandler(this.btn_TextToAscii_Leave);
            // 
            // Base64ToText
            // 
            this.Base64ToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.Base64ToText.FlatAppearance.BorderSize = 0;
            this.Base64ToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Base64ToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Base64ToText.ForeColor = System.Drawing.Color.Coral;
            this.Base64ToText.Location = new System.Drawing.Point(0, 253);
            this.Base64ToText.Name = "Base64ToText";
            this.Base64ToText.Size = new System.Drawing.Size(200, 53);
            this.Base64ToText.TabIndex = 4;
            this.Base64ToText.Text = "Base64 to Text";
            this.Base64ToText.UseVisualStyleBackColor = true;
            this.Base64ToText.Click += new System.EventHandler(this.Base64ToText_Click);
            this.Base64ToText.Leave += new System.EventHandler(this.Base64ToText_Leave);
            // 
            // TextToBase64
            // 
            this.TextToBase64.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextToBase64.FlatAppearance.BorderSize = 0;
            this.TextToBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextToBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextToBase64.ForeColor = System.Drawing.Color.Coral;
            this.TextToBase64.Location = new System.Drawing.Point(0, 200);
            this.TextToBase64.Name = "TextToBase64";
            this.TextToBase64.Size = new System.Drawing.Size(200, 53);
            this.TextToBase64.TabIndex = 3;
            this.TextToBase64.Text = "Text to Base64";
            this.TextToBase64.UseVisualStyleBackColor = true;
            this.TextToBase64.Click += new System.EventHandler(this.TextToBase64_Click);
            this.TextToBase64.Leave += new System.EventHandler(this.TextToBase64_Leave);
            // 
            // btn_HexToText
            // 
            this.btn_HexToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HexToText.FlatAppearance.BorderSize = 0;
            this.btn_HexToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HexToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HexToText.ForeColor = System.Drawing.Color.Coral;
            this.btn_HexToText.Location = new System.Drawing.Point(0, 147);
            this.btn_HexToText.Name = "btn_HexToText";
            this.btn_HexToText.Size = new System.Drawing.Size(200, 53);
            this.btn_HexToText.TabIndex = 2;
            this.btn_HexToText.Text = "Hex to Text";
            this.btn_HexToText.UseVisualStyleBackColor = true;
            this.btn_HexToText.Click += new System.EventHandler(this.btn_HexToText_Click);
            this.btn_HexToText.Leave += new System.EventHandler(this.btn_HexToText_Leave);
            // 
            // btn_texttohex
            // 
            this.btn_texttohex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_texttohex.FlatAppearance.BorderSize = 0;
            this.btn_texttohex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_texttohex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_texttohex.ForeColor = System.Drawing.Color.Coral;
            this.btn_texttohex.Location = new System.Drawing.Point(0, 94);
            this.btn_texttohex.Name = "btn_texttohex";
            this.btn_texttohex.Size = new System.Drawing.Size(200, 53);
            this.btn_texttohex.TabIndex = 1;
            this.btn_texttohex.Text = "Text to Hex";
            this.btn_texttohex.UseVisualStyleBackColor = true;
            this.btn_texttohex.Click += new System.EventHandler(this.btn_texttohex_Click);
            this.btn_texttohex.DragLeave += new System.EventHandler(this.btn_texttohex_DragLeave);
            this.btn_texttohex.Leave += new System.EventHandler(this.btn_texttohex_Leave);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.pnl_logo.Controls.Add(this.label_title);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(200, 94);
            this.pnl_logo.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.Coral;
            this.label_title.Location = new System.Drawing.Point(12, 33);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(118, 24);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Text to Hex";
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_input.ForeColor = System.Drawing.Color.Coral;
            this.txt_input.Location = new System.Drawing.Point(206, 94);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(966, 380);
            this.txt_input.TabIndex = 1;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // txt_output
            // 
            this.txt_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_output.ForeColor = System.Drawing.Color.GreenYellow;
            this.txt_output.Location = new System.Drawing.Point(206, 489);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(966, 380);
            this.txt_output.TabIndex = 2;
            // 
            // btn_convert
            // 
            this.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convert.ForeColor = System.Drawing.Color.Coral;
            this.btn_convert.Location = new System.Drawing.Point(206, 33);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(156, 48);
            this.btn_convert.TabIndex = 9;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.pnl_navbar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HexEditor";
            this.pnl_navbar.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_navbar;
        private System.Windows.Forms.Button btn_toBinary;
        private System.Windows.Forms.Button btn_AsciiToText;
        private System.Windows.Forms.Button btn_TextToAscii;
        private System.Windows.Forms.Button Base64ToText;
        private System.Windows.Forms.Button TextToBase64;
        private System.Windows.Forms.Button btn_HexToText;
        private System.Windows.Forms.Button btn_texttohex;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_binaryToText;
    }
}

