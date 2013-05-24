using System.Collections;
using System.Web.UI.WebControls;

namespace FluentControlExtensions
{
    public static class DataBoundControlExtensions
    {
        public static T DataBind<T>(this T ctl, IEnumerable dataSource) where T : DataBoundControl
        {
            ctl.DataSource = dataSource;
            ctl.DataBind();
            return ctl;
        }
    }
}