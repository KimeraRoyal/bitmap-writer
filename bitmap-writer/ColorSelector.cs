using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapWriter
{
    public class ColorSelector
    {
        private ColorDialog m_colorDialog;
        
        private Color m_color;
        private string m_hex;
        
        private bool m_locked;

        public Color Color
        {
            get => m_color;
            set
            {
                m_color = value;
                if (!m_locked)
                {
                    m_locked = true;
                    Hex = "#" + m_color.R.ToString("X2") + m_color.G.ToString("X2") + m_color.B.ToString("X2");
                    m_locked = false;
                }
                OnColorUpdated?.Invoke(m_color);
            }
        }

        public string Hex
        {
            get => m_hex;
            set
            {
                m_hex = ValidateHex(value);
                if (!m_locked)
                {
                    m_locked = true;
                    Color = m_hex.Length > 1 ? ColorTranslator.FromHtml(m_hex) : Color.Black;
                    m_locked = false;
                }
                OnHexUpdated?.Invoke(m_hex);
            }
        }

        public Action<Color> OnColorUpdated;
        public Action<string> OnHexUpdated;

        public ColorSelector()
        {
            m_colorDialog = new ColorDialog();
        }

        public void SelectColour()
        {
            m_colorDialog.Color = Color;
            if(m_colorDialog.ShowDialog() != DialogResult.OK) { return; }
            Color = m_colorDialog.Color;
        }
        
        private static string ValidateHex(string _hex)
        {
            _hex = _hex.ToUpper();
            
            var hexString = "#";
            foreach (var character in _hex)
            {
                if((character < '0' || character > '9') && (character < 'A' || character > 'F')) { continue; }
                hexString += character;
            }
            return hexString;
        }
    }
}