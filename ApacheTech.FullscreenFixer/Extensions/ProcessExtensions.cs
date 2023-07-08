using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ApacheTech.FullscreenFixer.Internals;

// ReSharper disable UnusedMethodReturnValue.Local
// ReSharper disable CommentTypo
// ReSharper disable InconsistentNaming

namespace ApacheTech.FullscreenFixer.Extensions
{
    public static class ProcessExtensions
    {

        /// <summary>
        ///     Brings the thread that created the specified window into the foreground and activates the window. Keyboard input is
        ///     directed to the window, and various visual cues are changed for the user. The system assigns a slightly higher
        ///     priority to the thread that created the foreground window than it does to other threads.
        ///     <para>See for https://msdn.microsoft.com/en-us/library/windows/desktop/ms633539%28v=vs.85%29.aspx more information.</para>
        /// </summary>
        /// <param name="process">The process to bring to the top.</param>
        public static void BringToTop(this Process process)
        {
            var hWnd = process.MainWindowHandle;
            WinNative.SetForegroundWindow(hWnd);
        }

        /// <summary>
        ///     Borderless fullscreen windowed refers to a mode where the game presents the rendered image in a maximised window
        ///     without borders making it cover the whole monitor. This is opposed to a regular window that uses window decorations
        ///     around the contents of the window, or fullscreen exclusive mode where the game takes control over the output device
        ///     and where each application switch required a display mode switch to occur.
        /// </summary>
        /// <param name="process">The process to make borderless.</param>
        /// <param name="screen">The screen to show the process on.</param>
        public static void WindowedFullscreen(this Process process, Screen screen)
        {
            var hWnd = new HandleRef(process, process.MainWindowHandle);
            var style = WinNative.GetWindowLongPtr(hWnd.Handle, GWL.GWL_STYLE).ToInt64();
            var borderlessFullscreenStyle = new IntPtr(style & WindowStyles.WS_BORDERLESS);

            WinNative.SetWindowLongPtr(hWnd, GWL.GWL_STYLE, borderlessFullscreenStyle);
            WinNative.MoveWindow(hWnd.Handle, screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height, true);
        }
    }
}