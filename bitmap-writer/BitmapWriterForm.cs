using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace BitmapWriter
{
    public partial class BitmapWriterForm : Form
    {
        private Bitmap m_preview;
        private Bitmap m_output;
        
        private FontFamilySelector m_fontFamilySelector;
        private ColorSelector m_fontColorSelector;

        private UserInput m_userInput;
        
        private FontFamily m_fontFamily;
        private Font m_font;
        private int m_fontSize = 12;

        private int m_paddingLeft, m_paddingRight, m_paddingTop, m_paddingBottom;
        
        public BitmapWriterForm()
        {
            InitializeComponent();

            m_preview = new Bitmap(1, 1);
            
            m_fontFamilySelector = new FontFamilySelector(fontResults);
            
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

        private void UpdatePreview()
        {
            DrawToBitmap(m_preview, GetBackgroundColor());
            preview.Image = m_preview;
        }

        private void DrawToBitmap(Bitmap _target, Color _backgroundColor)
        {
            if(m_font == null || _target == null || _target.Height < 1) { return; }

            var graphics = GetFontGraphics(_target);
            
            graphics.Clear(_backgroundColor);
            var rect = new Rectangle(
                m_paddingLeft,
                m_paddingTop,
                _target.Width - m_paddingLeft - m_paddingRight,
                _target.Height - m_paddingTop - m_paddingBottom);
            graphics.DrawString(userInput.Text.Trim(), m_font, new SolidBrush(m_fontColorSelector.Color), rect);
            
            graphics.Flush();
        }

        private void RegenerateBitmaps()
        {
            if(m_fontFamily == null) { return; }

            var size = GetTextSize();
            
            m_preview?.Dispose();
            m_preview = new Bitmap(size.Width, size.Height);
            UpdatePreview();
            
            m_output?.Dispose();
            m_output = new Bitmap(size.Width, size.Height);
            m_output.MakeTransparent();
        }

        private Size GetTextSize()
        {
            var graphics = GetFontGraphics(m_preview);
            var size = graphics.MeasureString(m_userInput.Text, m_font);
            return new Size((int)size.Width + m_paddingLeft + m_paddingRight + 1, (int)size.Height + m_paddingTop + m_paddingBottom);
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
            UpdatePreview();
        }

        private void OnFontColorHexUpdated(string _obj)
        {
            textColourHex.Text = m_fontColorSelector.Hex;
        }

        private void OnUserInputChanged(string _text)
        {
            RegenerateBitmaps();
        }

        private void loadFontButton_Click(object sender, EventArgs e)
        {
            var fontFamily = m_fontFamilySelector.SelectNewFont();
            
            if (fontFamily == null) { return; }
            
            m_fontFamily = fontFamily;
            
            UpdateFont();
            RegenerateBitmaps();
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            m_fontSize = (int) fontSize.Value;
            UpdateFont();
            RegenerateBitmaps();
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
            RegenerateBitmaps();
        }

        private void paddingTop_ValueChanged(object sender, EventArgs e)
        {
            m_paddingTop = (int) paddingTop.Value;
            RegenerateBitmaps();
        }

        private void paddingRight_ValueChanged(object sender, EventArgs e)
        {
            m_paddingRight = (int) paddingRight.Value;
            RegenerateBitmaps();
        }

        private void paddingBottom_ValueChanged(object sender, EventArgs e)
        {
            m_paddingBottom = (int) paddingBottom.Value;
            RegenerateBitmaps();
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (m_font == null)
            {
                saveResults.Text = "Failed to save:\nNo font assigned.";
                return;
            }
            if (m_output == null)
            {
                saveResults.Text = "Failed to save:\nInvalid output.";
                return;
            }
            
            var saveFileDialog = new SaveFileDialog();
            var saveResult = saveFileDialog.ShowDialog();
            if (saveResult != DialogResult.OK)
            {
                saveResults.Text = $"Failed to save:\nSave dialog result: {saveResult}";
                return;
            }
            
            DrawToBitmap(m_output, Color.Transparent);
            m_output.Save(saveFileDialog.FileName, ImageFormat.Png);
            saveResults.Text = $"Saved to \"{Path.GetFileName(saveFileDialog.FileName)}\"";
        }

        private void credits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            credits.LinkVisited = true;
            Process.Start("https://kimera.world");
        }
    }
}