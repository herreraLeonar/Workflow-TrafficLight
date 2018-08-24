using System.Activities;
using System.IO;
using System.Activities.Statements;
using System.Collections.ObjectModel;

namespace HelloWorldActivities
{
    class StopDecision : NativeActivity
    {
               public Collection<Variable> variables;

               public StopDecision()
               {
                   this.variables = new Collection<Variable>();
               }

               public Collection<Variable> Variables
               {
                   get
                   {
                       return this.variables;
                   }
                   set { }
               }

               public Activity<bool> Condition { get; set; }

               protected override void CacheMetadata(NativeActivityMetadata metadata)
               {
                   base.CacheMetadata(metadata);

                   if (this.Condition == null)
                   {
                       metadata.AddValidationError(string.Format("Activity {0} requiere de una condición", this.DisplayName));
                       return;
                   }
                   metadata.AddImplementationChild(twf);
               }

               protected override void Execute(NativeActivityContext context)
               {
                   DoSomething(context, null);
               }

               void DoSomething(NativeActivityContext context, ActivityInstance instance)
               {
                   context.ScheduleActivity(this.Condition, new CompletionCallback<bool>(OnConditionCompleted));
               }

               void OnConditionCompleted(NativeActivityContext context, ActivityInstance instance, bool result)
               {
                   if (result)
                   {
                       //stop
                       context.ScheduleActivity(twf);
                   }
               }

               private readonly TerminateWorkflow twf = new TerminateWorkflow
               {
                   Reason = "it is time"
               };
    }
}
