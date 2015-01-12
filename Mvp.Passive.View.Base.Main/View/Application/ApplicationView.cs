using System;
using System.ComponentModel;
using System.Windows.Forms;
using Mvp.Passive.View.Base.Main.Presenter;

namespace Mvp.Passive.View.Base.Main.View.Application
{
    public partial class ApplicationView : Form, IApplicationView
    {
        public ApplicationPresenter Presenter { set; private get; }

        public void IsWorking(bool isWorking)
        {
            this.UseWaitCursor = isWorking;
        }

        public long UserId { get; set; }

        public string FirstName{
            get { return this.textBoxFirstName.Text; }
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { this.FirstName = value; }));
                }
                else
                {
                    this.textBoxFirstName.Text = value;
                }
            }
        }

        public string Surname
        {
            get { return this.textBoxSurname.Text; }
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { this.Surname = value; }));
                }
                else
                {
                    this.textBoxSurname.Text = value;
                }
            }
        }

        public int GroupCount{
            get { return Convert.ToInt32(this.textBoxGroupCount); }
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { this.GroupCount = value; }));
                }
                else
                {
                    this.textBoxGroupCount.Text = value.ToString();
                }
            }
        }

        public ApplicationView()
        {
            InitializeComponent();
        }

        private void TextBoxValidationOnValidating(object sender, CancelEventArgs e)
        {
            var textBox = (TextBox) sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                this.textBoxValidationErrorProvider.SetError(this.textBoxValidation, "Mandatory field");
            }
        }

        private void TextBoxValidationOnValidated(object sender, EventArgs e)
        {
            this.textBoxValidationErrorProvider.SetError(this.textBoxValidation, string.Empty);
        }
    }
}
