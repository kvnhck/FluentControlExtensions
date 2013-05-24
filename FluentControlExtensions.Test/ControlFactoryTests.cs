using System.Web.UI.WebControls;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentControlExtensions.Test
{
    [TestClass]
    public class ControlFactoryTests
    {
        [TestMethod]
        [TestCategory("ControlFactory.Create")]
        public void CreateControlTest()
        {
            var txt = ControlFactory.Create<TextBox>("txtName");

            Assert.IsInstanceOfType(txt, typeof(TextBox));
            Assert.AreEqual("txtName", txt.ID);
        }
    }
}
