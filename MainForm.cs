using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MarginWhiteSpaceRemover.Properties;

namespace MarginWhiteSpaceRemover
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Keeps the input from being processed more than once at startup.
        /// </summary>
        private readonly bool shouldProcess;

        public MainForm()
        {
            InitializeComponent();
            BindControlsToSettings();
            shouldProcess = true;
            ProcessInputTextHandler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Automatically binds the default properties of controls to settings. The settings property must be
        /// named the same as the control it needs to bind to. The settings property name can start with a capital
        /// and still match properly named controls. Ex. Settings.Default.CheckBoxFoo will bind to the
        /// <see cref="CheckBox.Checked"/> property of a control named checkBoxFoo.
        /// </summary>
        private void BindControlsToSettings()
        {
            var settingsProperties = Settings.Default.GetType().GetProperties();

            foreach (Control control in this.GetAllChildren())
            {
                string controlNameFirstCap = control.Name.CapitalizeFirstChar();
                Type controlType = control.GetType();
                var defaultProperty = controlType.GetCustomAttribute<DefaultPropertyAttribute>();

                foreach (PropertyInfo property in settingsProperties)
                {
                    if (property.Name.Equals(controlNameFirstCap, StringComparison.Ordinal))
                        control.DataBindings.Add(defaultProperty.Name, Settings.Default, property.Name);
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Save();
            base.OnClosing(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (checkBoxMinimizeToTray.Checked)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    notifyIcon.Visible = true;
                }
                else
                {
                    Show();
                    notifyIcon.Visible = false;
                }
            }
        }

        private async void ProcessInputTextHandler(object sender, EventArgs e)
        {
            if (shouldProcess)
            {
                int tabSize = checkBoxReplaceTabs.Checked ? (int)numberBoxTabSpaces.Value : -1;
                var results = await WhiteSpaceMagic.ProcessLinesTaskAsync(richTextBoxOrig.Lines, tabSize);

                labelMarginSpace.Text = results.WhiteSpacePresence.ToString();

                labelMarginCaption.ForeColor = labelMarginSpace.ForeColor
                    = results.WhiteSpacePresence == WhiteSpacePresence.Both
                    ? Color.DarkRed
                    : SystemColors.WindowText;

                richTextBoxProcessed.Lines = results.Lines;
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            var clipboardText = Clipboard.GetText();

            if (!String.IsNullOrWhiteSpace(clipboardText) && clipboardText != richTextBoxProcessed.Text)
            {
                richTextBoxOrig.Text = clipboardText;
            }
        }

        private void richTextBoxProcessed_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxProcessed.TextLength > 0)
                Clipboard.SetText(richTextBoxProcessed.Text);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void checkBoxAutoTrim_CheckedChanged(object sender, EventArgs e)
        {
            timerUpdate.Enabled = checkBoxAutoTrim.Checked;
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
