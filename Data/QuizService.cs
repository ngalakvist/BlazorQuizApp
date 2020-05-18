using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQuizApp.Data
{
  public class QuizService
  {
    public static readonly Question[] Questions = new[] {

           new Question{Text ="Whats the Capital of Sweden ?",AnswerChoices = new List<string>{"Stockholm", "Oslo","Helsingborg","Göteborg"  }, Answer="Stockholm" },
           new Question{Text ="Whats the Capital of England?",AnswerChoices = new List<string>{"Stockholm", "Oslo","London","Göteborg"   }, Answer="London" }, 
           new Question{ Text ="Whats the Capital of Norway ?",AnswerChoices = new List<string>{"Stockholm", "Oslo","Helsingborg","Göteborg"   }, Answer="Oslo"},
           new Question{Text ="Who lost one million subscribers in one day on Youtube ?",AnswerChoices = new List<string>{"Alison Park", "Peter Touch", "Viman Marker", "James Charles"   }, Answer="James Charles" },
           new Question{Text ="What is Tik-tok?",AnswerChoices = new List<string>{"Animal", "Oslo","An App","Person"}, Answer="An App" }
       };
  }
}
