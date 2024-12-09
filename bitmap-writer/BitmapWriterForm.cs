using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapWriter
{
    public partial class BitmapWriterForm : Form
    {
        private FontSelector m_fontSelector;
        private ColorSelector m_fontColorSelector;
        
        private FontFamily m_lastFont;
        private int m_fontSize = 12;
        
        public BitmapWriterForm()
        {
            InitializeComponent();
            
            m_fontSelector = new FontSelector();
            
            m_fontColorSelector = new ColorSelector();
            m_fontColorSelector.OnColorUpdated += OnFontColorUpdated;
            m_fontColorSelector.OnHexUpdated += OnFontColorHexUpdated;
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

        private void textColourHex_TextChanged(object sender, EventArgs e)
        {
            m_fontColorSelector.Hex = textColourHex.Text;
        }

        private void textColour_OnClick(object _sender, EventArgs _e)
        {
            m_fontColorSelector.SelectColour();
        }

        private void OnFontColorUpdated(Color _color)
        {
            textColour.BackColor = _color;
        }

        private void OnFontColorHexUpdated(string _obj)
        {
            textColourHex.Text = m_fontColorSelector.Hex;
        }
    }
}