using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TamagotchiApp
{
    class RestApiHandler
    {
        HttpClient client = new HttpClient();

        public RestApiHandler(string base_url)
        {
            client.Timeout = new TimeSpan(0, 0, 50);
            client.BaseAddress = new Uri(base_url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public Account[] GetUser(string path)
        {
            Account[] retval = null;
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                retval = JsonSerializer.Deserialize<Account[]>(str);
            }
            return retval;
        }
        public Account PostUser(string path,Dictionary<string,string> values)
        {

            FormUrlEncodedContent content = new FormUrlEncodedContent(values);
            Account retval = null;
            HttpResponseMessage response = client.PostAsync(path, content).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                retval = JsonSerializer.Deserialize<Account>(str);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", retval.data.token);
            }
            return retval;
        }
        public Animal PostAnimal(string path, Dictionary<string, string> values)
        {

            FormUrlEncodedContent content = new FormUrlEncodedContent(values);
            Animal retval = null;
            HttpResponseMessage response = client.PostAsync(path, content).Result;
            if (response.IsSuccessStatusCode)
            {
                string str = response.Content.ReadAsStringAsync().Result;
                retval = JsonSerializer.Deserialize<Animal>(str);
            }
            return retval;
        }
    }
}
