using System;
using WordCounter.Interfaces;

namespace WordCounter.ConsoleView
{
	public class ConsoleInputSource : IInputSource
	{
		private bool processed = false;

		public string ReadNextSentence()
		{
			if (processed)
			{
				return null;
			}

			processed = true;
			Console.WriteLine("Please provide a sentence:");
			return Console.ReadLine();
		}

		public void Reset()
		{
			processed = false;
		}
	}
}
