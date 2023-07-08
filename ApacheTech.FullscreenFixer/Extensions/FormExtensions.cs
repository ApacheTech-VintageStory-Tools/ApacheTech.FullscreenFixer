using System.Drawing;
using System.Windows.Forms;

namespace ApacheTech.FullscreenFixer.Extensions
{
    public static class FormExtensions
    {
        /// <summary>
        ///     Sets the bounds of the control.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="bounds">The bounds.</param>
        public static void SetBounds(this Form form, Rectangle bounds)
        {
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }
    }
}