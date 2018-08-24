namespace HelloWorldActivities {
    
    #line 23 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 28 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 30 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 29 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.ServiceModel.Dispatcher;
    
    #line default
    #line hidden
    
    #line 31 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.ServiceModel;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\Leonar\source\repos\Wf-HelloWorld\HelloWorldActivities\TrafficLight.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class TrafficLight : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = TrafficLight_TypedDataContext4.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TrafficLight_TypedDataContext4(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext4 refDataContext0 = ((TrafficLight_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new TrafficLight_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext4_ForReadOnly valDataContext1 = ((TrafficLight_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new TrafficLight_TypedDataContext4(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext4 refDataContext2 = ((TrafficLight_TypedDataContext4)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new TrafficLight_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext4_ForReadOnly valDataContext3 = ((TrafficLight_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new TrafficLight_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext4_ForReadOnly valDataContext4 = ((TrafficLight_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TrafficLight_TypedDataContext5(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext5 refDataContext5 = ((TrafficLight_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new TrafficLight_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext5_ForReadOnly valDataContext6 = ((TrafficLight_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new TrafficLight_TypedDataContext5(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext5 refDataContext7 = ((TrafficLight_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new TrafficLight_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext5_ForReadOnly valDataContext8 = ((TrafficLight_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new TrafficLight_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext5_ForReadOnly valDataContext9 = ((TrafficLight_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TrafficLight_TypedDataContext6(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext6 refDataContext10 = ((TrafficLight_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext10.GetLocation<int>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new TrafficLight_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext6_ForReadOnly valDataContext11 = ((TrafficLight_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new TrafficLight_TypedDataContext6(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext6 refDataContext12 = ((TrafficLight_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext12.GetLocation<int>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new TrafficLight_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext6_ForReadOnly valDataContext13 = ((TrafficLight_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new TrafficLight_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext6_ForReadOnly valDataContext14 = ((TrafficLight_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = TrafficLight_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new TrafficLight_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                TrafficLight_TypedDataContext2_ForReadOnly valDataContext15 = ((TrafficLight_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[6]));
                return valDataContext15.ValueType___Expr15Get();
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
                TrafficLight_TypedDataContext4 refDataContext0 = new TrafficLight_TypedDataContext4(locations, true);
                return refDataContext0.GetLocation<int>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                TrafficLight_TypedDataContext4_ForReadOnly valDataContext1 = new TrafficLight_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                TrafficLight_TypedDataContext4 refDataContext2 = new TrafficLight_TypedDataContext4(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                TrafficLight_TypedDataContext4_ForReadOnly valDataContext3 = new TrafficLight_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                TrafficLight_TypedDataContext4_ForReadOnly valDataContext4 = new TrafficLight_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                TrafficLight_TypedDataContext5 refDataContext5 = new TrafficLight_TypedDataContext5(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                TrafficLight_TypedDataContext5_ForReadOnly valDataContext6 = new TrafficLight_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                TrafficLight_TypedDataContext5 refDataContext7 = new TrafficLight_TypedDataContext5(locations, true);
                return refDataContext7.GetLocation<int>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                TrafficLight_TypedDataContext5_ForReadOnly valDataContext8 = new TrafficLight_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                TrafficLight_TypedDataContext5_ForReadOnly valDataContext9 = new TrafficLight_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                TrafficLight_TypedDataContext6 refDataContext10 = new TrafficLight_TypedDataContext6(locations, true);
                return refDataContext10.GetLocation<int>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                TrafficLight_TypedDataContext6_ForReadOnly valDataContext11 = new TrafficLight_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                TrafficLight_TypedDataContext6 refDataContext12 = new TrafficLight_TypedDataContext6(locations, true);
                return refDataContext12.GetLocation<int>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                TrafficLight_TypedDataContext6_ForReadOnly valDataContext13 = new TrafficLight_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                TrafficLight_TypedDataContext6_ForReadOnly valDataContext14 = new TrafficLight_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                TrafficLight_TypedDataContext2_ForReadOnly valDataContext15 = new TrafficLight_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "CurrentTime") 
                        && (TrafficLight_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentTime+1") 
                        && (TrafficLight_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentTime") 
                        && (TrafficLight_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Green Light \"+CurrentTime.ToString()") 
                        && (TrafficLight_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentTime>iGreenLightDelay") 
                        && (TrafficLight_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentTime") 
                        && (TrafficLight_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentTime+1") 
                        && (TrafficLight_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentTime") 
                        && (TrafficLight_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"GreenLight \" + CurrentTime.ToString()") 
                        && (TrafficLight_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentTime>iYellowLightDelay") 
                        && (TrafficLight_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentTime") 
                        && (TrafficLight_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentTime+1") 
                        && (TrafficLight_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentTime") 
                        && (TrafficLight_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"YellowLight \"+CurrentTime.ToString()") 
                        && (TrafficLight_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentTime>iRedLightDelay") 
                        && (TrafficLight_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "0<0") 
                        && (TrafficLight_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
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
                return new TrafficLight_TypedDataContext4(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new TrafficLight_TypedDataContext4_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new TrafficLight_TypedDataContext4(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new TrafficLight_TypedDataContext4_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new TrafficLight_TypedDataContext4_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new TrafficLight_TypedDataContext5(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new TrafficLight_TypedDataContext5_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new TrafficLight_TypedDataContext5(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new TrafficLight_TypedDataContext5_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new TrafficLight_TypedDataContext5_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new TrafficLight_TypedDataContext6(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new TrafficLight_TypedDataContext6_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new TrafficLight_TypedDataContext6(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new TrafficLight_TypedDataContext6_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new TrafficLight_TypedDataContext6_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new TrafficLight_TypedDataContext2_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class TrafficLight_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class TrafficLight_TypedDataContext1 : TrafficLight_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int iGreenLightDelay;
            
            protected int iYellowLightDelay;
            
            protected int iRedLightDelay;
            
            public TrafficLight_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string argument1 {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.iGreenLightDelay = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.iYellowLightDelay = ((int)(this.GetVariableValue((1 + locationsOffset))));
                this.iRedLightDelay = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.iGreenLightDelay);
                this.SetVariableValue((1 + locationsOffset), this.iYellowLightDelay);
                this.SetVariableValue((3 + locationsOffset), this.iRedLightDelay);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 2)].Name != "argument1") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "iGreenLightDelay") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "iYellowLightDelay") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "iRedLightDelay") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return TrafficLight_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext1_ForReadOnly : TrafficLight_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int iGreenLightDelay;
            
            protected int iYellowLightDelay;
            
            protected int iRedLightDelay;
            
            public TrafficLight_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string argument1 {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.iGreenLightDelay = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.iYellowLightDelay = ((int)(this.GetVariableValue((1 + locationsOffset))));
                this.iRedLightDelay = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 2)].Name != "argument1") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "iGreenLightDelay") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "iYellowLightDelay") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "iRedLightDelay") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return TrafficLight_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext2 : TrafficLight_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Activities.Variable corr {
                get {
                    return ((System.Activities.Variable)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
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
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "corr") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Activities.Variable)))) {
                    return false;
                }
                return TrafficLight_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext2_ForReadOnly : TrafficLight_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected System.Activities.Variable corr {
                get {
                    return ((System.Activities.Variable)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 227 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          0<0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr15Get() {
                
                #line 227 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
          0<0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 4)].Name != "corr") 
                            || (locationReferences[(offset + 4)].Type != typeof(System.Activities.Variable)))) {
                    return false;
                }
                return TrafficLight_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext3 : TrafficLight_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CurrentTime;
            
            public TrafficLight_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.CurrentTime = ((int)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((5 + locationsOffset), this.CurrentTime);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "CurrentTime") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                return TrafficLight_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext3_ForReadOnly : TrafficLight_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int CurrentTime;
            
            public TrafficLight_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.CurrentTime = ((int)(this.GetVariableValue((5 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                if (((locationReferences[(offset + 5)].Name != "CurrentTime") 
                            || (locationReferences[(offset + 5)].Type != typeof(int)))) {
                    return false;
                }
                return TrafficLight_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext4 : TrafficLight_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 62 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                    CurrentTime;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr0Get() {
                
                #line 62 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                    CurrentTime;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(int value) {
                
                #line 62 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                
                    CurrentTime = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 83 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        CurrentTime;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 83 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                        CurrentTime;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 83 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                
                        CurrentTime = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                return TrafficLight_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext4_ForReadOnly : TrafficLight_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 88 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                        CurrentTime+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 88 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                        CurrentTime+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 95 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        "Green Light "+CurrentTime.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 95 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                        "Green Light "+CurrentTime.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 102 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                CurrentTime>iGreenLightDelay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 102 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                CurrentTime>iGreenLightDelay;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                return TrafficLight_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext5 : TrafficLight_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 111 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                            CurrentTime;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 111 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                            CurrentTime;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 111 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                
                            CurrentTime = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 132 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                CurrentTime;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr7Get() {
                
                #line 132 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                CurrentTime;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(int value) {
                
                #line 132 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                
                                CurrentTime = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                return TrafficLight_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext5_ForReadOnly : TrafficLight_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 137 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                CurrentTime+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr6Get() {
                
                #line 137 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                CurrentTime+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 144 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                "GreenLight " + CurrentTime.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 144 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                "GreenLight " + CurrentTime.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 151 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                        CurrentTime>iYellowLightDelay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr9Get() {
                
                #line 151 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                        CurrentTime>iYellowLightDelay;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                return TrafficLight_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext6 : TrafficLight_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 160 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                    CurrentTime;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr10Get() {
                
                #line 160 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                    CurrentTime;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(int value) {
                
                #line 160 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                
                                    CurrentTime = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 181 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        CurrentTime;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr12Get() {
                
                #line 181 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                        CurrentTime;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(int value) {
                
                #line 181 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                
                                        CurrentTime = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                return TrafficLight_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class TrafficLight_TypedDataContext6_ForReadOnly : TrafficLight_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public TrafficLight_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public TrafficLight_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 186 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                        CurrentTime+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr11Get() {
                
                #line 186 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                        CurrentTime+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 193 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        "YellowLight "+CurrentTime.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 193 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                        "YellowLight "+CurrentTime.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 203 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                CurrentTime>iRedLightDelay;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 203 "C:\USERS\LEONAR\SOURCE\REPOS\WF-HELLOWORLD\HELLOWORLDACTIVITIES\TRAFFICLIGHT.XAML"
                return 
                                CurrentTime>iRedLightDelay;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 6))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 6);
                }
                expectedLocationsCount = 6;
                return TrafficLight_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
