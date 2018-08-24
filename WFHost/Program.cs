using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Threading;
using HelloWorldActivities;
using System.Collections.Generic;

namespace WFHost
{

    class Program
    {
        
        static void Main(string[] args)
        {
           var parameters = new Dictionary<string, object>();
            CommonClass cc = new CommonClass();
            parameters.Add("iRedLightDelay", cc.RedLightDelay);
            parameters.Add("iGreenLightDelay", cc.GreenLightDelay);
            parameters.Add("iYellowLightDelay",cc.YellowLightDelay);

            WorkflowInvoker.Invoke(new TrafficLight(), parameters);
            Console.ReadKey();
        }
    }
}
