using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LibGuides.Common;

namespace LibGuids.Client
{
    public class LibGuidsClient
    {
        string url="";
        public LibGuidsClient(string apiUrl)
        {
            url = apiUrl; ;
        }
       
        public async Task<HttpResponseMessage> GetLibGuides()
        {
            HttpResponseMessage response = null;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(new Uri(url));

                if (response == null)
                {
                    throw new ArgumentNullException("response is null");
                }
                if (response.Content == null)
                {
                    throw new ArgumentNullException("response.Content is null");
                }

                response.EnsureSuccessStatusCode();
            }

            return response;
        }
    }

  



}
