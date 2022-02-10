using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace coop_builder
{
    public static class RestUtil
    {
        public static async Task<string> GetAsync(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result;
                }
            }

            return null;
        }

        public static string SloppyExtract(string json, string field)
        {
            json = json.Replace(" ", "");

            string fieldJson = "\"" + field + "\":";
            if (!json.Contains(fieldJson)) { return null; }

            string after = json.Split(new string[] { fieldJson }, 2, StringSplitOptions.RemoveEmptyEntries)[1];
            string[] valueSplit = after.Split('"');
            if (valueSplit.Count() < 2) { return null; }

            return valueSplit[1];
        }

        public static async Task<string> GetSloppyAsync(string url, string parameter)
        {
            string jsonString = await GetAsync(url);
            if (jsonString == null) { return null; }

            return SloppyExtract(jsonString, parameter);
        }
    }
}
