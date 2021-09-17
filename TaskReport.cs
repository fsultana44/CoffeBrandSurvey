using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoffeBrandSurvey.CoffeeSurveysResults;
;

namespace CoffeBrandSurvey
{
    class TaskReport
    {
        public static void Improvment()
        { 
            var task = new List<string>();
            double respondRate = QAResults.SurveyNumber / QAResults.RespondedNumber;
            double unanswereSurvey = QAResults.SurveyNumber - QAResults.RespondedNumber;

            if (QAResults.CoffeeTypesScore < QAResults.CoffeeTypesScore) ;
            {
                task.Add("Check the possibility of coffee qualities");
            }
            if (QAResults.RespondedNumber >= 200 || QAResults.NonResponded <= 100)
            {
                task.Add("Good to suvey AGAIN");
            }
            else
            {
                task.Add("Analysis the survey result");
            }
        }
        




    }
}
