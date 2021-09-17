using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeBrandSurvey
{
    class CoffeeSurveysResults
    {
        static public class QAResults
        {   /// <Score determine by number.summary>
        /// 
        /// </summary>
            public static double ServiceScore { get; set; } = 8.0;
            public static double CoffeeTypesScore { get; set; } = 8.5;
            public static double PriceScore { get; set; } = 6.0;
            public static double FoodScore { get; set; } = 8.0;
            public static double WouldRecommendScore { get; set; } = 8.0;
            public static string FavouriteProduct { get; set; } = Cappucino;
            public static string LeastFavouriteProduct { get; set; } = Granola;

            //Survey count
            public static float SurveyNumber { get; set; } = 500;
            public static float RespondedNumber { get; set; } = 300;
            public static float NonResponded { get; set; } = 200;
            public static float RewardNumber { get; set; } = 100;
            public static string Granola { get; private set; }
            public static string Cappucino { get; private set; }
        }
    }
}
