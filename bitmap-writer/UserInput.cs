using System;
using System.Windows.Forms;

namespace BitmapWriter
{
    public class UserInput
    {
        private readonly TextBoxBase m_inputBox;

        public Action<string> OnTextChanged;

        public string Text
        {
            get => !string.IsNullOrEmpty(m_inputBox.Text) ? m_inputBox.Text : " ";
            set
            {
                m_inputBox.Text = value;
                OnTextChanged?.Invoke(m_inputBox.Text);
            }
        }

        public UserInput(TextBoxBase _inputBox)
        {
            m_inputBox = _inputBox;
            m_inputBox.TextChanged += TextChanged;
        }

        private void TextChanged(object _sender, EventArgs _args)
        {
            OnTextChanged?.Invoke(m_inputBox.Text);
        }
    }
}