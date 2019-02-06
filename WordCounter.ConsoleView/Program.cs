using System;
using WordCounter.Core;

namespace WordCounter.ConsoleView
{
	class Program
	{
		static void Main(string[] args)
		{
            try
            {
                var consoleWordCounterView = new ConsoleWordCounterView();
                var consoleInputSource = new ConsoleInputSource();
                var wordCounterPresenter = new WordCounterPresenter(consoleWordCounterView, consoleInputSource);

                wordCounterPresenter.GetWordsCountsInText();
            }
            catch(Exception exc)
            {
                Console.WriteLine($"ERROR: {exc.Message}");
            }
            finally
            {
                Console.ReadKey();
            }
		}
	}
}
