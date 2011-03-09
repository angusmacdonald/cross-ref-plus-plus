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
            this.getCrossReferences = this.Factory.CreateRibbonButton();
            this.crossReference.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // crossReference
            // 
            this.crossReference.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.crossReference.Groups.Add(this.group1);
            this.crossReference.Label = "TabAddIns";
            this.crossReference.Name = "crossReference";
            // 
            // group1
            // 
            this.group1.Items.Add(this.getCrossReferences);
            this.group1.Label = "Cross-Reference Tools";
            this.group1.Name = "group1";
            // 
            // getCrossReferences
            // 
            this.getCrossReferences.Label = "Get Cross-References";
            this.getCrossReferences.Name = "getCrossReferences";
            this.getCrossReferences.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.getCrossReferences_Click);
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton getCrossReferences;
    }

    partial class ThisRibbonCollection
    {
        internal CrossReferenceRibbon CrossReferenceRibbon
        {
            get { return this.GetRibbon<CrossReferenceRibbon>(); }
        }
    }
}
