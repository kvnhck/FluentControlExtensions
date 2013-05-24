using System.Web.UI.WebControls;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentControlExtensions.Test
{
    [TestClass]
    public class WebControlTests
    {
        [TestMethod]
        [TestCategory("WebControl.AddCssClass")]
        public void AddCssClass_WhenAddingOneCssClass_WebControlShouldContainCssClass()
        {
            var txt = ControlFactory.Create<TextBox>("txtName")
                                    .AddCssClass("text");

            Assert.AreEqual("text", txt.CssClass);
        }

        [TestMethod]
        [TestCategory("WebControl.AddCssClass")]
        public void AddCssClass_WhenAddingMultipleCssClasses_WebControlShouldContainAllCssClasses()
        {
            var txt = ControlFactory.Create<TextBox>("txtName")
                                    .AddCssClass("text")
                                    .AddCssClass("error");

            Assert.AreEqual("text error", txt.CssClass);
        }

        [TestMethod]
        [TestCategory("WebControl.AddCssClass")]
        public void AddCssClass_WhenAddingCssClassesMoreThanOnce_WebControlShouldContainCssClassOnlyOnce()
        {
            var txt = ControlFactory.Create<TextBox>("txtName")
                                    .AddCssClass("text")
                                    .AddCssClasses("error", "text")
                                    .AddCssClass("error");

            Assert.AreEqual("text error", txt.CssClass);
        }

        [TestMethod]
        [TestCategory("WebControl.AddAttribute")]
        public void WhenAddingOneAttribute_ShouldContainAttribute()
        {
            var lbl = ControlFactory.Create<Label>("lblName");

            lbl.AddAttribute("for", "txtName");

            CollectionAssert.Contains(lbl.Attributes.Keys, "for");
            Assert.AreEqual("txtName", lbl.Attributes["for"]);
        }

        [TestMethod]
        [TestCategory("WebControl.RemoveAttribute")]
        public void WhenRemovingAttribute_WebControlShouldNotContainTheAttribute()
        {
            var lbl = ControlFactory.Create<Label>("lblName")
                                    .AddAttribute("for", "txtName");

            lbl.RemoveAttribute("for");

            CollectionAssert.DoesNotContain(lbl.Attributes.Keys, "for");
        }
    }
}
