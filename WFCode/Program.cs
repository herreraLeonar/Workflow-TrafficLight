using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WFCode
{

    class Program
    {
        static void Main(string[] args)
        {
            Variable<string> OutputString = new Variable<string>{
                Name = "OutputStrings"
            };
            Activity workflow1 = new Sequence
            {
                Variables = { OutputString },
                Activities = {
                    new Assign<string>
                    {
                        To = OutputString,
                        Value = "Hello"
                    },
                    new Delay {
                        Duration = new TimeSpan(0,0,1)
                    },
                    new If
                    {
                        Condition = new InArgument<bool>((env) => OutputString.Get(env)=="Hello"),
                        Then = new Assign<string>
                        {
                            To = OutputString,
                            Value = new InArgument<string>((env)=>OutputString.Get(env)+" World!")
                        },
                        Else= new Assign<string>{
                            To = OutputString,
                            Value = "Impossible!"
                        }
                    },
                    new WriteLine
                    {
                        Text = new InArgument<string>((env)=> OutputString.Get(env))
                    }
                }
            };
            WorkflowInvoker.Invoke(workflow1);
            Console.ReadKey();
        }
    }
}
