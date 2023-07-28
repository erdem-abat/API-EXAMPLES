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
}
