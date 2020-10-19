using LibGuides.Common;
using LibGuides.Common.Logger;
using LibGuids.Client;
using MsStateGuides.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using static LibGuides.Common.Enum;

namespace MsStateGuides.Helpers
{
    public class LibGuidesHelper
    {
        private readonly string apiEndPoint = ConfigurationManager.AppSettings["LibGuideApiEndPoint"].ToString();
        private readonly string siteId = ConfigurationManager.AppSettings["SiteId"].ToString();
        private readonly string apiToken = ConfigurationManager.AppSettings["APIToken"].ToString();

        public async System.Threading.Tasks.Task<List<LibGuide>> GetLibGuidesAsync(LibGuidesFilter libGuidesFilter)
        {
            List<LibGuide> libGuides = new List<LibGuide>();
            try
            {
                string url = GetApiRequestUrl(libGuidesFilter, LibType.guides);
                LibGuidsClient client = new LibGuidsClient(url);
                var httpResponseMessage = await client.GetLibGuides();
                libGuides = await httpResponseMessage.Content.ReadAsAsync<List<LibGuide>>();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            return libGuides;
        }

        public async System.Threading.Tasks.Task<List<Subject>> GetLibGuidesSubjectsAsync(LibGuidesFilter libGuidesFilter)
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                string url = GetApiRequestUrl(libGuidesFilter, LibType.subjects);
                LibGuidsClient client = new LibGuidsClient(url);

                var httpResponseMessage = await client.GetLibGuides();
                subjects = await httpResponseMessage.Content.ReadAsAsync<List<Subject>>();
            }
            catch(Exception ex)
            {
                Logger.Error(ex.Message);
            }
            return subjects;
        }

        private string GetApiRequestUrl(LibGuidesFilter libGuidesFilter, LibType libType)
        {
            
            string url = apiEndPoint + "/"+ libType + "?site_id="+ siteId + "&key="  + apiToken + "&sort_by=count_hit&expand=owner&type_id=3";

            url += string.IsNullOrEmpty(libGuidesFilter.SubjectId)? string.Empty: "subject_id=" + libGuidesFilter.SubjectId;
            url += string.IsNullOrEmpty(libGuidesFilter.TypeId)? string.Empty : "type_id=" + libGuidesFilter.TypeId;

            return url;
        }
    }

  
}