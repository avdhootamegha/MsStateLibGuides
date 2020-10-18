using System;
using System.Collections.Generic;
using System.Text;

namespace LibGuides.Common
{
    public class LibGuide
    {
        public string Id { get; set; }
        public string Type_id { get; set; }
        public string Site_id { get; set; }
        public string Owner_id { get; set; }
        public string Group_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Redirect_url { get; set; }
        public string Status { get; set; }
        public string Published { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string SlugId { get; set; }
        public string FriendlyUrl { get; set; }
        public string Nav_type { get; set; }
        public string Count_hit { get; set; }
        public string Url { get; set; }
        public string Status_label { get; set; }
        public string Type_label { get; set; }
        public Owner Owner { get; set; }
    }
}
