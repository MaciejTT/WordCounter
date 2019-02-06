using System;
using WordCounter.Interfaces;

namespace WordCounter.ConsoleView
{
	public class ConsoleWordCounterView : IWordCounterView
	{
		public void DisplayWordCount(string word, int count) => Console.WriteLine($"{word} - {count}");
	}
}
