using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word {get; set; }
    
    public RepeatCounter(string word)
    {
      Word = word;
    }
    
  }
}