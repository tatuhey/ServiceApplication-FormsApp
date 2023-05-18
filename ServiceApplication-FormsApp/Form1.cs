using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit.Core.Input;

namespace ServiceApplication_FormsApp
{
    public partial class ServiceApplicationForm : Form
    {
        public ServiceApplicationForm()
        {
            InitializeComponent();
        }
        //6.2	Create a global List<T> of type Drone called “FinishedList”. 
        List<Drone> FinishedList = new List<Drone>();

        //6.3	Create a global Queue<T> of type Drone called “RegularService”.
        Queue<Drone> RegularService = new Queue<Drone>();

        //6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        Queue<Drone> ExpressService = new Queue<Drone>();

        #region methods
        //6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority.
        //Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost. Use a numeric up/down control for the Service Tag.
        //The new service item will be added to the appropriate Queue based on the Priority radio button.
        private void AddNewItem()
        {
            IncrementTag();
            string name = tbName.Text;
            string model = tbModel.Text;
            string problem = tbProblem.Text;
            double cost = double.Parse(tbCost.Text);
            int tag = int.Parse(numTag.Text);
            int priority = GetServicePriority();

            if (priority == 0)
            {
                Drone newRegular = new Drone();
                newRegular.setName(name);
                newRegular.setModel(model);
                newRegular.setProblem(problem);
                newRegular.setCost(cost);
                newRegular.setTag(tag);
                RegularService.Enqueue(newRegular);

                DisplayRegular();
            }

            if (priority == 1)
            {
                Drone newExpress = new Drone();
                newExpress.setName(name);
                newExpress.setModel(model);
                newExpress.setProblem(problem);
                newExpress.setCost(ExpressCost(cost));
                newExpress.setTag(tag);
                ExpressService.Enqueue(newExpress);

                DisplayExpress();
            }
        }

        //6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
        private double ExpressCost(double cost)
        {
            double expCost = cost * 115 / 100;
            return expCost;
        }

        //6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        //This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private int GetServicePriority()
        {
            ////int value = -1;
            if (rbRegular.Checked == true)
                return 0;
            if (rbExpress.Checked == true)
                return 1;
            else
                return -1;
        }

        //6.8	Create a custom method that will display all the elements in the RegularService queue.
        //The display must use a List View and with appropriate column headers.
        private void DisplayRegular()
        {
            lvRegular.Items.Clear();
            foreach (var item in RegularService)
            {
                lvRegular.Items.Add(new ListViewItem(new string[] { item.getName(), item.getModel(), item.getProblem(), "$"+item.getCost().ToString(), item.getTag().ToString() }));
            }
        }

        //6.9	Create a custom method that will display all the elements in the ExpressService queue.
        //The display must use a List View and with appropriate column headers.
        private void DisplayExpress()
        {
            lvExpress.Items.Clear();
            foreach (var item in ExpressService)
            {
                lvExpress.Items.Add(new ListViewItem(new string[] { item.getName(), item.getModel(), item.getProblem(), "$"+item.getCost().ToString(), item.getTag().ToString() }));
            }
        }

