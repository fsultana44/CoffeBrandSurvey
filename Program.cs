using System;
using static CoffeBrandSurvey.CoffeeSurveysResults;

namespace CoffeBrandSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            double respondRate;
            double unanswereSurvey;
            double overallScore;
            // calculate the result
            respondRate = QAResults.SurveyNumber / QAResults.RespondedNumber;
            unanswereSurvey = QAResults.SurveyNumber - QAResults.RespondedNumber;

            // calculaate average score for all main categories.
            overallScore = (QAResults.ServiceScore + QAResults.CoffeeTypesScore + QAResults.PriceScore + QAResults.FoodScore) /4;
            Console.WriteLine($"Respons rate: {respondRate}");
            Console.WriteLine($"Unanswered Survey: {unanswereSurvey}");
            Console.WriteLine($"Overall score for all categories: {overallScore}");

            /// do the more analysis to get the answer of the following questions
            /// For What  the score is higher (coffee/food)
            /// Score of customers recommendation.
            /// and the least and most popular products.
            /// Do it by bool expression,
            bool higherCoffeeScore = QAResults.CoffeeTypesScore > QAResults.FoodScore;
            bool customerRecommendation = QAResults.WouldRecommendScore >= 8;
            bool leastGranolaMostCappucino =QAResults.LeastFavouriteProduct == "Granola" && QAResults.FavouriteProduct == "Cappucino";
            Console.WriteLine($"Higher Coffee Score is: {higherCoffeeScore}");
            Console.WriteLine($"Customers recommendation : {customerRecommendation}");
            Console.WriteLine($"Least favourite Granola and favourite Cappucino : {leastGranolaMostCappucino}");


        }
    }
}
