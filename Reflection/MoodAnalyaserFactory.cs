using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace _Reflection
{
    public class MoodAnalyaserFactory
    {
        public static object CreateMoodAnalyaser(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyaser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constor = type.GetConstructor(new[] { typeof(string) });
                    object obj = constor.Invoke(new object[] { message });
                    return obj;
                }

                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Constructor not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Method not Found");
            }
        }

    }
}
