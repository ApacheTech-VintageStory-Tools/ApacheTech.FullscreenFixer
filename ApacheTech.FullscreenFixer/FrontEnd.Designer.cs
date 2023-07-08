
namespace ApacheTech.FullscreenFixer
{
    partial class FrontEnd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontEnd));
            this.lblProcess = new System.Windows.Forms.Label();
            this.cbxProcessList = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnIdentifyMonitors = new System.Windows.Forms.Button();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.cbxScreens = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(12, 21);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(50, 15);
            this.lblProcess.TabIndex = 0;
            this.lblProcess.Text = "Process:";
            // 
            // cbxProcessList
            // 
            this.cbxProcessList.FormattingEnabled = true;
            this.cbxProcessList.Location = new System.Drawing.Point(68, 18);
            this.cbxProcessList.Name = "cbxProcessList";
            this.cbxProcessList.Size = new System.Drawing.Size(265, 23);
            this.cbxProcessList.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 76);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(433, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "&Fullscreen Borderless";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnIdentifyMonitors
            // 
            this.btnIdentifyMonitors.Location = new System.Drawing.Point(339, 47);
            this.btnIdentifyMonitors.Name = "btnIdentifyMonitors";
            this.btnIdentifyMonitors.Size = new System.Drawing.Size(106, 23);
            this.btnIdentifyMonitors.TabIndex = 3;
            this.btnIdentifyMonitors.Text = "&Identify";
            this.btnIdentifyMonitors.UseVisualStyleBackColor = true;
            this.btnIdentifyMonitors.Click += new System.EventHandler(this.btnIdentifyMonitors_Click);
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(9, 50);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(53, 15);
            this.lblMonitor.TabIndex = 4;
            this.lblMonitor.Text = "Monitor:";
            // 
            // cbxScreens
            // 
            this.cbxScreens.FormattingEnabled = true;
            this.cbxScreens.Location = new System.Drawing.Point(68, 47);
            this.cbxScreens.Name = "cbxScreens";
            this.cbxScreens.Size = new System.Drawing.Size(265, 23);
            this.cbxScreens.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(339, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 110);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxScreens);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.btnIdentifyMonitors);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbxProcessList);
            this.Controls.Add(this.lblProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontEnd";
            this.Text = "Fullscreenificator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox cbxProcessList;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnIdentifyMonitors;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.ComboBox cbxScreens;
        private System.Windows.Forms.Button btnRefresh;
    }
}

