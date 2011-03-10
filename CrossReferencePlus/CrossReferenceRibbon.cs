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

        Microsoft.Office.Core.MsoCTPDockPosition lastDocPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;


        private void CrossReferenceRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            createListPane();

            customTaskPane.VisibleChanged += new EventHandler(listPane_VisibleChanged);
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
           
        }

        private void tbViewPanel_Click(object sender, RibbonControlEventArgs e)
        {
            if (customTaskPane.Visible)
            {
                customTaskPane.Visible = false;
            }
            else
            {
                customTaskPane.Visible = true;
            }

        }


        /// <summary>
        /// When the list pane is closed make sure the check box on the ribbon is unticked. This is necessary because it can be closed by
        /// clicking on the close box on the pane, not just by unticking the box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listPane_VisibleChanged(object sender, EventArgs e)
        {
            Microsoft.Office.Tools.CustomTaskPane taskPane = sender as Microsoft.Office.Tools.CustomTaskPane;

            if (taskPane != null)
            {
                if (taskPane.Visible)
                {
                    //taskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
                    tbViewPanel.Checked = true;
                }
                else
                {
                    tbViewPanel.Checked = false;
                    Microsoft.Office.Core.MsoCTPDockPosition lastDocPosition = taskPane.DockPosition;
                }
            }
        }

    }
}
