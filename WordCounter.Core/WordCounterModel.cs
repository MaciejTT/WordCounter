using System;
using System.Collections.Generic;
using WordCounter.Interfaces;

namespace WordCounter.Core
{
	public class WordCounterModel
	{
		private readonly IDictionary<string, int> countedWords = new Dictionary<string, int>();

		private IInputSource inputSource;

		public IDictionary<string, int> CountedWords => countedWords;

		public WordCounterModel(IInputSource inputSource)
		{
			SetInputSource(inputSource);			
		}

		public string GetNextSentence()
		{
			return inputSource.ReadNextSentence();
		}

		public void AddSentenceResult(IDictionary<string, int> sentenceResult)
		{
			foreach (string word in sentenceResult.Keys)
			{
				if (countedWords.ContainsKey(word))
				{
					countedWords[word] += sentenceResult[word];
				}
				else
				{
					countedWords.Add(word, sentenceResult[word]);
				}
			}
		}

		public void SetInputSource(IInputSource inputSource)
		{
			this.inputSource = inputSource ?? throw new ArgumentNullException("inputSource", "InputSource cannot be null");
			Reset();
		}

		public void Reset()
		{
			inputSource.Reset();
			countedWords.Clear();
		}
	}
}
