using System;
using System.Collections.Generic;
using System.Text;

namespace _Reflection
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }

        public  readonly ExceptionType Type;

        public CustomException(ExceptionType type,string message) :base(message)
        { 
           Type = type;    
        }

    }

}
