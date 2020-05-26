using Microsoft.ProjectOxford.Text.Sentiment;
using static TestConginitiveService_TextAnalytics.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TestConginitiveService_TextAnalytics
{
   public static class SentimentAnalyser
    {
        public static async Task<string> AnalyzeSentimentAsync(string id, string text, string language)
        {
            string result = "";
            var doucument = new SentimentDocument
            {
                Id = id,
                Language = language,
                Text =text
            };

            var client = new SentimentClient(Constants.App_Key);
            client.Url = Api_UrlSentiments;
            var request = new SentimentRequest();

            request.Documents.Add(doucument);
            try
            {
               var response =  await client.GetSentimentAsync(request);

                foreach (var item in response.Documents)
                {
                    result += string.Format("ID : " + item.Id + "  ");
                    result += string.Format("The Sentiment score for requested text is : " + Math.Round(item.Score * 100) + "%");
                }
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
