using CommandCenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TabberService.Model
{
    public class Context:DbContext
    {
        public Context():base("DefaultConnection")
        {

        }

        public DbSet<MultiTabber_Err> errLog { get; set; }
        public DbSet<MultiTabberModel> tabber { get; set; }
    }
}