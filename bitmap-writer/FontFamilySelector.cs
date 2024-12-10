using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace BitmapWriter
{
    public class FontFamilySelector
    {
        private readonly OpenFileDialog m_loadFontDialog;
        
        private readonly PrivateFontCollection m_fontCollection;
        private readonly Dictionary<string, string> m_fontNameLookup;

        public FontFamilySelector()
        {
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
            if (m_loadFontDialog.ShowDialog() != DialogResult.OK) { return null; }

            var fontPath = m_loadFontDialog.FileName;
            
            var font = LookupFont(fontPath);
            if (font != null) { return font; }

            var previousFamilies = m_fontCollection.Families;
            m_fontCollection.AddFontFile(fontPath);
            if (m_fontCollection.Families.Length == previousFamilies.Length) { return null; }

            var newFonts = m_fontCollection.Families.Except(previousFamilies).ToArray();
            m_fontNameLookup.Add(fontPath, newFonts[0].Name);
            return newFonts[0];
        }

        private FontFamily LookupFont(string _path)
        {
            if (!m_fontNameLookup.TryGetValue(_path, out var name)) { return null; }
            return m_fontCollection.Families.FirstOrDefault(_font => _font.Name == name);
        }
    }
}