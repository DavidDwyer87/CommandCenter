using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TabberService.Model
{
    public class MultiTabber_Err
    {
        [Key]
        public int Index { get; set; }
        public string err { get; set; }
        public string description { get; set; }
        public string date { get; set; }
    }
}