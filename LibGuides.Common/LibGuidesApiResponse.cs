using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LibGuides.Common
{
    public class LibGuidesApiResponse
    {

        /// <summary>
        /// Holds Succes/Error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Status Code
        /// </summary>
        public HttpStatusCode StatusCode;

        public List<LibGuide> Result { get; set; }
        public LibGuidesApiResponse()
        {

        }


        public LibGuidesApiResponse(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
        }


    }
}
