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
        public IHeroRepository HeroRepository { get; set; }
        public IHero Hero { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var mockRepo = new Mock<IHeroRepository>();
            HeroRepository = mockRepo.Object;
            var heroMock = new Mock<IHero>();
            heroMock.Setup(h => h.HeroName).Returns("Mock Hero");
            Hero = heroMock.Object;
            mockRepo.Setup(r => r.GetAllHeroes()).Returns(new List<IHero> {Hero});
        }

        [TestMethod]
        public void Constructor_ShouldCallRepositoryGetAllHeroesMethodOnce_Always()
        {
            // How can we test this?          
            var viewModel = new DashboardViewModel(HeroRepository);
            Assert.AreEqual(1, viewModel.AvailableHeroes.Count);
            Assert.AreEqual("Mock Hero", viewModel.AvailableHeroes.First().HeroName);
        }
    }
}
