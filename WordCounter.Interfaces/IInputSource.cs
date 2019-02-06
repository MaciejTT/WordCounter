namespace WordCounter.Interfaces
{
	public interface IInputSource
	{
		string ReadNextSentence();

		void Reset();
	}
}
