using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;

namespace CrossReferencePlus
{
    /// <summary>
    /// The interface between the add-in and the word functions for obtaining and adding cross-references.
    /// </summary>
    class CrossReferenceHandler
    {
        

        /// <summary>
        /// Reference to the active word application + also to the current active document.
        /// </summary>
        Microsoft.Office.Interop.Word.Application app;

        /// <summary>
        /// Reference to the current word document.
        /// </summary>
        Document doc;

        /// <summary>
        /// Type of cross-reference we're looking for.
        /// </summary>
        object referenceType = "Figure";

        public object ReferenceType
        {
            get { return referenceType; }
            set { referenceType = value; }
        }

        /// <summary>
        /// The type of information the cross-reference should display (e.g. full caption, page number, number no context).
        /// </summary>
        WdReferenceKind currentDisplayOption = WdReferenceKind.wdPageNumber;

        List<String> listOfOptionsAsString = new List<String>();
        List<WdReferenceKind> listOfOptions = new List<WdReferenceKind>();


        /// <summary>
        /// The current list of all cross-reference items of the type given (i.e. of the type specified by 'referenceType').
        /// </summary>
        Array currentCrossReferenceItems;

        /// <summary>
        /// Records the last position selected in the list of references.
        /// 
        /// e.g. the user has selected 'figures' and has 'figure 10' selected. If they switch away to 'tables' and then go back, the item
        /// selected will still be figure 10.
        /// 
        /// Key: The current reference type (whatever the contents of 'referenceType' are.
        /// Value: position in currentCrossReferenceItems array.
        /// </summary>
        Dictionary<object, int> positionHistory = new Dictionary<object, int>();

        public CrossReferenceHandler()
        {
            // Reference to current document.
            app = Globals.ThisAddIn.Application;
            doc = app.ActiveDocument;
                         
        }



        /// <summary>
        /// Given the current setting (to look for figures/numbering/etc.) get an array of all possible cross-reference items of this type.
        /// </summary>
        /// <returns></returns>
        internal Array getCrossReferences()
        {
            object crossReferenceItems = doc.GetCrossReferenceItems(ref referenceType);

            currentCrossReferenceItems = (Array)crossReferenceItems;

            return currentCrossReferenceItems;
        }

        /// <summary>
        /// Add a cross reference to the word document at the current cursor location. 
        /// <param name="i">The position of this cross reference item in the 'currentCrossReferenceItems' array.</param>
        /// </summary>
        internal void addCrossReference(int i)
        {
            i++; //index is from 1, not 0.

            if (currentCrossReferenceItems != null && currentCrossReferenceItems.Length > 0 && currentCrossReferenceItems.Length >= i)
            { //check that the index is valid.

                object itemToCrossReference = currentCrossReferenceItems.Length; //reference item to use.
                object obj = (object)i;
                app.Selection.InsertCrossReference(ref referenceType, currentDisplayOption, ref obj);
            }
            else
            {
                throw new Exception("Internal error: the index of cross reference items doesn't match with the index given by addCrossReference." +
                    "\ncurrentCrossReferenceItems size: " + currentCrossReferenceItems.Length + "; index = " + i);
            }
        }

        /// <summary>
        /// Get the list of possible display options as strings, to be displayed in the task pane.
        /// </summary>
        /// <returns></returns>
        internal List<String> getDisplayOptions()
        {
           listOfOptions.Clear();
           listOfOptionsAsString.Clear();
            

            //Only figures, tables, equations.
            if ( isACaptionedType()){
                listOfOptions.Add( WdReferenceKind.wdOnlyLabelAndNumber);
                listOfOptionsAsString.Add( "Only Label and Number");

                listOfOptions.Add( WdReferenceKind.wdEntireCaption);
                listOfOptionsAsString.Add( "Entire Caption");
                listOfOptions.Add( WdReferenceKind.wdOnlyCaptionText);
                listOfOptionsAsString.Add( "Only Caption");
  
            }

            if (referenceType.Equals(WdReferenceType.wdRefTypeNumberedItem))
            {
                listOfOptions.Add(WdReferenceKind.wdNumberNoContext);
                listOfOptionsAsString.Add("Number No Context");
                listOfOptions.Add(WdReferenceKind.wdNumberFullContext);
                listOfOptionsAsString.Add("Number Full Context");
                //listOfOptions.Add(WdReferenceKind.wdNumberRelativeContext);
                //listOfOptionsAsString.Add("Number Relative Context");
            }
            
            //Only endnotes.
            if (referenceType.Equals(WdReferenceType.wdRefTypeEndnote))
            {
                listOfOptions.Add(WdReferenceKind.wdEndnoteNumber);
                listOfOptionsAsString.Add("Endnote Number");
                listOfOptions.Add(WdReferenceKind.wdEndnoteNumberFormatted);
                listOfOptionsAsString.Add("Endnote Number Formatted");
            }

            //Only footnotes.
            if (referenceType.Equals(WdReferenceType.wdRefTypeFootnote))
            {
                listOfOptions.Add(WdReferenceKind.wdFootnoteNumber);
                listOfOptionsAsString.Add("Footnote Number");
                listOfOptions.Add(WdReferenceKind.wdFootnoteNumberFormatted);
                listOfOptionsAsString.Add("Footnote Number Formatted");
            }

            //All
            listOfOptions.Add(WdReferenceKind.wdPageNumber);
            listOfOptionsAsString.Add("Page Number");
            listOfOptions.Add(WdReferenceKind.wdContentText);
            listOfOptionsAsString.Add("Content Text");
            listOfOptions.Add(WdReferenceKind.wdPosition);
            listOfOptionsAsString.Add("Position");

            return listOfOptionsAsString;
        }

        /// <summary>
        /// Set the display option to be used for this particular cross reference.
        /// </summary>
        /// <param name="p"></param>
        

        
        internal void setCurrentDisplayOption(int p)
        {
           
                currentDisplayOption = listOfOptions[p];

        }


        /// <summary>
        /// If the type of reference selected is one which allows captions (i.e. a figure, table, or equation).
        /// </summary>
        /// <returns></returns>
        private bool isACaptionedType()
        {
            return referenceType.Equals("Figure") || referenceType.Equals("Table") || referenceType.Equals("Equation");
        }

        internal void setCurrentSelectedItem(int index)
        {
            positionHistory.Remove(referenceType);
            positionHistory.Add(referenceType, index);
        }

        /// <summary>
        /// Get the index of the item previously selected for this type of reference.
        /// 
        /// E.g. if figure 23 was selected before for the 'figures' reference type, figure 23 should be selected again.
        /// </summary>
        /// <returns></returns>
        internal int getPreviouslySelectedIndex()
        {
            if (positionHistory.ContainsKey(referenceType))
            {
                return positionHistory[referenceType];
            }
            else
            {
                return -1;
            }

        }
    }
}
