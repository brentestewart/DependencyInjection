using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SuperHero.Common;

namespace SuperHero.Presentation.Tests
{
    [TestClass]
    public class DashboardViewModelTest
    {
 
        [TestInitialize]
        public void Initialize()
        {
            HeroMock = new Mock<IHeroRepository>();
            HeroMock.Setup(r => r.GetAllHeroes()).Returns(new List<IHero>());
            HeroRepository = HeroMock.Object;

        }

        [TestMethod]
        public void Constructor_ShouldCallRepositoryGetAllHeroesMethodOnce_Always()
        {
            var viewModel = new DashboardViewModel(HeroRepository);
            HeroMock.Verify(r => r.GetAllHeroes(), Times.Once);
        }
    }
}
