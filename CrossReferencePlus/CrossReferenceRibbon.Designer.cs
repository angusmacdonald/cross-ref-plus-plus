namespace CrossReferencePlus
{
    partial class CrossReferenceRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CrossReferenceRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.crossReference = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tbViewPanel = this.Factory.CreateRibbonCheckBox();
            this.crossReference.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // crossReference
            // 
            this.crossReference.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.crossReference.ControlId.OfficeId = "TabReferences";
            this.crossReference.Groups.Add(this.group1);
            this.crossReference.Label = "TabReferences";
            this.crossReference.Name = "crossReference";
            // 
            // group1
            // 
            this.group1.Items.Add(this.tbViewPanel);
            this.group1.Label = "Cross-Ref Plus";
            this.group1.Name = "group1";
            // 
            // tbViewPanel
            // 
            this.tbViewPanel.Label = "Cross-Ref View";
            this.tbViewPanel.Name = "tbViewPanel";
            this.tbViewPanel.ScreenTip = "Display the cross-reference plus panel.";
            this.tbViewPanel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tbViewPanel_Click);
            // 
            // CrossReferenceRibbon
            // 
            this.Name = "CrossReferenceRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.crossReference);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CrossReferenceRibbon_Load);
            this.crossReference.ResumeLayout(false);
            this.crossReference.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab crossReference;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox tbViewPanel;
    }

    partial class ThisRibbonCollection
    {
        internal CrossReferenceRibbon CrossReferenceRibbon
        {
            get { return this.GetRibbon<CrossReferenceRibbon>(); }
        }
    }
}
