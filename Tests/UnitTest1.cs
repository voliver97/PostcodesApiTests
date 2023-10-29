using Models;
using Newtonsoft.Json.Schema;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SchemaValidation.ValidatePostcodeSchema();
        }
    }
}