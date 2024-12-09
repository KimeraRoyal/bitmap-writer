using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapWriter
{
    public partial class Form1 : Form
    {
        private FontSelector m_fontSelector;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void LoadFont(string _url)
        {
            Console.Out.WriteLine(_url);
        }

        private void loadFontButton_Click(object sender, EventArgs e)
        {
        }
    }
}