using DogCatcher.Services;
using System;
using Xunit;

namespace DogCatcher.Tests
{
    public class QueryServiceTests
    {
        private QueryService _queryService;
        public QueryServiceTests()
        {
            _queryService = new QueryService();
        }

        [Fact]
        public void GetAvailableShelters__GivenZipCode__WhenNoShleters__ReturnsEmptyList()
        {
            var zip = "12345";
            var result = _queryService.GetAvailableShelters(zip);

            Assert.Empty(zip);
        }

        [Fact]
        public void GetAvailablePets__WhenNoAvailablePets__ReturnsEmptyList()
        {
            var result = _queryService.GetAvailablePets();

            Assert.Empty(result);
        }
    }
}
