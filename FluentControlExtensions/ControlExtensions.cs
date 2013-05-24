using System.Web.UI;

namespace FluentControlExtensions
{
    public static class ControlExtensions
    {
        public static T ID<T>(this T ctl, string id) where T : Control
        {
            ctl.ID = id;
            return ctl;
        }

        public static T Visible<T>(this T ctl, bool visible) where T : Control
        {
            ctl.Visible = visible;
            return ctl;
        }

        public static T SkinID<T>(this T ctl, string skinID) where T : Control
        {
            ctl.SkinID = skinID;
            return ctl;
        }

        public static T EnableViewState<T>(this T ctl, bool enableViewState) where T : Control
        {
            ctl.EnableViewState = enableViewState;
            return ctl;
        }
    }
}
