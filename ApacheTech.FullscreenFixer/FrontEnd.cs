using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApacheTech.FullscreenFixer.Extensions;

namespace ApacheTech.FullscreenFixer
{
    public partial class FrontEnd : Form
    {
        private object _openProcesses;

        public FrontEnd()
        {
            InitializeComponent();
            PopulateProcessesList();
            PopulateScreensList();
        }
        
        private void PopulateProcessesList()
        {
            try
            {
                cbxProcessList.DataSource = null;
                cbxProcessList.Items.Clear();
                
                _openProcesses = Process.GetProcesses()
                    .Where(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle))
                    .Select(process => new
                    {
                        DisplayMember = $"{process.MainWindowTitle} ({Path.GetFileName(process.MainModule?.FileName) ?? process.ProcessName})".Trim(),
                        ValueMember = process
                    })
                    .ToArray();

                cbxProcessList.DataSource = _openProcesses;
                cbxProcessList.DisplayMember = "DisplayMember";
                cbxProcessList.ValueMember = "ValueMember";

                if (cbxProcessList.SelectedIndex == -1)
                    cbxProcessList.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                var sb = new StringBuilder()
                    .AppendLine("Error occurred while populating open processes.")
                    .AppendLine()
                    .AppendLine(e.Message)
                    .AppendLine()
                    .AppendLine(e.StackTrace);

                MessageBox.Show(sb.ToString());
                throw;
            }
        }

        private void PopulateScreensList()
        {
            try
            {
                for (var i = 0; i < Screen.AllScreens.Length; i++)
                {
                    var screen = Screen.AllScreens[i];
                    var primary = screen.Primary ? "(Primary)" : "";
                    cbxScreens.Items.Add($"Monitor {i} [{screen.DeviceName}] {primary}");
                    if (screen.Primary) cbxScreens.SelectedIndex = i;
                }
            }
            catch (Exception e)
            {
                var sb = new StringBuilder()
                    .AppendLine("Error occurred while populating display devices.")
                    .AppendLine()
                    .AppendLine(e.Message)
                    .AppendLine()
                    .AppendLine(e.StackTrace);

                MessageBox.Show(sb.ToString());
                throw;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbxProcessList.SelectedValue is not Process process) return;
            process.WindowedFullscreen(Screen.AllScreens[cbxScreens.SelectedIndex]);
            process.BringToTop();
        }

        private void btnIdentifyMonitors_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < Screen.AllScreens.Length; i++)
            {
                var screen = Screen.AllScreens[i];
                var form = new Form
                {
                    DesktopBounds = screen.Bounds,
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.None,
                    BackColor = Color.Black,
                    AllowTransparency = true,
                    TransparencyKey = Color.Black,
                    ShowInTaskbar = false
                };

                form.Shown += (_, _) =>
                {
                    var timer = new Timer { Interval = 1000 * 5, Enabled = true };
                    timer.Tick += (_, _) =>
                    {
                        form.Close();
                        timer.Stop();
                        BringToFront();
                    };
                };

                var lblScreenId = new Label
                {
                    Text = i.ToString(),
                    Font = new Font(FontFamily.GenericSansSerif, screen.Bounds.Height / 3f, FontStyle.Bold),
                    AutoSize = true,
                    TabIndex = 0,
                    ForeColor = Color.Chartreuse
                };

                form.Controls.Add(lblScreenId);
                form.Show();
                form.SetBounds(screen.Bounds);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateProcessesList();
        }
    }
}