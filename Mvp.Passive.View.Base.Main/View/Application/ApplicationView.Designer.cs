using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Mvp.Passive.View.Base.Main.View.Application
{
    partial class ApplicationView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxGroupCount = new System.Windows.Forms.TextBox();
            this.textBoxValidation = new System.Windows.Forms.TextBox();
            this.textBoxValidationErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(13, 13);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(13, 40);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxGroupCount
            // 
            this.textBoxGroupCount.Location = new System.Drawing.Point(13, 67);
            this.textBoxGroupCount.Name = "textBoxGroupCount";
            this.textBoxGroupCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroupCount.TabIndex = 2;
            // 
            // textBoxValidation
            // 
            this.textBoxValidation.Location = new System.Drawing.Point(13, 94);
            this.textBoxValidation.Name = "textBoxValidation";
            this.textBoxValidation.Size = new System.Drawing.Size(100, 20);
            this.textBoxValidation.TabIndex = 3;
            this.textBoxValidation.Validating += TextBoxValidationOnValidating;
            this.textBoxValidation.Validated += TextBoxValidationOnValidated;
            // 
            // textBoxValidationErrorProvider
            //
            textBoxValidationErrorProvider.SetIconAlignment(this.textBoxValidation, ErrorIconAlignment.MiddleRight);
            textBoxValidationErrorProvider.SetIconPadding(this.textBoxValidation, 2);
            textBoxValidationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // ApplicationView
            // 
            this.ClientSize = new System.Drawing.Size(285, 255);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxGroupCount);
            this.Controls.Add(this.textBoxValidation);
            this.Name = "ApplicationView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxGroupCount;
        private System.Windows.Forms.TextBox textBoxValidation;
        private System.Windows.Forms.ErrorProvider textBoxValidationErrorProvider;
    }
}