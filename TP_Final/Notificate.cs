using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;


namespace TP_Final
{
    class Notificate : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Task notificate = Task.Factory.StartNew(() => {LibraryManager.Notificate(); });
            return notificate; 
        }
    }
}
