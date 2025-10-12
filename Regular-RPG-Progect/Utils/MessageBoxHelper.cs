using System.Windows.Forms;

namespace Regular_RPG_Progect.Utils
{
    internal class MessageBoxHelper
    {
        public static void ErrorPopup(string message)
        {
            MessageBox.Show(message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningPopup(string message)
        {
            MessageBox.Show(message, "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult WarningPopupDialog(string message)
        {
            return MessageBox.Show(message, "Попередження!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        public static DialogResult InfoPopupDialog(string message)
        {
            return MessageBox.Show(message, "Попередження!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
