using System;
using System.Windows.Forms;
using WordCounter.Core;
using WordCounter.Interfaces;

namespace WordsCounter.WinFormsView
{
	public partial class WinFormsWordsCounterView : Form, IWordCounterView
	{
        private readonly TextBoxInputSource textBoxInputSource;

		private readonly WordCounterPresenter wordCounterPresenter;

		public WinFormsWordsCounterView()
		{
            try
            {
                InitializeComponent();

                textBoxInputSource = new TextBoxInputSource(tbInput);
                wordCounterPresenter = new WordCounterPresenter(this, textBoxInputSource);
            }
            catch (Exception exc)
            {
                ShowError(exc.Message);
            }
        }

		void IWordCounterView.DisplayWordCount(string word, int count)
		{
			lvResults.Items.Add(new ListViewItem($"{word} - {count}"));
		}

		private void btnAnalyzeText_Click(object sender, EventArgs e)
		{
            try
            {
                lvResults.Items.Clear();
                wordCounterPresenter.SetInputSource(textBoxInputSource);
                wordCounterPresenter.GetWordsCountsInText();
            }
            catch(Exception exc)
            {
                ShowError(exc.Message);
            }
		}

        private void SetTextBoxInputSource()
        {
            wordCounterPresenter.SetInputSource(textBoxInputSource);
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
	}
}
