using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using Microsoft.Azure.WebJobs.Host.Bindings;
using System.Reflection.Metadata;

namespace CustomBinding
{
    [Extension("MyFileReaderBinding")]
    public class MyFileReaderBinding : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            var rule = context.AddBindingRule<MyFileReaderBindingAttribute>();
            rule.BindToInput<MyFileReaderModel>(BuildItemFromAttribute);
        }

        private MyFileReaderModel BuildItemFromAttribute(MyFileReaderBindingAttribute arg)
        {
            string content = string.Empty;
            if (File.Exists(arg.Location))
            {
                content = File.ReadAllText(arg.Location);
            }

            return new MyFileReaderModel
            {
                FullFilePath = arg.Location,
                Content = content
            };
        }
    }
}
