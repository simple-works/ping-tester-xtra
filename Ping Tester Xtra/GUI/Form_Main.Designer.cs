namespace PingTesterXtra
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.layoutControl_main = new DevExpress.XtraLayout.LayoutControl();
            this.label_address = new DevExpress.XtraEditors.LabelControl();
            this.label_rating = new DevExpress.XtraEditors.LabelControl();
            this.progressBar_latency = new DevExpress.XtraEditors.ProgressBarControl();
            this.label_time = new DevExpress.XtraEditors.LabelControl();
            this.label_status = new DevExpress.XtraEditors.LabelControl();
            this.label_name = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit_interval = new DevExpress.XtraEditors.SpinEdit();
            this.button_start = new DevExpress.XtraEditors.SimpleButton();
            this.button_stop = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_host = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup_main = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_main)).BeginInit();
            this.layoutControl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar_latency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_interval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_host.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl_main
            // 
            this.layoutControl_main.Controls.Add(this.label_address);
            this.layoutControl_main.Controls.Add(this.label_rating);
            this.layoutControl_main.Controls.Add(this.progressBar_latency);
            this.layoutControl_main.Controls.Add(this.label_time);
            this.layoutControl_main.Controls.Add(this.label_status);
            this.layoutControl_main.Controls.Add(this.label_name);
            this.layoutControl_main.Controls.Add(this.spinEdit_interval);
            this.layoutControl_main.Controls.Add(this.button_start);
            this.layoutControl_main.Controls.Add(this.button_stop);
            this.layoutControl_main.Controls.Add(this.textEdit_host);
            this.layoutControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl_main.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_main.Name = "layoutControl_main";
            this.layoutControl_main.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(741, 121, 450, 399);
            this.layoutControl_main.Root = this.layoutControlGroup_main;
            this.layoutControl_main.Size = new System.Drawing.Size(301, 272);
            this.layoutControl_main.TabIndex = 0;
            // 
            // label_address
            // 
            this.label_address.Location = new System.Drawing.Point(58, 86);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(48, 13);
            this.label_address.StyleController = this.layoutControl_main;
            this.label_address.TabIndex = 5;
            this.label_address.Text = "{address}";
            // 
            // label_rating
            // 
            this.label_rating.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label_rating.Appearance.Options.UseFont = true;
            this.label_rating.Location = new System.Drawing.Point(58, 12);
            this.label_rating.Name = "label_rating";
            this.label_rating.Size = new System.Drawing.Size(48, 13);
            this.label_rating.StyleController = this.layoutControl_main;
            this.label_rating.TabIndex = 0;
            this.label_rating.Text = "{rating}";
            // 
            // progressBar_latency
            // 
            this.progressBar_latency.EditValue = 1000;
            this.progressBar_latency.Location = new System.Drawing.Point(58, 46);
            this.progressBar_latency.Name = "progressBar_latency";
            this.progressBar_latency.Properties.EndColor = System.Drawing.Color.Silver;
            this.progressBar_latency.Properties.Maximum = 1000;
            this.progressBar_latency.Properties.StartColor = System.Drawing.Color.Silver;
            this.progressBar_latency.Properties.Step = 1;
            this.progressBar_latency.Size = new System.Drawing.Size(145, 14);
            this.progressBar_latency.StyleController = this.layoutControl_main;
            this.progressBar_latency.TabIndex = 2;
            // 
            // label_time
            // 
            this.label_time.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label_time.Appearance.Options.UseFont = true;
            this.label_time.Location = new System.Drawing.Point(58, 29);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(43, 13);
            this.label_time.StyleController = this.layoutControl_main;
            this.label_time.TabIndex = 1;
            this.label_time.Text = "{time} ";
            // 
            // label_status
            // 
            this.label_status.Cursor = System.Windows.Forms.Cursors.Help;
            this.label_status.Location = new System.Drawing.Point(58, 120);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.StyleController = this.layoutControl_main;
            this.label_status.TabIndex = 7;
            this.label_status.Text = "{status}";
            this.label_status.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(58, 103);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(36, 13);
            this.label_name.StyleController = this.layoutControl_main;
            this.label_name.TabIndex = 6;
            this.label_name.Text = "{name}";
            // 
            // spinEdit_interval
            // 
            this.spinEdit_interval.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::PingTesterXtra.Properties.Settings.Default, "Interval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinEdit_interval.EditValue = global::PingTesterXtra.Properties.Settings.Default.Interval;
            this.spinEdit_interval.Location = new System.Drawing.Point(58, 186);
            this.spinEdit_interval.Name = "spinEdit_interval";
            this.spinEdit_interval.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEdit_interval.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spinEdit_interval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_interval.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_interval.Properties.IsFloatValue = false;
            this.spinEdit_interval.Properties.Mask.BeepOnError = true;
            this.spinEdit_interval.Properties.Mask.EditMask = "N00";
            this.spinEdit_interval.Properties.MaxValue = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.spinEdit_interval.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_interval.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.spinEdit_interval.Size = new System.Drawing.Size(231, 20);
            this.spinEdit_interval.StyleController = this.layoutControl_main;
            this.spinEdit_interval.TabIndex = 4;
            this.spinEdit_interval.EditValueChanged += new System.EventHandler(this.spinEdit_interval_EditValueChanged);
            // 
            // button_start
            // 
            this.button_start.ImageUri.Uri = "Apply;Size16x16";
            this.button_start.Location = new System.Drawing.Point(152, 238);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(137, 22);
            this.button_start.StyleController = this.layoutControl_main;
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Start";
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_stop.ImageUri.Uri = "Cancel;Size16x16";
            this.button_stop.Location = new System.Drawing.Point(12, 238);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(136, 22);
            this.button_stop.StyleController = this.layoutControl_main;
            this.button_stop.TabIndex = 8;
            this.button_stop.Text = "Stop";
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textEdit_host
            // 
            this.textEdit_host.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::PingTesterXtra.Properties.Settings.Default, "Host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit_host.EditValue = global::PingTesterXtra.Properties.Settings.Default.Host;
            this.textEdit_host.Location = new System.Drawing.Point(58, 162);
            this.textEdit_host.Name = "textEdit_host";
            this.textEdit_host.Size = new System.Drawing.Size(231, 20);
            this.textEdit_host.StyleController = this.layoutControl_main;
            this.textEdit_host.TabIndex = 3;
            this.textEdit_host.EditValueChanged += new System.EventHandler(this.textEdit_host_EditValueChanged);
            // 
            // layoutControlGroup_main
            // 
            this.layoutControlGroup_main.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup_main.GroupBordersVisible = false;
            this.layoutControlGroup_main.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem12,
            this.layoutControlItem11,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem13,
            this.layoutControlItem5,
            this.emptySpaceItem3});
            this.layoutControlGroup_main.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup_main.Name = "Root";
            this.layoutControlGroup_main.Size = new System.Drawing.Size(301, 272);
            this.layoutControlGroup_main.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 125);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(281, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(281, 22);
            this.emptySpaceItem2.Text = "emptySpaceItem1";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.button_stop;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 226);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.button_start;
            this.layoutControlItem11.Location = new System.Drawing.Point(140, 226);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(141, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.label_address;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(281, 17);
            this.layoutControlItem6.Text = "Address:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.label_name;
            this.layoutControlItem9.CustomizationFormText = "Address:";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(281, 17);
            this.layoutControlItem9.Text = "Name:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.label_status;
            this.layoutControlItem8.CustomizationFormText = "Interval";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem8.Size = new System.Drawing.Size(281, 17);
            this.layoutControlItem8.Text = "Status:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.label_rating;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(281, 17);
            this.layoutControlItem7.Text = "Rating:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label_time;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(281, 17);
            this.layoutControlItem2.Text = "Time:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.progressBar_latency;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(195, 18);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(195, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(281, 18);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Latency:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.textEdit_host;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(281, 24);
            this.layoutControlItem13.Text = "Host:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spinEdit_interval;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(281, 24);
            this.layoutControlItem5.Text = "Interval:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(43, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 198);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(281, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label_rating;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(510, 17);
            this.layoutControlItem1.Text = "Rating:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.label_time;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(510, 17);
            this.layoutControlItem4.Text = "Time:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(43, 13);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_stop;
            this.ClientSize = new System.Drawing.Size(301, 272);
            this.Controls.Add(this.layoutControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Tester Xtra";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_main)).EndInit();
            this.layoutControl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar_latency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_interval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_host.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl_main;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup_main;
        private System.Windows.Forms.Timer timer_main;
        private DevExpress.XtraEditors.LabelControl label_address;
        private DevExpress.XtraEditors.ProgressBarControl progressBar_latency;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LabelControl label_status;
        private DevExpress.XtraEditors.LabelControl label_name;
        private DevExpress.XtraEditors.SimpleButton button_start;
        private DevExpress.XtraEditors.SimpleButton button_stop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.TextEdit textEdit_host;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SpinEdit spinEdit_interval;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LabelControl label_rating;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl label_time;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;

    }
}

