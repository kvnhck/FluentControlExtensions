using System.Web.UI.WebControls;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentControlExtensions.Test
{
    [TestClass]
    public class FluentTests
    {
        private void AssertFluent(object expected, object actual)
        {
            Assert.IsNotNull(actual);
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlExtensions")]
        public void Control_ID()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.ID("lblName");

            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlExtensions")]
        public void Control_Visible()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.Visible(true);

            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlExtensions")]
        public void Control_SkinID()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.SkinID("lblName");

            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlExtensions")]
        public void Control_EnableViewState()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.EnableViewState(true);

            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_AddAttribute()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.AddAttribute("for", "txtName");

            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_AddCssClass()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.AddCssClass("label");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_AddCssClasses()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.AddCssClasses("label", "error");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_AddStyle()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.AddStyle("display", "block");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_ClearStyles()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.ClearStyles();
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_CssClass()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.CssClass("label");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_Enabled()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.Enabled(true);
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_RemoveAttribute()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.RemoveAttribute("error");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_RemoveStyle()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.RemoveStyle("display");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_TabIndex()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.TabIndex(2);
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.WebControlExtensions")]
        public void WebControl_ToolTip()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.ToolTip("Hello world!");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.TextControlExtensions")]
        public void TextControl_Text()
        {
            var expected = ControlFactory.Create<TextBox>();
            var actual = expected.Text("Hello world!");
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.TextBoxExtensions")]
        public void TextBox_MaxLength()
        {
            var expected = ControlFactory.Create<TextBox>();
            var actual = expected.MaxLength(50);
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.DataBoundControlExtensions")]
        public void DataBoundControl_DataBind()
        {
            var expected = ControlFactory.Create<GridView>();
            var actual = expected.DataBind(new string[0]);
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlCollectionExtensions")]
        public void ControlCollection_Create()
        {
            var plh = ControlFactory.Create<PlaceHolder>();
            
            var expected = plh.Controls.Create<Label>();
            var actual = plh.Controls[0];
            
            AssertFluent(expected, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlCollectionExtensions")]
        public void ControlCollection_ForEach()
        {
            var expected = ControlFactory.Create<PlaceHolder>();

            expected.Controls.Create<Label>();

            var actual = expected.Controls.ForEach<Label>(l => l.Visible(true));
            
            AssertFluent(expected.Controls, actual);
        }

        [TestMethod]
        [TestCategory("Fluent.ControlCollectionExtensions")]
        public void ControlCollection_ForEachWithRecursion()
        {
            var expected = ControlFactory.Create<PlaceHolder>();

            var plh = ControlFactory.Create<PlaceHolder>();
            plh.Controls.Create<Label>("lblName");
            expected.Controls.Add(plh);

            var actual = expected.Controls.ForEach<Label>(l => l.Visible(true), true);

            AssertFluent(expected.Controls, actual);
        }

        /*
        [TestMethod]
        public void WebControl_()
        {
            var expected = ControlFactory.Create<Label>();
            var actual = expected.();
            
            AssertFluent(expected, actual);
        }
        */
    }
}
