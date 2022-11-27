using System.Linq;
using System.Windows.Forms;

namespace SewingApp
{
    public static class Globals
    {
        public static SewingDBEntities DB { get; } = new SewingDBEntities();

        public static void NavigateTo(UserControl value)
        {
            MainForm.Instance.PrimaryControl = value;
        }

        public static class Context
        {
            public static User CurrentUser { get; set; }
            public static Order CurrentOrder { get; set; }
        }
    }

    public static class Extensions
    {

        public static Control GetPrimaryControl(this Control control)
            => control.Controls.Cast<Control>().FirstOrDefault();
        public static void SetPrimaryControl(this Control control, Control value)
        {
            control.Controls.Clear();
            value.Dock = DockStyle.Fill;
            control.Controls.Add(value);
            value.Parent = control;
        }

    }
}
