using Castle.DynamicProxy;
using System.Diagnostics;

namespace Aspect_Oriented_Programming.Attributes
{
    public class PerformanceAspect : MethodInterceptionBaseAttribute
    {
        private Stopwatch _stopwatch;
        public PerformanceAspect()
        {
            _stopwatch = new Stopwatch();
        }
        public override void Intercept(IInvocation invocation)
        {
            try
            {
                _stopwatch.Start();
                invocation.Proceed();
            }
            catch (Exception ex)
            {

            }
            Console.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");

            _stopwatch.Reset();
        }

    }

    //[PSerializable]
    //public class PerformanceAspect : OnMethodBoundaryAspect
    //{
    //    public override void OnEntry(MethodExecutionArgs args)
    //    {
    //        Console.WriteLine("The {0} method has been entered.", args.Method.Name);
    //    }

    //    public override void OnSuccess(MethodExecutionArgs args)
    //    {
    //        Console.WriteLine("The {0} method executed successfully.", args.Method.Name);
    //    }

    //    public override void OnExit(MethodExecutionArgs args)
    //    {
    //        Console.WriteLine("The {0} method has exited.", args.Method.Name);
    //    }

    //    public override void OnException(MethodExecutionArgs args)
    //    {
    //        Console.WriteLine("An exception was thrown in {0}.", args.Method.Name);
    //    }

    //}
}
