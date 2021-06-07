using System;
using System.Net;
using DevExpress.XtraEditors;
using PingTesterXtra.Properties;
using DevExpress.Utils;

namespace PingTesterXtra
{
    public partial class Form_Main : XtraForm
    {
        public PingTestManager PingTestManager { get; set; }

        public Form_Main(PingTestManager pingTestManager)
        {
            InitializeComponent();
            this.PingTestManager = pingTestManager;
            textEdit_host.Text = pingTestManager.Host;
            spinEdit_interval.Value = pingTestManager.Interval;
            Start();
        }

        public void RunAndDisplay()
        {
            PingResult result = this.PingTestManager.RunPingTest();
            if (result.SimplifiedStatus != BriefIPStatus.OK) Stop();
            label_rating.Text = result.Rating.Text;
            label_rating.ForeColor = result.Rating.Color;
            label_time.Text = result.Time.ToString();
            label_time.ForeColor = result.Rating.Color;
            progressBar_latency.Position = result.Time;
            progressBar_latency.Properties.StartColor = result.Rating.Color;
            progressBar_latency.Properties.EndColor = result.Rating.Color;
            label_address.Text = result.IPAddress;
            label_name.Text = result.HostName;
            label_status.Text = result.SimplifiedStatus.ToString();
            label_status.ToolTip = result.PreciseStatus.ToString();
        }

        public void ResetControls()
        {
            foreach (var control in layoutControl_main.Controls)
            {
                if (control is LabelControl)
                {
                    LabelControl label = (LabelControl)control;
                    label.ResetText();
                    label.ResetForeColor();
                    label.ToolTip = string.Empty;
                }
                if (control is ProgressBarControl)
                {
                    ProgressBarControl progressBar = (ProgressBarControl)control;
                    progressBar.Position = progressBar.Properties.Maximum;
                    progressBar.ResetForeColor();
                }
            }
        }

        public void Start()
        {
            ResetControls();
            timer_main.Start();
            button_start.Enabled = false;
            button_stop.Enabled = true;
        }

        public void Stop()
        {
            timer_main.Stop();
            button_start.Enabled = true;
            button_stop.Enabled = false;
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            RunAndDisplay();
        }

        private void textEdit_host_EditValueChanged(object sender, EventArgs e)
        {
            this.PingTestManager.Host = textEdit_host.Text;
            Stop();
        }

        private void spinEdit_interval_EditValueChanged(object sender, EventArgs e)
        {
            this.PingTestManager.Interval = timer_main.Interval = (int)spinEdit_interval.Value;
            Stop();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}