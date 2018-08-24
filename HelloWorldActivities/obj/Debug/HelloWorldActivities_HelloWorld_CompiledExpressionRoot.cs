namespace HelloWorldActivities {
    
    #line 13 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 14 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 15 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 16 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 17 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\HelloWorld.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class HelloWorld : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = HelloWorld_TypedDataContext2.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = HelloWorld_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new HelloWorld_TypedDataContext2(locations, activityContext, true);
                }
                HelloWorld_TypedDataContext2 refDataContext0 = ((HelloWorld_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = HelloWorld_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new HelloWorld_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                HelloWorld_TypedDataContext2_ForReadOnly valDataContext1 = ((HelloWorld_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = HelloWorld_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new HelloWorld_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                HelloWorld_TypedDataContext2_ForReadOnly valDataContext2 = ((HelloWorld_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = HelloWorld_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new HelloWorld_TypedDataContext2(locations, activityContext, true);
                }
                HelloWorld_TypedDataContext2 refDataContext3 = ((HelloWorld_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = HelloWorld_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new HelloWorld_TypedDataContext2(locations, activityContext, true);
                }
                HelloWorld_TypedDataContext2 refDataContext4 = ((HelloWorld_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = HelloWorld_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new HelloWorld_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                HelloWorld_TypedDataContext2_ForReadOnly valDataContext5 = ((HelloWorld_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                HelloWorld_TypedDataContext2 refDataContext0 = new HelloWorld_TypedDataContext2(locations, true);
                return refDataContext0.GetLocation<string>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                HelloWorld_TypedDataContext2_ForReadOnly valDataContext1 = new HelloWorld_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                HelloWorld_TypedDataContext2_ForReadOnly valDataContext2 = new HelloWorld_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                HelloWorld_TypedDataContext2 refDataContext3 = new HelloWorld_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                HelloWorld_TypedDataContext2 refDataContext4 = new HelloWorld_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                HelloWorld_TypedDataContext2_ForReadOnly valDataContext5 = new HelloWorld_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "OutputString") 
                        && (HelloWorld_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OutputString == \"Hello\"") 
                        && (HelloWorld_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OutputString + \" World!\"") 
                        && (HelloWorld_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OutputString") 
                        && (HelloWorld_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OutputString") 
                        && (HelloWorld_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OutputString") 
                        && (HelloWorld_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new HelloWorld_TypedDataContext2(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new HelloWorld_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new HelloWorld_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new HelloWorld_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new HelloWorld_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new HelloWorld_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class HelloWorld_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public HelloWorld_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class HelloWorld_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public HelloWorld_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class HelloWorld_TypedDataContext1 : HelloWorld_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public HelloWorld_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return HelloWorld_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class HelloWorld_TypedDataContext1_ForReadOnly : HelloWorld_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public HelloWorld_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return HelloWorld_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class HelloWorld_TypedDataContext2 : HelloWorld_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public HelloWorld_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string OutputString {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 43 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          OutputString;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 43 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                return 
          OutputString;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(string value) {
                
                #line 43 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                
          OutputString = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 61 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              OutputString;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 61 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                return 
              OutputString;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 61 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                
              OutputString = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 75 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              OutputString;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 75 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                return 
              OutputString;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(string value) {
                
                #line 75 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                
              OutputString = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "OutputString") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                return HelloWorld_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class HelloWorld_TypedDataContext2_ForReadOnly : HelloWorld_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public HelloWorld_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public HelloWorld_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string OutputString {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 54 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          OutputString == "Hello";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr1Get() {
                
                #line 54 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                return 
          OutputString == "Hello";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 66 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              OutputString + " World!";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 66 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                return 
              OutputString + " World!";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 86 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        OutputString;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 86 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\HELLOWORLD.XAML"
                return 
        OutputString;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "OutputString") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                return HelloWorld_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
