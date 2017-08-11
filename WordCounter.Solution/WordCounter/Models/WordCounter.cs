using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
	public class RepeatCounter
	{
		private string _word;
		private string _sentence;
		
		public RepeatCounter(string word , string sentence)
		{
			_word = word;
			_sentence = sentence;
		}
		public string GetWord()
		{
			return _word;
		}
		public string GetSentence()
		{
			return _sentence;
		}
		public int CountRepeats()
		{
			List<int> occurences = new List<int>();
			int pos = 0;
			while ((pos < _sentence.Length) && (pos = _sentence.IndexOf(_word, pos)) != -1)
			{
				occurences.Add(pos);
				pos = pos + _word.Length;
			}
			return occurences.Count;
		}
	}
}