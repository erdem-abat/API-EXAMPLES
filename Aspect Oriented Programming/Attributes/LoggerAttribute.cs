using System;
using System.Reflection;
using Castle.DynamicProxy;
using PostSharp.Aspects;

namespace Aspect_Oriented_Programming.Attributes
{
    [AttributeUsage(AttributeTargets.Method |  AttributeTargets.All, AllowMultiple = false, Inherited = false)]

    public class LoggerAttribute : Attribute
    {

        public void OnEnter()
        {
            this.AppendToFile("Enter");
        }

        public void OnException(Exception e)
        {
            this.AppendToFile($"Exception -> {e.Message}");
        }

        public void OnExit()
        {
            this.AppendToFile("Exit");
        }

        private void AppendToFile(string line)
        {
            File.AppendAllLines("log.txt", new string[] { line });
            Console.WriteLine(">> " + line);
        }
    }
}

