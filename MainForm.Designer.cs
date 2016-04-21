namespace MarginWhiteSpaceRemover
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBoxSettings;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkBoxMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoTrim = new System.Windows.Forms.CheckBox();
            this.numberBoxTabSpaces = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxReplaceTabs = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelMarginCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMarginSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBoxProcessed = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxOrig = new System.Windows.Forms.RichTextBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxSettings = new System.Windows.Forms.GroupBox();
            groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxTabSpaces)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBoxSettings.Controls.Add(this.checkBoxMinimizeToTray);
            groupBoxSettings.Controls.Add(this.checkBoxAutoTrim);
            groupBoxSettings.Controls.Add(this.numberBoxTabSpaces);
            groupBoxSettings.Controls.Add(this.label1);
            groupBoxSettings.Controls.Add(this.checkBoxReplaceTabs);
            groupBoxSettings.Location = new System.Drawing.Point(481, 12);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new System.Drawing.Size(208, 435);
            groupBoxSettings.TabIndex = 7;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Settings";
            // 
            // checkBoxMinimizeToTray
            // 
            this.checkBoxMinimizeToTray.AutoSize = true;
            this.checkBoxMinimizeToTray.Location = new System.Drawing.Point(6, 67);
            this.checkBoxMinimizeToTray.Name = "checkBoxMinimizeToTray";
            this.checkBoxMinimizeToTray.Size = new System.Drawing.Size(108, 17);
            this.checkBoxMinimizeToTray.TabIndex = 7;
            this.checkBoxMinimizeToTray.Text = "Minimize To Tray";
            this.checkBoxMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoTrim
            // 
            this.checkBoxAutoTrim.AutoSize = true;
            this.checkBoxAutoTrim.Location = new System.Drawing.Point(6, 44);
            this.checkBoxAutoTrim.Name = "checkBoxAutoTrim";
            this.checkBoxAutoTrim.Size = new System.Drawing.Size(129, 17);
            this.checkBoxAutoTrim.TabIndex = 6;
            this.checkBoxAutoTrim.Text = "Auto-Trim Clipboard";
            this.checkBoxAutoTrim.UseVisualStyleBackColor = true;
            this.checkBoxAutoTrim.CheckedChanged += new System.EventHandler(this.checkBoxAutoTrim_CheckedChanged);
            // 
            // numberBoxTabSpaces
            // 
            this.numberBoxTabSpaces.Location = new System.Drawing.Point(90, 98);
            this.numberBoxTabSpaces.Name = "numberBoxTabSpaces";
            this.numberBoxTabSpaces.Size = new System.Drawing.Size(78, 22);
            this.numberBoxTabSpaces.TabIndex = 4;
            this.numberBoxTabSpaces.ValueChanged += new System.EventHandler(this.ProcessInputTextHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spaces in Tab ";
            // 
            // checkBoxReplaceTabs
            // 
            this.checkBoxReplaceTabs.AutoSize = true;
            this.checkBoxReplaceTabs.Location = new System.Drawing.Point(6, 21);
            this.checkBoxReplaceTabs.Name = "checkBoxReplaceTabs";
            this.checkBoxReplaceTabs.Size = new System.Drawing.Size(149, 17);
            this.checkBoxReplaceTabs.TabIndex = 5;
            this.checkBoxReplaceTabs.Text = "Replace tab with spaces";
            this.checkBoxReplaceTabs.UseVisualStyleBackColor = true;
            this.checkBoxReplaceTabs.CheckedChanged += new System.EventHandler(this.ProcessInputTextHandler);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMarginCaption,
            this.labelMarginSpace});
            this.statusStrip.Location = new System.Drawing.Point(0, 458);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(701, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // labelMarginCaption
            // 
            this.labelMarginCaption.Name = "labelMarginCaption";
            this.labelMarginCaption.Size = new System.Drawing.Size(82, 17);
            this.labelMarginCaption.Text = "Margin Space:";
            // 
            // labelMarginSpace
            // 
            this.labelMarginSpace.Name = "labelMarginSpace";
            this.labelMarginSpace.Size = new System.Drawing.Size(36, 17);
            this.labelMarginSpace.Text = "None";
            // 
            // richTextBoxProcessed
            // 
            this.richTextBoxProcessed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxProcessed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxProcessed.Location = new System.Drawing.Point(3, 220);
            this.richTextBoxProcessed.Name = "richTextBoxProcessed";
            this.richTextBoxProcessed.ReadOnly = true;
            this.richTextBoxProcessed.Size = new System.Drawing.Size(457, 212);
            this.richTextBoxProcessed.TabIndex = 2;
            this.richTextBoxProcessed.Text = "";
            this.richTextBoxProcessed.WordWrap = false;
            this.richTextBoxProcessed.TextChanged += new System.EventHandler(this.richTextBoxProcessed_TextChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.richTextBoxProcessed, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.richTextBoxOrig, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(463, 435);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // richTextBoxOrig
            // 
            this.richTextBoxOrig.AcceptsTab = true;
            this.richTextBoxOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOrig.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxOrig.Name = "richTextBoxOrig";
            this.richTextBoxOrig.Size = new System.Drawing.Size(457, 211);
            this.richTextBoxOrig.TabIndex = 1;
            this.richTextBoxOrig.Text = "";
            this.richTextBoxOrig.WordWrap = false;
            this.richTextBoxOrig.TextChanged += new System.EventHandler(this.ProcessInputTextHandler);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Margin White Space Remover";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(93, 26);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(92, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 480);
            this.Controls.Add(groupBoxSettings);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "Margin White Space Remover";
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxTabSpaces)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.contextMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelMarginCaption;
        private System.Windows.Forms.ToolStripStatusLabel labelMarginSpace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberBoxTabSpaces;
        private System.Windows.Forms.CheckBox checkBoxReplaceTabs;
        private System.Windows.Forms.RichTextBox richTextBoxProcessed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.RichTextBox richTextBoxOrig;
        private System.Windows.Forms.CheckBox checkBoxAutoTrim;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.CheckBox checkBoxMinimizeToTray;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

