using System;
using System.Windows.Forms;
using System.Collections;

namespace wpf_app
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string dataText = textBox.Text;
            if(dataText == null || dataText == "")
            {
                labelEmptyInfo.Text = "ZADANIE NIE MOŻE BYĆ PUSTE";
            }
            else
            {
                checkedListBox.Items.Add(dataText);
                textBox.Text = null;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            foreach (var item in checkedListBox.CheckedItems)
            {
                arrayList.Add(item);
            }

            foreach (var deleteItem in arrayList)
            {
                checkedListBox.Items.Remove(deleteItem);
            }
        }
    }
}
