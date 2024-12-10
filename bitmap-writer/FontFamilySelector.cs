using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace BitmapWriter
{
    public class FontFamilySelector
    {
        private Label m_results;
        
        private readonly OpenFileDialog m_loadFontDialog;
        
        private readonly PrivateFontCollection m_fontCollection;
        private readonly Dictionary<string, string> m_fontNameLookup;

        public FontFamilySelector(Label _results)
        {
            m_results = _results;
            
            m_loadFontDialog = new OpenFileDialog()
            {
                FileName = "Select a font",
                Filter = "Font files (*.ttf)|*.ttf",
                Title = "Select font file"
            };

            m_fontNameLookup = new Dictionary<string, string>();
            m_fontCollection = new PrivateFontCollection();
        }

        public FontFamily SelectNewFont()
        {
            var loadResults = m_loadFontDialog.ShowDialog();
            if (loadResults != DialogResult.OK)
            {
                m_results.Text = $"Failed to load font:\nLoad dialog results: \"{loadResults}\"";
                return null;
            }

            var fontPath = m_loadFontDialog.FileName;
            
            var font = LookupFont(fontPath);
            if (font != null)
            {
                m_results.Text = $"Successfully loaded font \"{font.Name}\".";
                return font;
            }

            var previousFamilies = m_fontCollection.Families;
            m_fontCollection.AddFontFile(fontPath);
            if (m_fontCollection.Families.Length == previousFamilies.Length)
            {
                m_results.Text = $"Failed to load font:\nCouldn't add font to collection.";
                return null;
            }

            var newFonts = m_fontCollection.Families.Except(previousFamilies).ToArray();
            m_fontNameLookup.Add(fontPath, newFonts[0].Name);
            
            m_results.Text = $"Successfully loaded font \"{newFonts[0].Name}\".";
            return newFonts[0];
        }

        private FontFamily LookupFont(string _path)
        {
            if (!m_fontNameLookup.TryGetValue(_path, out var name)) { return null; }
            return m_fontCollection.Families.FirstOrDefault(_font => _font.Name == name);
        }
    }
}