namespace CrossReferencePlus
{
    partial class ListPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.referencesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // referencesList
            // 
            this.referencesList.FormattingEnabled = true;
            this.referencesList.Location = new System.Drawing.Point(12, 34);
            this.referencesList.Name = "referencesList";
            this.referencesList.Size = new System.Drawing.Size(120, 407);
            this.referencesList.TabIndex = 0;
            // 
            // ListPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.referencesList);
            this.Name = "ListPane";
            this.Size = new System.Drawing.Size(150, 467);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox referencesList;
    }
}
