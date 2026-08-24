namespace PharmacyAssistant
{
    partial class frmMyTasks
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyTasks));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblReference = new System.Windows.Forms.Label();
            this.gpTitle = new Owf.Controls.GradientPanel();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnViewDocument = new System.Windows.Forms.Button();
            this.txtNextDate = new System.Windows.Forms.TextBox();
            this.lblNextDate = new System.Windows.Forms.Label();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.txtTaskCertificate = new System.Windows.Forms.TextBox();
            this.lblEventCertificate = new System.Windows.Forms.Label();
            this.lblEventStart = new System.Windows.Forms.Label();
            this.dtpTaskStart = new System.Windows.Forms.DateTimePicker();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lvwTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlTasks = new System.Windows.Forms.ImageList(this.components);
            this.calTasks = new System.Windows.Forms.Calendar.Calendar();
            this.lblTaskCompleted = new System.Windows.Forms.Label();
            this.gpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::PharmacyAssistant.Properties.Resources.door_out;
            this.btnClose.Location = new System.Drawing.Point(1157, 457);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::PharmacyAssistant.Properties.Resources.arrow_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(1127, 457);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblReference
            // 
            this.lblReference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReference.BackColor = System.Drawing.Color.Transparent;
            this.lblReference.Location = new System.Drawing.Point(1144, 0);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(76, 23);
            this.lblReference.TabIndex = 36;
            this.lblReference.Text = "Ref: 00B";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpTitle
            // 
            this.gpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpTitle.BorderColor = System.Drawing.Color.Transparent;
            this.gpTitle.Controls.Add(this.lblReference);
            this.gpTitle.GradientEndColor = System.Drawing.SystemColors.Control;
            this.gpTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gpTitle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gpTitle.Image = global::PharmacyAssistant.Properties.Resources.realvista_projectmanagment_project_schedule_256;
            this.gpTitle.ImageLocation = new System.Drawing.Point(2, 2);
            this.gpTitle.ImageSize = new System.Drawing.Point(64, 64);
            this.gpTitle.ImageSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.gpTitle.Location = new System.Drawing.Point(12, 12);
            this.gpTitle.Name = "gpTitle";
            this.gpTitle.ShadowOffSet = 0;
            this.gpTitle.Size = new System.Drawing.Size(1220, 67);
            this.gpTitle.TabIndex = 41;
            // 
            // btnCompleted
            // 
            this.btnCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleted.Enabled = false;
            this.btnCompleted.Image = global::PharmacyAssistant.Properties.Resources.realvista_general_check_mark_16;
            this.btnCompleted.Location = new System.Drawing.Point(951, 425);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(24, 24);
            this.btnCompleted.TabIndex = 108;
            this.toolTips.SetToolTip(this.btnCompleted, "Set Task as completed");
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnViewDocument
            // 
            this.btnViewDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDocument.Enabled = false;
            this.btnViewDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDocument.Image = global::PharmacyAssistant.Properties.Resources.book_open;
            this.btnViewDocument.Location = new System.Drawing.Point(1207, 425);
            this.btnViewDocument.Name = "btnViewDocument";
            this.btnViewDocument.Size = new System.Drawing.Size(25, 24);
            this.btnViewDocument.TabIndex = 107;
            this.toolTips.SetToolTip(this.btnViewDocument, "View Document");
            this.btnViewDocument.UseVisualStyleBackColor = true;
            this.btnViewDocument.Click += new System.EventHandler(this.btnViewDocument_Click);
            // 
            // txtNextDate
            // 
            this.txtNextDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextDate.Location = new System.Drawing.Point(951, 301);
            this.txtNextDate.Name = "txtNextDate";
            this.txtNextDate.ReadOnly = true;
            this.txtNextDate.Size = new System.Drawing.Size(281, 24);
            this.txtNextDate.TabIndex = 109;
            // 
            // lblNextDate
            // 
            this.lblNextDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextDate.Location = new System.Drawing.Point(843, 302);
            this.lblNextDate.Name = "lblNextDate";
            this.lblNextDate.Size = new System.Drawing.Size(102, 23);
            this.lblNextDate.TabIndex = 110;
            this.lblNextDate.Text = "Next";
            this.lblNextDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstDocuments
            // 
            this.lstDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.ItemHeight = 18;
            this.lstDocuments.Location = new System.Drawing.Point(951, 361);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(281, 58);
            this.lstDocuments.TabIndex = 105;
            this.lstDocuments.SelectedIndexChanged += new System.EventHandler(this.lstDocuments_SelectedIndexChanged);
            // 
            // lblDocuments
            // 
            this.lblDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocuments.Location = new System.Drawing.Point(846, 361);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(99, 23);
            this.lblDocuments.TabIndex = 104;
            this.lblDocuments.Text = "Documents";
            this.lblDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaskCertificate
            // 
            this.txtTaskCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskCertificate.Location = new System.Drawing.Point(951, 331);
            this.txtTaskCertificate.Name = "txtTaskCertificate";
            this.txtTaskCertificate.ReadOnly = true;
            this.txtTaskCertificate.Size = new System.Drawing.Size(281, 24);
            this.txtTaskCertificate.TabIndex = 103;
            // 
            // lblEventCertificate
            // 
            this.lblEventCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCertificate.Location = new System.Drawing.Point(846, 332);
            this.lblEventCertificate.Name = "lblEventCertificate";
            this.lblEventCertificate.Size = new System.Drawing.Size(99, 23);
            this.lblEventCertificate.TabIndex = 102;
            this.lblEventCertificate.Text = "Certificate";
            this.lblEventCertificate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventStart
            // 
            this.lblEventStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStart.Location = new System.Drawing.Point(843, 274);
            this.lblEventStart.Name = "lblEventStart";
            this.lblEventStart.Size = new System.Drawing.Size(102, 23);
            this.lblEventStart.TabIndex = 101;
            this.lblEventStart.Text = "Due";
            this.lblEventStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTaskStart
            // 
            this.dtpTaskStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTaskStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTaskStart.Location = new System.Drawing.Point(951, 271);
            this.dtpTaskStart.Name = "dtpTaskStart";
            this.dtpTaskStart.Size = new System.Drawing.Size(281, 24);
            this.dtpTaskStart.TabIndex = 100;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(951, 115);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.ReadOnly = true;
            this.txtTaskDescription.Size = new System.Drawing.Size(281, 150);
            this.txtTaskDescription.TabIndex = 99;
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDescription.Location = new System.Drawing.Point(843, 116);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(102, 23);
            this.lblEventDescription.TabIndex = 98;
            this.lblEventDescription.Text = "Description";
            this.lblEventDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(951, 85);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.ReadOnly = true;
            this.txtTaskName.Size = new System.Drawing.Size(281, 24);
            this.txtTaskName.TabIndex = 97;
            // 
            // lblEventName
            // 
            this.lblEventName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(843, 85);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(102, 23);
            this.lblEventName.TabIndex = 96;
            this.lblEventName.Text = "Name";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTasks
            // 
            this.lblTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(638, 85);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(176, 23);
            this.lblTasks.TabIndex = 93;
            this.lblTasks.Text = "Tasks";
            this.lblTasks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvwTasks
            // 
            this.lvwTasks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTasks.FullRowSelect = true;
            this.lvwTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwTasks.HideSelection = false;
            this.lvwTasks.Location = new System.Drawing.Point(641, 113);
            this.lvwTasks.MultiSelect = false;
            this.lvwTasks.Name = "lvwTasks";
            this.lvwTasks.Size = new System.Drawing.Size(173, 368);
            this.lvwTasks.TabIndex = 112;
            this.lvwTasks.UseCompatibleStateImageBehavior = false;
            this.lvwTasks.View = System.Windows.Forms.View.SmallIcon;
            this.lvwTasks.SelectedIndexChanged += new System.EventHandler(this.lvwTasks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 125;
            // 
            // imlTasks
            // 
            this.imlTasks.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlTasks.ImageSize = new System.Drawing.Size(16, 16);
            this.imlTasks.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // calTasks
            // 
            this.calTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calTasks.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calTasks.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calTasks.Location = new System.Drawing.Point(12, 85);
            this.calTasks.MaximumViewDays = 42;
            this.calTasks.Name = "calTasks";
            this.calTasks.Size = new System.Drawing.Size(620, 396);
            this.calTasks.TabIndex = 111;
            this.calTasks.Text = "Tasks";
            this.calTasks.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
            this.calTasks.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calTasks_LoadItems);
            this.calTasks.ItemClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calTasks_ItemClick);
            this.calTasks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.calTasks_Scroll);
            // 
            // lblTaskCompleted
            // 
            this.lblTaskCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaskCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskCompleted.Location = new System.Drawing.Point(820, 426);
            this.lblTaskCompleted.Name = "lblTaskCompleted";
            this.lblTaskCompleted.Size = new System.Drawing.Size(125, 23);
            this.lblTaskCompleted.TabIndex = 113;
            this.lblTaskCompleted.Text = "Task Completed";
            this.lblTaskCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 493);
            this.Controls.Add(this.lblTaskCompleted);
            this.Controls.Add(this.lvwTasks);
            this.Controls.Add(this.calTasks);
            this.Controls.Add(this.txtNextDate);
            this.Controls.Add(this.lblNextDate);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnViewDocument);
            this.Controls.Add(this.lstDocuments);
            this.Controls.Add(this.lblDocuments);
            this.Controls.Add(this.txtTaskCertificate);
            this.Controls.Add(this.lblEventCertificate);
            this.Controls.Add(this.lblEventStart);
            this.Controls.Add(this.dtpTaskStart);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblEventDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.gpTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1260, 513);
            this.Name = "frmMyTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Tasks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMyTasks_FormClosing);
            this.Load += new System.EventHandler(this.frmMyTasks_Load);
            this.gpTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblReference;
        private Owf.Controls.GradientPanel gpTitle;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Calendar.Calendar calTasks;
        private System.Windows.Forms.TextBox txtNextDate;
        private System.Windows.Forms.Label lblNextDate;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnViewDocument;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.TextBox txtTaskCertificate;
        private System.Windows.Forms.Label lblEventCertificate;
        private System.Windows.Forms.Label lblEventStart;
        private System.Windows.Forms.DateTimePicker dtpTaskStart;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.ListView lvwTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imlTasks;
        private System.Windows.Forms.Label lblTaskCompleted;

    }
}