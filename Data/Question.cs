using System.Collections.Generic;

namespace BlazorQuizApp.Data
{
  public class Question
  {
    public string Text { get; set; }
    public List<string> AnswerChoices{ get;set;}
    public string Answer { get; set; }

    public Question()
    {

    }
  }
}