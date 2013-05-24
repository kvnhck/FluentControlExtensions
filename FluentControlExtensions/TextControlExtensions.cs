using System.Web.UI;

namespace FluentControlExtensions
{
    public static class TextControlExtensions
    {
        public static T Text<T>(this T ctl, string text) where T : ITextControl
        {
            ctl.Text = text;
            return ctl;
        }
    }
}