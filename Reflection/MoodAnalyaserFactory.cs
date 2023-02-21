using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace _Reflection
{
    public class MoodAnalyaserFactory
    {
        public static object CreateMoodAnalyaser(string className, string MethodName, string message)
        {
            Type type = typeof(MoodAnalyaser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                MethodInfo invokingMethod = null;
                foreach (var method in type.GetMethods())
                {
                    if (method.Name == MethodName)
                        invokingMethod = method;

                }
                if (invokingMethod != null)
                {
                    ConstructorInfo constor = type.GetConstructor(new[] { typeof(string) });
                    object obj = constor.Invoke(new object[] { message });
                    var s = invokingMethod.Invoke(obj, new string[] { });
                    return s;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Method not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
        

    }
}
