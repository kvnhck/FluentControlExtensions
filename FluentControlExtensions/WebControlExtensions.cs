using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace FluentControlExtensions
{
    public static class WebControlExtensions
    {
        public static T AddAttribute<T>(this T ctl, string key, string value) where T : WebControl
        {
            ctl.Attributes.Add(key, value);
            return ctl;
        }

        public static T AddCssClass<T>(this T ctl, string cssClass) where T : WebControl
        {
            return ctl.AddCssClasses(cssClass);
        }

        public static T AddCssClasses<T>(this T ctl, params string[] cssClasses) where T : WebControl
        {
            var classes = !string.IsNullOrEmpty(ctl.CssClass)
                ? ctl.CssClass.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                : new string[0];

            foreach(var cssClass in cssClasses)
                if (!classes.Contains(cssClass))
                    ctl.CssClass = string.Concat(ctl.CssClass, " ", cssClass);

            ctl.CssClass = ctl.CssClass.Trim();
            return ctl;
        }

        public static T AddStyle<T>(this T ctl, string key, string value) where T : WebControl
        {
            ctl.Style.Add(key, value);
            return ctl;
        }

        public static T ClearStyles<T>(this T ctl) where T : WebControl
        {
            ctl.Style.Clear();
            return ctl;
        }

        public static T CssClass<T>(this T ctl, string cssClass) where T : WebControl
        {
            ctl.CssClass = cssClass;
            return ctl;
        }

        public static T Enabled<T>(this T ctl, bool enabled) where T : WebControl
        {
            ctl.Enabled = enabled;
            return ctl;
        }

        public static T RemoveAttribute<T>(this T ctl, string key) where T : WebControl
        {
            ctl.Attributes.Remove(key);
            return ctl;
        }

        public static T RemoveStyle<T>(this T ctl, string key) where T : WebControl
        {
            ctl.Style.Remove(key);
            return ctl;
        }

        public static T TabIndex<T>(this T ctl, short tabIndex) where T : WebControl
        {
            ctl.TabIndex = tabIndex;
            return ctl;
        }

        public static T ToolTip<T>(this T ctl, string toolTip) where T : WebControl
        {
            ctl.ToolTip = toolTip;
            return ctl;
        }
    }
}