        //6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        private void ValidCostKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back || (e.KeyChar == '.' && ((TextBox)sender).Text.Contains(".")))
            {
                e.Handled = true;
            }
            else if (((TextBox)sender).Text.Contains(".") && ((TextBox)sender).Text.Split('.')[1].Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //6.11	Create a custom method to increment the service tag control,
        //this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void IncrementTag()
        {
            numTag.Increment = 10;
        }

        //6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void RegularToTextboxes()
        {
            int index = lvRegular.SelectedIndices[0];
            Drone item = RegularService.ElementAt(index);
            tbName.Text = item.getName();
            tbModel.Text = item.getModel();
            tbProblem.Text = item.getProblem();
            numTag.Text = item.getTag().ToString();
            rbRegular.Checked = true;
            tbCost.Text = item.getCost().ToString();
        }

        //6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void ExpressToTextboxes()
        {
            int index = lvExpress.SelectedIndices[0];
            Drone item = ExpressService.ElementAt(index);
            tbName.Text = item.getName();
            tbModel.Text = item.getModel();
            tbProblem.Text = item.getProblem();
            numTag.Text = item.getTag().ToString();
            rbRegular.Checked = true;
            tbCost.Text = item.getCost().ToString();
        }

        //6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        //The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void RegularToFinished()
        {
            if (RegularService.Count > 0)
            {
                Drone queue = RegularService.ElementAt(0);
                string name = queue.getName();
                double cost = queue.getCost();

                RegularService.Dequeue();
                lvRegular.Items.RemoveAt(0);

                Drone item = new Drone();
                item.setName(name);
                item.setCost(cost);
                FinishedList.Add(item);
            }

        }

        //6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        //The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void ExpressToFinished()
        {
            if (ExpressService.Count > 0)
            {
                Drone queue = ExpressService.ElementAt(0);
                string name = queue.getName();
                double cost = queue.getCost();

                ExpressService.Dequeue();
                lvExpress.Items.RemoveAt(0);

                Drone item = new Drone();
                item.setName(name);
                item.setCost(cost);
                FinishedList.Add(item);
            }

        }
        //6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void FinishedItemPay()
        {
            if (lbFinished.Items.Count > 0)
            {
                int index = lbFinished.SelectedIndex;
                if (index > -1)
                {
                    FinishedList.RemoveAt(index);
                    UpdateListBox();
                }
            }
        }

        //6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void ClearTextboxes()
        {
            tbName.Text = string.Empty;
            tbModel.Text = string.Empty;
            tbProblem.Text = string.Empty;
            numTag.Value = 100;
            tbCost.Text = string.Empty;
        }

        // Method to update the listbox when an entry is removed from either Queue<T> by adding them to List<T>. The output is formatted to add dash(-) and dollar sign.
        private void UpdateListBox()
        {
            lbFinished.Items.Clear();
            foreach (var finlist in FinishedList)
            {
                lbFinished.Items.Add(finlist.getName() + " - " + "$" + finlist.getCost());
            }
        }

        // Method to return True value if all texboxes and either radio buttons are checked, to allow data to be entered to either Queue<T>.
        private bool FilledTextboxes()
        {
            return !string.IsNullOrWhiteSpace(tbName.Text)
                && !string.IsNullOrWhiteSpace(tbModel.Text)
                && !string.IsNullOrWhiteSpace(tbProblem.Text)
                && (rbExpress.Checked || rbRegular.Checked)
                && !string.IsNullOrWhiteSpace(tbCost.Text);
        }

        // Method to allow pressing the key Enter to enter data to either Queue<T>.
        private void PressEnterToEnter(object sender, KeyPressEventArgs e)
        {
            if (FilledTextboxes())
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    AddNewItem();
                    ClearTextboxes();
                }
            }
        }

        #endregion

        #region Clicks and KeyPresses
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilledTextboxes())
                {
                    AddNewItem();
                    ClearTextboxes();
                }
                else
                    MessageBox.Show("Please fill in all the necessary details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        
            catch (Exception ex)
            {
                MessageBox.Show($"Error when adding data to the queue.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                FinishedItemPay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when deleting selected entry from the finished listbox.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnRegular_Click(object sender, EventArgs e)
        {
            try
            {
                RegularToFinished();
                UpdateListBox();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when completing selected entry from the regular listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExpress_Click(object sender, EventArgs e)
        {
            try
            {
                ExpressToFinished();
                UpdateListBox();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when completing selected entry from the regular listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lbFinished_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FinishedItemPay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when deleting selected entry from the finished listbox.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void lvRegular_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                RegularToTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when selecting data from the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvExpress_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ExpressToTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when selecting data from the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to prevent any keypress for the tag value
        private void numTag_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ValidCostKeyPress(sender, e);
                PressEnterToEnter(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when adding data to the queue.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        //6.18	All code is required to be adequately commented. Map the programming criteria and features to your code/methods
        //by adding comments above the method signatures. Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).

    }
}
