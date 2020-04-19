namespace Cosmos.ModelBuilding
{
    #region StreetAddress
    public class StreetAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public TestClass Test { get; set; }
    }
    #endregion

    public class TestClass
    {
        public string Name { get; set; }
    }
}
