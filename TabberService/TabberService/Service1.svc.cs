using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TabberService.Model;

namespace TabberService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void reguser(string _email)
        {
            try
            {
                var ctx = new Context();
                var exist = ctx.tabber.FirstOrDefault(m => m.email == _email);

                if(exist == null)
                {
                    ctx.tabber.Add(new CommandCenter.Models.MultiTabberModel { 
                        ActiveCount = 1,
                        email = _email,
                        lastused = DateTime.Now.ToShortDateString()
                    });
                    ctx.SaveChanges();
                }
                else
                {
                    exist.ActiveCount++;
                    ctx.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                var ctx = new Context();

                ctx.errLog.Add(new MultiTabber_Err
                {
                    date = DateTime.Now.ToShortDateString(),
                    description = ex.InnerException.Message,
                    err = "Service - "+ex.Message                    
                });

                ctx.SaveChanges();
            }
        }


        public void activeUser(string _email)
        {
            try
            {
                var ctx = new Context();

                var exist = ctx.tabber.FirstOrDefault(m => m.email == _email);

                if(exist !=null)
                {
                    exist.ActiveCount++;
                    ctx.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                var ctx = new Context();

                ctx.errLog.Add(new MultiTabber_Err
                {
                    date = DateTime.Now.ToShortDateString(),
                    description = ex.InnerException.Message,
                    err = "Service - " + ex.Message
                });

                ctx.SaveChanges();
            }
        }
    }
}
