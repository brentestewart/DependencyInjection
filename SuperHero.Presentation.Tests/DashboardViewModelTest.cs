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
        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void Constructor_ShouldCallRepositoryGetAllHeroesMethodOnce_Always()
        {
            // How can we test this?
        }
    }
}
