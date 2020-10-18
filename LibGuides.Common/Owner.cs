using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibGuides.Common
{
    public class Owner
    {
        public string Id { get; set; }

        [JsonProperty("first_name")] 
        public string FirstName { get; set; }




        public string LastName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Nickname { get; set; }
        public string Signature { get; set; }
        public string CreatedBy { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
    }
}
