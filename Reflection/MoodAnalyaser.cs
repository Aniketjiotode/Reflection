using System;
using System.Collections.Generic;
using System.Text;

namespace _Reflection
{
    public class MoodAnalyaser
    {
        private string message;

        public MoodAnalyaser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Empty Mood message not valid");

                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }            
            }
            catch(NullReferenceException) 
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Null message not valid");

            }
        }

    }
}
