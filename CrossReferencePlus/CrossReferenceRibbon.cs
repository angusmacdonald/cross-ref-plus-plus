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

        
        public void createListPane()
        {
            listPane = new ListPane();

            
            //If a taskpane is already being displayed, remove it.
            if ((Globals.ThisAddIn.CustomTaskPanes.Count > 0))
            {
                Globals.ThisAddIn.CustomTaskPanes.Remove(customTaskPane);
            }

            customTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(listPane, "Cross Reference Plus");
            customTaskPane.Visible = true;
        }


    }
}
