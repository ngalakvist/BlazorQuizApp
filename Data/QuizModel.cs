using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQuizApp.Data
{
  public class QuizModel
  {
    List<Question> QuestionsList { get; set; }
    public int Score { get; set; }
  }
}
