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
			var words = _sentence.Split(new char[] {' ', '.', ','});
			int count = 0;
			foreach(var word in words)
			{
				if(_word.Equals(word))
				{
					count++;
				}
			}
			return count;
		}
	}
}