using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageOfPhotosWebsite.Models
{
    public class PageRef
    {
        public string Slug { get; set; }
        public string Name { get; set; } // UserName
        public string Description { get; set; } // User Description
        public string UserAvatarUrl { get; set; } // UserAvatarUrl
    }
}