namespace HexStringVisualizer
{
    partial class VisualizerForm
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
            this.saveServerVariables = new System.Windows.Forms.SaveFileDialog();
            this.NamesAndValues = new System.Windows.Forms.TextBox();
            this.txtOriginalString = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveServerVariables
            // 
            this.saveServerVariables.DefaultExt = "log";
            this.saveServerVariables.Filter = "Log Files|*.log|All Files|*.*";
            this.saveServerVariables.Title = "Save Server Variables Log";
            // 
            // NamesAndValues
            // 
            this.NamesAndValues.Location = new System.Drawing.Point(2, 113);
            this.NamesAndValues.Multiline = true;
            this.NamesAndValues.Name = "NamesAndValues";
            this.NamesAndValues.ReadOnly = true;
            this.NamesAndValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NamesAndValues.Size = new System.Drawing.Size(329, 117);
            this.NamesAndValues.TabIndex = 2;
            // 
            // txtOriginalString
            // 
            this.txtOriginalString.Location = new System.Drawing.Point(2, 3);
            this.txtOriginalString.Multiline = true;
            this.txtOriginalString.Name = "txtOriginalString";
            this.txtOriginalString.ReadOnly = true;
            this.txtOriginalString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalString.Size = new System.Drawing.Size(329, 104);
            this.txtOriginalString.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(132, 236);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 271);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOriginalString);
            this.Controls.Add(this.NamesAndValues);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "VisualizerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hexadecimal String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveServerVariables;
        private System.Windows.Forms.TextBox NamesAndValues;
        private System.Windows.Forms.TextBox txtOriginalString;
        private System.Windows.Forms.Button btnClose;
    }
}