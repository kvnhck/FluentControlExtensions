using System.Web.UI;

namespace FluentControlExtensions
{
    public class ControlFactory
    {
        public static T Create<T>() where T : Control, new()
        {
            return new T();
        }

        public static T Create<T>(string id) where T : Control, new()
        {
            return Create<T>().ID(id);
        }
    }
}