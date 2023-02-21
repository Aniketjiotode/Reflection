using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace _Reflection
{
    public class MoodAnalyaserFactory
    {
        public static object CreaateMoodAnalyaser(string className,string constructorName)
        {
            string pattern = @"."+constructorName+"$";
            Match reult =Regex.Match(className,pattern);

            if (reult.Success)
            {
                try
                {

                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type= assembly.GetType(className);
                    return Activator.CreateInstance(type);

                }catch(Exception)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE,"class not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD,"Method not Found");
            }
        }

    }
}
