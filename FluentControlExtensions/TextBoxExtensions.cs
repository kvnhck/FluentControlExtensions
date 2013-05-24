using System.Web.UI.WebControls;

namespace FluentControlExtensions
{
    public static class TextBoxExtensions
    {
        public static TextBox MaxLength(this TextBox ctl, int maxLength)
        {
            ctl.MaxLength = maxLength;
            return ctl;
        }
    }
}
