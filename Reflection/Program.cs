using System;
using System.Collections.Generic;
using System.Reflection;

namespace _Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
           var res= MoodAnalyaserFactory.CreateMoodAnalyaser("MoodAnalyaser", "AnalyseMood", "I am in Happy mood");
            Console.WriteLine(res);

        }
        public static void InvokeAMethod(string message,string MethodName)
        {
            var type = typeof(MoodAnalyaser);
            MethodInfo invokingMethod = null;
            ConstructorInfo constor = type.GetConstructor(new[] { typeof(string) });
       
            foreach (var method in type.GetMethods())
            {
                if(method.Name==MethodName)
                    invokingMethod = method;
                
            }
            if (invokingMethod != null)
            {
                object obj = constor.Invoke(new object[] { message });
                var s= invokingMethod.Invoke(obj, new string[] {});
                Console.WriteLine(s);
               
            }

        }
    }
}
