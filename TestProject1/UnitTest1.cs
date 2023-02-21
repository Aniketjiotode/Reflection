
using _Reflection;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void GivenClassNameShouldReturnMoodAnalyaseObject()
        //{
        //    string message = null;
        //    object expected = new MoodAnalyaser(message);
        //    object obj = MoodAnalyaserFactory.CreaateMoodAnalyaser("_Reflection.MoodAnalyaserFactory", "MoodAnalyaserFactory");
        //    expected.Equals(obj);
        //}
        [Test]

        public void ImproperClassNameShouldThrowCustomException_classnotFoundMeaasage()
        {
            string expecxted = "Constructor not Found";
            try
            {
                object expected = new MoodAnalyaser(null);
                object obj = MoodAnalyaserFactory.CreateMoodAnalyaser("_Reflection.MoodAnalyaser", "MoodAnalyaer", "HAPPY");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }
        [Test]

        public void ImproperConstructorShouldThrowCustomException_MehtodnotFoundMeaasage()
        {
            string expecxted = "Method not Found";
            try
            {
                object expected = new MoodAnalyaser(null);
                object obj = MoodAnalyaserFactory.CreateMoodAnalyaser("_Reflection.MoodAnalyaer", "MoodAnalyaser", "HAPPY");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }
        [Test]
        public void GivenClassNameShouldReturnMoodAnalyaseObjectUsingParameteriseConstructor()
        {     
            object expected = new MoodAnalyaser("HAPPY");
            object obj = MoodAnalyaserFactory.CreateMoodAnalyaser("_Reflection.MoodAnalyaser", "MoodAnalyaser","HAPPY");
            expected.Equals(obj);
        }

    }
}