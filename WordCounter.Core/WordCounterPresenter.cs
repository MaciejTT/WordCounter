using System;
using System.Collections.Generic;
using WordCounter.Interfaces;

namespace WordCounter.Core
{
	public class WordCounterPresenter
	{
		private readonly SentenceAnalyzer sentenceAnalyzer = new SentenceAnalyzer();
		private readonly WordCounterModel model;

		private IWordCounterView wordCounterView;

		public WordCounterPresenter(IWordCounterView wordCounterView, IInputSource inputSource)
		{
			this.wordCounterView = wordCounterView ?? throw new ArgumentNullException("wordCounterView", "wordCounterView cannot be null");
			model = new WordCounterModel(inputSource);
		}

		public void GetWordsCountsInText()
		{
			CountWordsInText();
			DisplayTextAnalysis();
            model.Reset();
        }

		public void SetInputSource(IInputSource inputSource)
		{
			model.SetInputSource(inputSource);
		}

		private void CountWordsInText()
		{
			string sentence = model.GetNextSentence();

			while (sentence != null)
			{
				AnalyzeSentence(sentence);
				sentence = model.GetNextSentence();
			}
        }

		private void DisplayTextAnalysis()
		{
			foreach (string word in model.CountedWords.Keys)
			{
				wordCounterView.DisplayWordCount(word, model.CountedWords[word]);
			}
		}
		
		private void AnalyzeSentence(string sentence)
		{
			IDictionary<string, int> countedWords = sentenceAnalyzer.CountWords(sentence);
			model.AddSentenceResult(countedWords);
		}
	}
}
