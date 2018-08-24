using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Activities;
using System.IO;
using System.Activities.Statements;

namespace HelloWorldActivities
{
    public class CommonClass// : CodeActivity<int>
    {
        //aplica para argumentos de entrada en TrafficLight.xaml al pasar paraments
        public int RedLightDelay { get; set; }
        public int GreenLightDelay { get; set; }
        public int YellowLightDelay { get; set; }
        public CommonClass()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/Users/Leonar/source/repos/Wf-HelloWorld/HelloWorldActivities/TrafficRules.xml");
            RedLightDelay = int.Parse(doc.ChildNodes[1].ChildNodes[0].InnerText);
            GreenLightDelay = int.Parse(doc.ChildNodes[1].ChildNodes[1].InnerText);
            YellowLightDelay = int.Parse(doc.ChildNodes[1].ChildNodes[2].InnerText);
        }

  /*      protected override int Execute(CodeActivityContext context)
        {
            throw new NotImplementedException();
        }*/
    }
}
