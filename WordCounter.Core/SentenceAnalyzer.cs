using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Core
{
	public class SentenceAnalyzer
	{
		private readonly char[] separators = new[] { '\\', '/', '.', ',', ';', ':', '?', '!' };

		private IEnumerable<string> SplitWords(string sentence)
		{
			IEnumerable<string> words = sentence.Split();
			words = words.SelectMany(w => w.Split(separators, StringSplitOptions.RemoveEmptyEntries));
            words = words.Where(w => w.Any(char.IsLetter));
			return words;
		}

		public IDictionary<string, int> CountWords(string sentence)
		{
			IEnumerable<string> words = SplitWords(sentence);
			IEnumerable<IGrouping<string, string>> groupedWords = words.GroupBy(w => w.ToLower());
			Dictionary<string, int> countedWords = groupedWords.ToDictionary(g => g.Key, g => g.Count());

			return countedWords;
		}
	}
}
