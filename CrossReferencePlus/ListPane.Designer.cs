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
            this.buttonContainer = new System.Windows.Forms.SplitContainer();
            this.bNumbering = new System.Windows.Forms.Button();
            this.bFigures = new System.Windows.Forms.Button();
            this.bTables = new System.Windows.Forms.Button();
            this.bHeadings = new System.Windows.Forms.Button();
            this.bAddCrossReference = new System.Windows.Forms.Button();
            this.bDisplayOption = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonContainer)).BeginInit();
            this.buttonContainer.Panel1.SuspendLayout();
            this.buttonContainer.Panel2.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // referencesList
            // 
            this.referencesList.FormattingEnabled = true;
            this.referencesList.Location = new System.Drawing.Point(0, 125);
            this.referencesList.Name = "referencesList";
            this.referencesList.Size = new System.Drawing.Size(150, 303);
            this.referencesList.TabIndex = 0;
            // 
            // buttonContainer
            // 
            this.buttonContainer.Location = new System.Drawing.Point(0, 0);
            this.buttonContainer.Name = "buttonContainer";
            // 
            // buttonContainer.Panel1
            // 
            this.buttonContainer.Panel1.Controls.Add(this.bTables);
            this.buttonContainer.Panel1.Controls.Add(this.bNumbering);
            // 
            // buttonContainer.Panel2
            // 
            this.buttonContainer.Panel2.Controls.Add(this.bHeadings);
            this.buttonContainer.Panel2.Controls.Add(this.bFigures);
            this.buttonContainer.Size = new System.Drawing.Size(150, 59);
            this.buttonContainer.SplitterDistance = 75;
            this.buttonContainer.TabIndex = 1;
            // 
            // bNumbering
            // 
            this.bNumbering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNumbering.Location = new System.Drawing.Point(4, 4);
            this.bNumbering.Name = "bNumbering";
            this.bNumbering.Size = new System.Drawing.Size(68, 23);
            this.bNumbering.TabIndex = 0;
            this.bNumbering.Text = "Numbering";
            this.bNumbering.UseVisualStyleBackColor = true;
            this.bNumbering.Click += new System.EventHandler(this.bNumbering_Click);
            // 
            // bFigures
            // 
            this.bFigures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFigures.Location = new System.Drawing.Point(4, 4);
            this.bFigures.Name = "bFigures";
            this.bFigures.Size = new System.Drawing.Size(64, 23);
            this.bFigures.TabIndex = 0;
            this.bFigures.Text = "Figures";
            this.bFigures.UseVisualStyleBackColor = true;
            this.bFigures.Click += new System.EventHandler(this.bFigures_Click);
            // 
            // bTables
            // 
            this.bTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTables.Location = new System.Drawing.Point(4, 25);
            this.bTables.Name = "bTables";
            this.bTables.Size = new System.Drawing.Size(68, 23);
            this.bTables.TabIndex = 1;
            this.bTables.Text = "Tables";
            this.bTables.UseVisualStyleBackColor = true;
            this.bTables.Click += new System.EventHandler(this.bTables_Click);
            // 
            // bHeadings
            // 
            this.bHeadings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHeadings.Location = new System.Drawing.Point(4, 25);
            this.bHeadings.Name = "bHeadings";
            this.bHeadings.Size = new System.Drawing.Size(64, 23);
            this.bHeadings.TabIndex = 1;
            this.bHeadings.Text = "Headings";
            this.bHeadings.UseVisualStyleBackColor = true;
            this.bHeadings.Click += new System.EventHandler(this.bHeadings_Click);
            // 
            // bAddCrossReference
            // 
            this.bAddCrossReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddCrossReference.Location = new System.Drawing.Point(4, 440);
            this.bAddCrossReference.Name = "bAddCrossReference";
            this.bAddCrossReference.Size = new System.Drawing.Size(143, 27);
            this.bAddCrossReference.TabIndex = 2;
            this.bAddCrossReference.Text = "Add Cross-Reference";
            this.bAddCrossReference.UseVisualStyleBackColor = true;
            this.bAddCrossReference.Click += new System.EventHandler(this.bAddCrossReference_Click);
            // 
            // bDisplayOption
            // 
            this.bDisplayOption.FormattingEnabled = true;
            this.bDisplayOption.Location = new System.Drawing.Point(4, 65);
            this.bDisplayOption.Name = "bDisplayOption";
            this.bDisplayOption.Size = new System.Drawing.Size(143, 56);
            this.bDisplayOption.TabIndex = 3;
            // 
            // ListPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bDisplayOption);
            this.Controls.Add(this.bAddCrossReference);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.referencesList);
            this.Name = "ListPane";
            this.Size = new System.Drawing.Size(150, 467);
            this.buttonContainer.Panel1.ResumeLayout(false);
            this.buttonContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonContainer)).EndInit();
            this.buttonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox referencesList;
        private System.Windows.Forms.SplitContainer buttonContainer;
        private System.Windows.Forms.Button bNumbering;
        private System.Windows.Forms.Button bFigures;
        private System.Windows.Forms.Button bTables;
        private System.Windows.Forms.Button bHeadings;
        private System.Windows.Forms.Button bAddCrossReference;
        private System.Windows.Forms.ListBox bDisplayOption;
    }
}
