using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Word;

namespace CrossReferencePlus
{
    public partial class CrossReferenceRibbon
    {

        private ListPane listPane;
        private static Microsoft.Office.Tools.CustomTaskPane customTaskPane;
        
        private void CrossReferenceRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            createListPane();
        }

        private void getCrossReferences_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = Globals.ThisAddIn.Application;

            Document doc = app.ActiveDocument;

            //Get possible cross-references
            object referenceType = "Figure"; // Get heading cross-references
            WdReferenceKind contextOfReference = WdReferenceKind.wdEntireCaption; //e.g. full label, number, page, etc...

            object crossReferenceItems = doc.GetCrossReferenceItems(ref referenceType);

            Array arrayOfCrossReferenceItems = (Array)crossReferenceItems;

            listPane.addReferenceList(arrayOfCrossReferenceItems);


            if (arrayOfCrossReferenceItems.Length > 0)
            {

                // take the last one, because it was just added before

                object itemToCrossReference = arrayOfCrossReferenceItems.Length; //reference item to use.

                app.Selection.InsertCrossReference(ref referenceType, contextOfReference, ref itemToCrossReference);
            }
        }

        public void createListPane()
        {
            listPane = new ListPane();

            
            //If a taskpane is already being displayed, remove it.
            if ((Globals.ThisAddIn.CustomTaskPanes.Count > 0))
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(customTaskPane);
            }

            customTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(listPane, "Frequency Analyzer Results");
            customTaskPane.Visible = true;
        }


    }
}
