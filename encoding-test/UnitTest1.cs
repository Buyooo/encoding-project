using encoding_project.Service;

namespace encoding_test
{
    public class Tests
    {
        [Test]
        public void ShouldEncode()
        {
            var knownResult = "something";
            var result = EncodingService.EncodeString("testString");

            Assert.AreEqual(knownResult, result);
        }
    }
}