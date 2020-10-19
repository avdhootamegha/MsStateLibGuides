using LibGuides.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MsStateGuides.Models
{
    public class LibGuidesModel
    {
        public LibGuidesFilter Filter { get; set; }

        public List<LibGuide> LibGuides { get; set; }

        public List<Subject> Subjects { get; set; }

    }

    public class LibGuidesFilter
    {
        /// <summary>
        /// SubjectId
        /// </summary>
        public string SubjectId { get; set; }

        /// <summary>
        /// GroupId
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// GroupId
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        ///OwnerId
        /// </summary>
        public int OwnerId { get; set; }
    }
}