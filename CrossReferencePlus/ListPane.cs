﻿using System;
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
        }

        /// <summary>
        /// Refresh the sete of references displayed in the pane.
        /// </summary>
        public void refreshReferenceList()
        {
          
            //Add new references to listpane, after clearing old set.
            referencesList.Items.Clear();
            Array references = handler.getCrossReferences();

            foreach (String reference in references)
            {
                referencesList.Items.Add(reference);
            }

            //Update the list of display options, after clearing old set.
            bDisplayOption.Items.Clear();
            List<String> displayOptions = handler.getDisplayOptions();

            foreach (String displayOption in displayOptions)
            {
                bDisplayOption.Items.Add(displayOption);
            }

            bDisplayOption.SelectedIndex = 0;
        }

        private void bAddCrossReference_Click(object sender, EventArgs e)
        {
            //Set display option if set

            if (bDisplayOption.SelectedIndex > -1)
            {
                handler.setCurrentDisplayOption(bDisplayOption.SelectedIndex);
            }


            handler.addCrossReference(referencesList.SelectedIndex);
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
