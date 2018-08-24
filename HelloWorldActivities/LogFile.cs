using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Activities;
using System.Activities.Statements;

namespace HelloWorldActivities
{
    public class LogFile : CodeActivity
    {
        public InArgument<string> StringInput { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine("Event: {0} at {1}", StringInput.Get(context),
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") );
            }
        }
    }
}