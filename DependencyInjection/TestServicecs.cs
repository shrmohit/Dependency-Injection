namespace DependencyInjection
{
    public class TestServicecs : ITestIService
    {
        private readonly string _id;

        public TestServicecs()
        {
            _id = Guid.NewGuid().ToString();
        }

        public string GetId()
        {
            return _id;
        }
    }
}
