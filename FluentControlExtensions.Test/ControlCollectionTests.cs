using System;
using System.Linq;
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

        [TestMethod]
        [TestCategory("ControlCollection.ForEach")]
        public void ChangeAllTextBoxes()
        {
            var plh = ControlFactory.Create<PlaceHolder>();
            foreach (var i in Enumerable.Range(0, 10))
            {
                plh.Controls.Create<TextBox>("txt" + i);
            }

            plh.Controls.ForEach<TextBox>(t => t.CssClass("text"));

            Assert.AreEqual(10, plh.Controls.Count);
            Assert.AreEqual("text", ((TextBox)(plh.Controls[9])).CssClass);
        }
    }
}
