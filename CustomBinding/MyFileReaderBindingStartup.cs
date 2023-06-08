using CustomBinding;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: WebJobsStartup(typeof(MyFileReaderBindingStartup))]
namespace CustomBinding
{
    public class MyFileReaderBindingStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddMyFileReaderBinding();
        }
    }
}
