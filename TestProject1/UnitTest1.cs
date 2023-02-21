
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

        public void HappyMessageShouldReturnHappyMood()
        {     
            var res = new MoodAnalyaser("HAPPY");
                string expected = res.AnalyseMood();
            string obj = MoodAnalyaserFactory.CreateMoodAnalyaser("MoodAnalyaser", "AnalyseMood", "I am in Happy mood").ToString();
            Assert.AreEqual(expected, obj);
        }
        [Test]

        public void ImproperMethodNameShouldThrowCustomException_MethodnotFoundMeaasage()
        {
            string expecxted = "Method not Found";
            try
            {
                object expected = new MoodAnalyaser(null);
                object obj = MoodAnalyaserFactory.CreateMoodAnalyaser("MoodAnalyaser", "AnalyeMood", "I am in Happy mood");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }
        


    }
}