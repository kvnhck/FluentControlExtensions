using System.Collections.Generic;
using System.Web.UI.WebControls;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentControlExtensions.Test
{
    [TestClass]
    public class DataBoundControlTests
    {
        [TestMethod]
        [TestCategory("DataBoundControl.DataBind")]
        public void DataBind()
        {
            var ddl = ControlFactory
                .Create<DropDownList>()
                .DataBind(new List<string> { "Item 1", "Item 2" });

            Assert.AreEqual(2, ddl.Items.Count);
            Assert.AreEqual("Item 2", ddl.Items[1].Text);
        }
    }
}
