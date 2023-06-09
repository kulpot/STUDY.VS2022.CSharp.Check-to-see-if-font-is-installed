using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=hZf4F7OSJpI&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=54
//Two methods, one is typical and the other can be used as an extension method for the Font object

namespace Check_to_see_if_font_is_installed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool IsFontInstalled(string familyName)
        {
            using (Font testFont = new Font(familyName, 10f, FontStyle.Regular))
            {
                StringComparison SC = StringComparison.InvariantCultureIgnoreCase;
                return (string.Compare(familyName, testFont.Name, SC) == 0); // test break here
            }
        }

        public static bool IsFontInstalled(Font font)
        {
            StringComparison SC = StringComparison.InvariantCultureIgnoreCase;
            return (string.Compare(font.OriginalFontName, font.Name, SC) == 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font font = new Font(textBox1.Text, 10f, FontStyle.Regular);// testing if font is installed
            this.Text = IsFontInstalled(font).ToString();
            //this.Text = IsFontInstalled(textBox1.Text).ToString();
        }
    }
}
