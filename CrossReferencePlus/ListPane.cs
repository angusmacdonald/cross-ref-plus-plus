using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrossReferencePlus
{
    public partial class ListPane : UserControl
    {
        public ListPane()
        {
            InitializeComponent();
        }

        public void addReferenceList(Array references)
        {
            foreach (String r in references){

                 referencesList.Items.Add(r);
            }
        }
    }
}
