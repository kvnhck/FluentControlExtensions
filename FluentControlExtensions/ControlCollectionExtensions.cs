using System;
using System.Web.UI;

namespace FluentControlExtensions
{
    public static class ControlCollectionExtensions
    {
        public static T Create<T>(this ControlCollection ctls) where T : Control, new()
        {
            var t = ControlFactory.Create<T>();
            ctls.Add(t);
            return t;
        }

        public static T Create<T>(this ControlCollection ctls, string id) where T : Control, new()
        {
            return Create<T>(ctls).ID(id);
        }

        public static ControlCollection ForEach<T>(this ControlCollection ctls, Action<T> action, bool recursive = false)
        {
            foreach (var ctl in ctls)
            {
                if (ctl is T)
                    action.Invoke((T)ctl);

                if (recursive && ctl is Control)
                    ((Control)ctl).Controls.ForEach(action, true);
            }

            return ctls;
        }
    }
}