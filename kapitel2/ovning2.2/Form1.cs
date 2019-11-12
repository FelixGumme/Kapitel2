using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning2._2
{
    public partial class Form1 : Form
    {
        List<Employee> employeesList = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegisterSale_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxSellerName.Text;
                double provision = double.Parse(tbxProvision.Text);
                double seller = double.Parse(tbxSellerSale.Text);

                Seller s = new Seller(name, provision, seller);
                //add seller to list
                employeesList.Add(s);

                //print out data
                lbxRegister.Items.Add(s);
                lbxSalaryPayment.Items.Add(s + " " + s.CalculateSalary() + " kr");

                //clear all textboxes
                tbxSellerName.Clear();
                tbxProvision.Clear();
                tbxSellerSale.Clear();
            }
            catch
            {
                MessageBox.Show("Kolla din inmatning", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnRegisterWorkpass_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxConsultantName.Text;
                double hourlySalary = double.Parse(tbxHourlySalary.Text);
                double timeWorked = double.Parse(tbxTimeWorked.Text);

                Consultant c = new Consultant(name, hourlySalary, timeWorked);
                //add consultant to list
                employeesList.Add(c);

                //print out data
                lbxRegister.Items.Add(c);
                lbxSalaryPayment.Items.Add(c + " " + c.CalculateSalary() + " kr");

                //clear all textboxes
                tbxConsultantName.Clear();
                tbxHourlySalary.Clear();
                tbxTimeWorked.Clear();
            }
            catch
            {
                MessageBox.Show("Kolla din inmatning", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnMonthlySalary_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxOfficeWorkerName.Text;
                double monthlySalary = double.Parse(tbxMonthlySalary.Text);

                OfficeWorker o = new OfficeWorker(name, monthlySalary);
                //add officeworker to list
                employeesList.Add(o);

                //print out data
                lbxRegister.Items.Add(o);
                lbxSalaryPayment.Items.Add(o + " " + o.CalculateSalary() + " kr");

                //clear all textboxes
                tbxOfficeWorkerName.Clear();
                tbxMonthlySalary.Clear();
            }
            catch
            {
                MessageBox.Show("Kolla din inmatning", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnTotalSalary_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = 0.0;

                foreach (Employee x in employeesList)
                {
                    sum += x.CalculateSalary();
                }
                tbxTotalSalary.Text = sum + " Kr";
            }
            catch
            {
                MessageBox.Show("Fel uppstod när uträkningen skulle göras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Employee temp = lbxRegister.SelectedItem as Employee;
            employeesList.Remove(temp);

            //clear listboxes
            lbxRegister.Items.Clear();
            lbxSalaryPayment.Items.Clear();

            foreach(Employee x in employeesList)
            {
                lbxRegister.Items.Add(x);
                lbxSalaryPayment.Items.Add(x + " " + x.CalculateSalary() + " kr");
            }
        }
    }
}
