using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommandCenter.Models
{
    public class MultiTabberModel
    {
        [Key]
        public int Index { get; set; }
        public string email { get; set; }
        public string lastused { get; set; }
        public int ActiveCount { get; set; }
    }
}