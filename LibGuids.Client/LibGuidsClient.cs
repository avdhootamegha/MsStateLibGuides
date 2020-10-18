using System;
using System.Collections.Generic;
using System.Net;
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
            url = apiUrl + "?site_id=8488&key=0b8da796b00334ae3471f60e6a10e8c6&sort_by=count_hit&expand=owner"; ;
        }
       
        //url = url 
        /// <summary>
        /// For getting the resources from a web api
        /// </summary>
        /// <param name="url">API Url</param>
        /// <returns>A Task with result object of type T</returns>
        public async Task<LibGuidesApiResponse> Get()
        {
            LibGuidesApiResponse apiResponse = new LibGuidesApiResponse();
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(new Uri(url)).Result;

                response.EnsureSuccessStatusCode();
                apiResponse.StatusCode = response.StatusCode;
                apiResponse.Result = await response.Content.ReadAsAsync<List<LibGuide>>();
                //result = await response.Content.ReadAsAsync<LibGuidesApiResponse>();
            }

            return apiResponse;
        }
    }

  



}
