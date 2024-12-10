using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BitmapWriter
{
    public partial class BitmapWriterForm : Form
    {
        private Bitmap m_bitmap;
        
        private FontSelector m_fontSelector;
        private ColorSelector m_fontColorSelector;

        private string m_input;
        private int m_maxLineLength;
        private int m_lineCount;
        
        private FontFamily m_fontFamily;
        private Font m_font;
        private int m_fontSize = 12;

        private int m_paddingLeft, m_paddingRight, m_paddingTop, m_paddingBottom;
        private int m_characterSpacing;
        private int m_lineSpacing;
        
        public BitmapWriterForm()
        {
            InitializeComponent();

            m_bitmap = new Bitmap(1, 1);
            
            m_fontSelector = new FontSelector();
            
            m_fontColorSelector = new ColorSelector();
            m_fontColorSelector.OnColorUpdated += OnFontColorUpdated;
            m_fontColorSelector.OnHexUpdated += OnFontColorHexUpdated;
            m_fontColorSelector.Color = Color.White;
            
            m_input = userInput.Text;
            CountCharacters();
        }

        private void loadFontButton_Click(object sender, EventArgs e)
        {
            var fontFamily = m_fontSelector.SelectNewFont();
            
            if (fontFamily == null) { return; }
            
            m_fontFamily = fontFamily;
            
            UpdateFont();
            RegenerateBitmap();
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            m_fontSize = (int) fontSize.Value;
            UpdateFont();
            RegenerateBitmap();
        }

        private void UpdateFont()
        {
            var label = "No Font Loaded";
            if (m_fontFamily != null)
            {
                m_font = new Font(m_fontFamily, m_fontSize, FontStyle.Regular, GraphicsUnit.Pixel, 0);
                testLabel.Font = m_font;
                label = $"Current Font: {m_fontFamily.Name}\nFont Size: {m_fontSize}";
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
            DrawBitmap();
        }

        private void OnFontColorHexUpdated(string _obj)
        {
            textColourHex.Text = m_fontColorSelector.Hex;
        }

        private void paddingLeft_ValueChanged(object sender, EventArgs e)
        {
            m_paddingLeft = (int) paddingLeft.Value;
            RegenerateBitmap();
        }

        private void paddingTop_ValueChanged(object sender, EventArgs e)
        {
            m_paddingTop = (int) paddingTop.Value;
            RegenerateBitmap();
        }

        private void paddingRight_ValueChanged(object sender, EventArgs e)
        {
            m_paddingRight = (int) paddingRight.Value;
            RegenerateBitmap();
        }

        private void paddingBottom_ValueChanged(object sender, EventArgs e)
        {
            m_paddingBottom = (int) paddingBottom.Value;
            RegenerateBitmap();
        }

        private void characterSpacing_ValueChanged(object sender, EventArgs e)
        {
            m_characterSpacing = (int) characterSpacing.Value;
        }

        private void lineSpacing_ValueChanged(object sender, EventArgs e)
        {
            m_lineSpacing = (int) lineSpacing.Value;
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            m_input = userInput.Text;

            CountCharacters();
            DrawBitmap();
        }

        private void DrawBitmap()
        {
            if(m_bitmap == null || m_bitmap.Height < m_fontSize) { return; }

            var graphics = GetFontGraphics(m_bitmap);
            
            graphics.Clear(Color.Transparent);
            var rect = new Rectangle(
                m_paddingLeft,
                m_paddingTop,
                m_bitmap.Width - m_paddingLeft - m_paddingRight,
                m_bitmap.Height - m_paddingTop - m_paddingBottom);
            graphics.DrawString(userInput.Text, m_font, new SolidBrush(m_fontColorSelector.Color), rect);
            
            graphics.Flush();

            preview.Image = m_bitmap;
        }

        private void CountCharacters()
        {
            var previousLineCount = m_lineCount;
            var previousMaxLineLength = m_maxLineLength;

            m_lineCount = 1;
            m_maxLineLength = 0;
            var lineLength = 0;
            
            foreach (var character in m_input)
            {
                if (character == '\n')
                {
                    m_maxLineLength = Math.Max(m_maxLineLength, lineLength);
                    m_lineCount++;
                    
                    continue;
                }
                lineLength++;
            }
            m_maxLineLength = Math.Max(m_maxLineLength, lineLength);

            if (m_lineCount != previousLineCount || m_maxLineLength != previousMaxLineLength)
            {
                RegenerateBitmap();
            }
        }

        private void RegenerateBitmap()
        {
            if(m_fontFamily == null) { return; }
            
            var graphics = GetFontGraphics(m_bitmap);
            var width = (int) graphics.MeasureString(m_input, m_font).Width;
            
            m_bitmap?.Dispose();
            m_bitmap = new Bitmap(width + m_paddingLeft + m_paddingRight + 1, m_fontSize * m_lineCount + m_paddingTop + m_paddingBottom);
            m_bitmap.MakeTransparent();

            DrawBitmap();
        }

        private static Graphics GetFontGraphics(Bitmap _bitmap)
        {
            var graphics = Graphics.FromImage(_bitmap);

            graphics.SmoothingMode = SmoothingMode.None;
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            graphics.PixelOffsetMode = PixelOffsetMode.None;
            graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;

            return graphics;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if(m_bitmap == null || m_bitmap.Height < m_fontSize) { return; }
            
            var saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
            
            m_bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
        }
    }
}