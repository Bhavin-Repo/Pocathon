using Microsoft.ProjectOxford.Text.KeyPhrase;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TestConginitiveService_TextAnalytics
{
    public static class KeyPhraseAnalyser
    {
        public static async Task<string> AnalyzeKeyPhrases(string id, string text, string language)
        {
            string result = "";
            var document = new KeyPhraseDocument
            {
                Id = id,
                Text = text,
                Language = language
            };

            var client = new KeyPhraseClient(Constants.App_Key)
            {
                Url = Constants.Api_UrlKeyPhrases
            };

            var request = new KeyPhraseRequest();
            request.Documents.Add(document);

            try
            {
                var response = await client.GetKeyPhrasesAsync(request);
                foreach(var item in response.Documents)
                {
                    result += string.Format("ID : "+item.Id+"\n");
                    result += string.Format("Key phrases are : " +string.Join(",",item.KeyPhrases)+"\n");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}