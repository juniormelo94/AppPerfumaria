using Google.GenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppPerfumaria.Api.GemineAI
{
    public class GeminiAI
    {
        const string _api_key = "AIzaSyD-lKfSx82eKn5S0Ml_go26-JwNxgjPg1A";

        public async Task<string> GenerateContent(object content)
        {
            var json = JsonSerializer.Serialize(content);

            // The client gets the API key from the environment variable `GEMINI_API_KEY`.
            var client = new Client(apiKey: _api_key);
            var response = await client.Models.GenerateContentAsync(
                model: "gemini-3-flash-preview", 
                contents: json
            );

           return response.Candidates[0].Content.Parts[0].Text;


            //var result = await response.Content.ReadAsStringAsync();

            //var data = JsonSerializer.Deserialize<GeminiResponse>(result);
        }
    }
}
