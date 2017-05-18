using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testmvc5.Models
{
    public class SearchRequest
    {
        public int SearchRequestId { get; set; }
        public string RequestString { get; set; }
        public DateTime RequestDate { set; get; }
    }
}