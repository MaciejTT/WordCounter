using System.Windows.Forms;
using WordCounter.Interfaces;

namespace WordsCounter.WinFormsView
{
    public class TextBoxInputSource : IInputSource
    {
        private int currentLine = 0;

        private readonly TextBox inputTextBox;

        public TextBoxInputSource(TextBox inputTextBox)
        {
            this.inputTextBox = inputTextBox;
        }

        string IInputSource.ReadNextSentence()
        {
            return currentLine < inputTextBox.Lines.Length
                ? inputTextBox.Lines[currentLine++]
                : null;
        }

        void IInputSource.Reset()
        {
            currentLine = 0;
        }
    }
}
