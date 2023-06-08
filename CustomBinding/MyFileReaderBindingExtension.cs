using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using System;

namespace CustomBinding
{
    public static class MyFileReaderBindingExtension
    {
        public static IWebJobsBuilder AddMyFileReaderBinding(this IWebJobsBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.AddExtension<MyFileReaderBinding>();
            return builder;
        }
    }
}
