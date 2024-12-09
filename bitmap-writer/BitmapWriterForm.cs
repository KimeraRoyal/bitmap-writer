using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapWriter
{
    public partial class BitmapWriterForm : Form
    {
        private ColorDialog m_colorDialog;
        private FontSelector m_fontSelector;
        
        private FontFamily m_lastFont;
        private int m_fontSize = 12;
        
        public BitmapWriterForm()
        {
            InitializeComponent();
            
            m_fontSelector = new FontSelector();
        }

        private void loadFontButton_Click(object sender, EventArgs e)
        {
            var font = m_fontSelector.SelectNewFont();
            if (font == null) { return; }
            
            m_lastFont = font;
            UpdateLabel();
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            m_fontSize = (int) fontSize.Value;
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            var label = "No Font Loaded";
            if (m_lastFont != null)
            {
                testLabel.Font = new Font(m_lastFont, m_fontSize, FontStyle.Regular, GraphicsUnit.Point, 0);
                label = $"Current Font: {m_lastFont.Name}\nFont Size: {m_fontSize}";
            }
            testLabel.Text = label;
        }
    }
}