using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SR5Initiative;
using SR5Initiative.Pages;
using Bunit;

namespace SR5Initiative.Tests
{
    [TestClass]
    public class IndexTests
    {
        [TestMethod]
        public void Index_Component_RendersWithoutError()
        {
            //Arrange
            using var ctx = new Bunit.TestContext();

            //Act
            var cut = ctx.RenderComponent<Pages.Index>();

            //Assert
            Assert.IsFalse(String.IsNullOrEmpty(cut.Markup));
        }
    }
}
