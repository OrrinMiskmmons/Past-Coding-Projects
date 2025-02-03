using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag_and_drop_example
{
    public partial class SharkDragAndDrop : Form
    {
        public SharkDragAndDrop()
        {
            InitializeComponent();
            //Allow elements to be dropped
            //onto the shark image
            picShark.AllowDrop = true;
        }

        private void SpeciesSelected(object sender, MouseEventArgs e)
        {
            Label selectedLablel = (Label)sender;
            selectedLablel.DoDragDrop(selectedLablel.Text, 
                                                    DragDropEffects.Copy);
        }

        private void DataDropCheck(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void CheckCorrectShark(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text).ToString();

            if (droppedText == "Porsche")
            {
                MessageBox.Show("Correct Car Brand Selected", "Well Done");
            }
            else
            {
                MessageBox.Show("Incorrect Selected", "Please Try Again");
            }
        }

        private void SharkDragAndDrop_Load(object sender, EventArgs e)
        {

        }
    }
}
