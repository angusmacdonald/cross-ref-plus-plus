using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace CrossReferencePlus
{
    public partial class ListPane : UserControl
    {


        CrossReferenceHandler handler = new CrossReferenceHandler();


        public ListPane()
        {
            InitializeComponent();
            refreshReferenceList();

            referencesList.DoubleClick += new EventHandler(referencesList_DoubleClick);
        }

        /// <summary>
        /// Refresh the sete of references displayed in the pane.
        /// </summary>
        public void refreshReferenceList()
        {
          
            //Add new references to listpane, after clearing old set.

            clearOldReferences();
            
            addNewReferences();

            updateDisplayOptions();
            
            setIndexToPrevious();

        }

        private void updateDisplayOptions()
        {
            //Update the list of display options, after clearing old set.

            List<String> displayOptions = handler.getDisplayOptions();

            foreach (String displayOption in displayOptions)
            {
                bDisplayOption.Items.Add(displayOption);
            }
        }

        private void addNewReferences()
        {
            
            Array references = handler.getCrossReferences();

            foreach (String reference in references)
            {
                referencesList.Items.Add(reference);
            }
        }

        private void clearOldReferences()
        {
            referencesList.Items.Clear();
            bDisplayOption.Items.Clear();
        }

        private void setIndexToPrevious()
        {
            //References List
            if (referencesList.Items.Count > 0)
            {
            
                //Set index to its previous position if still valid.
                int previousIndex = handler.getPreviouslySelectedIndex();

                int indexToUse = 0;

                if (previousIndex > 0 && previousIndex < referencesList.Items.Count)
                {
                    indexToUse = previousIndex;
                }

            
                referencesList.SetSelected(indexToUse, true);
            }

            //References Type List
            if (bDisplayOption.Items.Count > 0)
            {

                //Set index to its previous position if still valid.
                int previousIndex = handler.getPreviouslySelectedIndexForType();

                int indexToUse = 0;

                if (previousIndex > 0 && previousIndex < bDisplayOption.Items.Count)
                {
                    indexToUse = previousIndex;
                }


                bDisplayOption.SetSelected(indexToUse, true);
            }
        }

        private void bAddCrossReference_Click(object sender, EventArgs e)
        {
            addCrossReferenceToDocument();
        }

        private void referencesList_DoubleClick(object sender, EventArgs e)
        {

            if (referencesList.SelectedItem != null)
            {
                addCrossReferenceToDocument();
            }

        }


        private void addCrossReferenceToDocument()
        {
            //Set display option if set

            if (bDisplayOption.SelectedIndex > -1)
            {
                handler.setCurrentDisplayOption(bDisplayOption.SelectedIndex);
            }


            handler.addCrossReference(referencesList.SelectedIndex);

            //Record the current position selected in the list.
            handler.setCurrentSelectedItem(referencesList.SelectedIndex, bDisplayOption.SelectedIndex);
        }

 

        private void referencesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void bNumbering_Click(object sender, EventArgs e)
        {
            handler.ReferenceType = WdReferenceType.wdRefTypeNumberedItem;
            refreshReferenceList();
        }

        private void bFigures_Click(object sender, EventArgs e)
        {
            handler.ReferenceType = "Figure";
            refreshReferenceList();
        }

        private void bTables_Click(object sender, EventArgs e)
        {
            handler.ReferenceType = "Table";
            refreshReferenceList();
        }

        private void bHeadings_Click(object sender, EventArgs e)
        {
            handler.ReferenceType = WdReferenceType.wdRefTypeHeading;
            refreshReferenceList();
        }


    }
}
