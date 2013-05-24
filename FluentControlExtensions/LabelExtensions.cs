using System.Web.UI;
using System.Web.UI.WebControls;

namespace FluentControlExtensions
{
    public static class LabelExtensions
    {
        public static Label AssociateWith(this Label ctl, string associatedControlId)
        {
            ctl.AssociatedControlID = associatedControlId;
            return ctl;
        }

        public static Label AssociateWith(this Label ctl, Control associatedControl)
        {
            ctl.AssociatedControlID = associatedControl.ID;
            return ctl;
        }
    }
}