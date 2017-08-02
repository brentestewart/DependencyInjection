using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SuperHero.Common;

namespace SuperHero.Presentation.Tests
{
    [TestClass]
    public class DashboardViewModelTest
    {
        public Mock<IHeroRepository> HeroMock { get; set; }
        public IHeroRepository HeroRepository { get; set; }
        [TestInitialize]
        public void Initialize()
        {
            HeroMock = new Mock<IHeroRepository>();
            HeroRepository = HeroMock.Object;

        }

        [TestMethod]
        public void Constructor_ShouldCallRepositoryGetAllHeroesMethod()
        {
            //Arange
            HeroMock.Setup(r => r.GetAllHeroes()).Returns(new List<IHero>());

            //Act
            var viewModel = new DashboardViewModel(HeroRepository);

            //Assert
            HeroMock.Verify(r => r.GetAllHeroes(), Times.Once);
        }
    }
}
