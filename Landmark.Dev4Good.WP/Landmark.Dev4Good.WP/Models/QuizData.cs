using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Landmark.Dev4Good.WP.Models
{
    public class QuizData
    {
        public List<QuizItem> GetQuizItems()
        {
            XDocument loadedData = XDocument.Load("data/QuizQuestionsv1.xml");

            var data = from query in loadedData.Descendants("QuizItem")
                       select new QuizItem
                       {
                           Id = (string)query.Element("id"),
                           Question = (string)query.Element("question"),
                           A = (string)query.Element("a"),
                           B = (string)query.Element("b"),
                           C = (string)query.Element("c"),
                           D = (string)query.Element("d"),
                           Answer = (string)query.Element("answer"),
                           Information = (string)query.Element("information"),
                       };
            return  data.ToList();
        }
    }
    
}
