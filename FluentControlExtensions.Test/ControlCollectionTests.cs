using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentControlExtensions.Test
{
    [TestClass]
    public class ControlCollectionTests
    {
        [TestMethod]
        [TestCategory("ControlCollection.Create")]
        public void CreateTextBoxInPage()
        {
            var page = new Page();

            var txt = page.Controls.Create<TextBox>("txtName");

            Assert.IsInstanceOfType(txt, typeof(TextBox));
            Assert.AreEqual("txtName", txt.ID);
            CollectionAssert.Contains(page.Controls, txt);
        }
    }
}
