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
        
        private FontFamilySelector m_fontFamilySelector;
        private ColorSelector m_fontColorSelector;

        private UserInput m_userInput;
        
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
            
            m_fontFamilySelector = new FontFamilySelector();
            
            m_fontColorSelector = new ColorSelector();
            m_fontColorSelector.OnColorUpdated += OnFontColorUpdated;
            m_fontColorSelector.OnHexUpdated += OnFontColorHexUpdated;
            m_fontColorSelector.Color = Color.White;

            textColour.Click += textColour_OnClick;

            m_userInput = new UserInput(userInput);
            m_userInput.OnTextChanged += OnUserInputChanged;
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

        private void DrawBitmap(Color _backgroundColor)
        {
            if(m_bitmap == null || m_bitmap.Height < m_fontSize) { return; }

            var graphics = GetFontGraphics(m_bitmap);
            
            graphics.Clear(_backgroundColor);
            var rect = new Rectangle(
                m_paddingLeft,
                m_paddingTop,
                m_bitmap.Width - m_paddingLeft - m_paddingRight,
                m_bitmap.Height - m_paddingTop - m_paddingBottom);
            graphics.DrawString(userInput.Text.Trim(), m_font, new SolidBrush(m_fontColorSelector.Color), rect);
            
            graphics.Flush();

            preview.Image = m_bitmap;
        }

        private void RegenerateBitmap()
        {
            if(m_fontFamily == null) { return; }
            
            var graphics = GetFontGraphics(m_bitmap);
            var size = graphics.MeasureString(m_userInput.Text, m_font);
            
            m_bitmap?.Dispose();
            m_bitmap = new Bitmap((int) size.Width + m_paddingLeft + m_paddingRight + 1, (int) size.Height + m_paddingTop + m_paddingBottom);
            m_bitmap.MakeTransparent();

            DrawBitmap(GetBackgroundColor());
        }

        private Color GetBackgroundColor()
        {
            var average = (m_fontColorSelector.Color.R + m_fontColorSelector.Color.G + m_fontColorSelector.Color.B) / 3;
            return average >= 128 ? Color.Black: Color.White;
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

        private void OnFontColorUpdated(Color _color)
        {
            textColour.BackColor = _color;
            DrawBitmap(GetBackgroundColor());
        }

        private void OnFontColorHexUpdated(string _obj)
        {
            textColourHex.Text = m_fontColorSelector.Hex;
        }

        private void OnUserInputChanged(string _text)
        {
            RegenerateBitmap();
        }

        private void loadFontButton_Click(object sender, EventArgs e)
        {
            var fontFamily = m_fontFamilySelector.SelectNewFont();
            
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

        private void textColourHex_TextChanged(object sender, EventArgs e)
        {
            m_fontColorSelector.Hex = textColourHex.Text;
        }

        private void textColour_OnClick(object _sender, EventArgs _e)
        {
            m_fontColorSelector.SelectColour();
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

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if(m_bitmap == null || m_bitmap.Height < m_fontSize) { return; }
            
            var saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
            
            m_bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
        }
    }
}