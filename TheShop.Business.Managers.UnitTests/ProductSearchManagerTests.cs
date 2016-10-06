using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Should;
using System;
using TheShop.Domain.Core.Interfaces;

namespace TheShop.Business.Managers.UnitTests
{
    [TestClass]
    public class ProductSearchManagerTests
    {
        private ProductSearchManager Instance;
        private Mock<ISearchTermValidator> _mockForSearchTermValidator;
        private Mock<IProductRepository> _mockForProductRepository;

        [TestInitialize]
        public void Before_Each_test()
        {
            _mockForSearchTermValidator = new Mock<ISearchTermValidator>();
            _mockForProductRepository   = new Mock<IProductRepository>();

            _mockForSearchTermValidator.Setup(o => o.IsValid(It.IsAny<string>())).Returns(true);

            Instance = new ProductSearchManager(_mockForSearchTermValidator.Object,_mockForProductRepository.Object);
        }


        [TestMethod]
        public void SearchByName_SearchTermIsNotValid_ReturnsEmptyList()
        { 
            // Arrange
            _mockForSearchTermValidator.Setup(o => o.IsValid(It.IsAny<string>())).Returns(false);

            // Act
            var result = Instance.SearchByName("blabla");

            // Assert
            result.ShouldBeEmpty();
        }


        [TestMethod]
        public void SearchByName_SearchTermIsValid_UsesRepositoryToGetMatches()
        {
            // Arrange
            var searchString = "blabla";

            // Act
            Instance.SearchByName(searchString);

            // Assert
            _mockForProductRepository.Verify(o => o.GetByPartialName(searchString), Times.Once());
        }


        [TestMethod]
        public void SearchByName_RepositoryBlowsUp_ReturnEmptyList()
        {
            // Arrange
            var badException = new Exception("I'm so bad!!");            
            _mockForProductRepository.Setup(o => o.GetByPartialName(It.IsAny<string>())).Throws(badException);

            // Act            
            var result = Instance.SearchByName("something");
            
            // Assert    
            result.ShouldBeEmpty();
        }
    }
}
