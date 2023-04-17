using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class frmCustomerDataEntry : Form
    {
        public frmCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";

            if (radioMale.Checked) Gender = "Male";
            else Gender = "female";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (rdoMarried.Checked) Status = "Married";
            else Status = "Unmarried";

            try
            {
                CustomerValidation objVal = new CustomerValidation();
                objVal.CheckCustomerName(txtName.Text);

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            

            frmCustomerPreview objPreview = new frmCustomerPreview();
            objPreview.SetValues(txtName.Text, cmbCountry.Text, Gender, Hobby, Status);
            objPreview.ShowDialog();
        }
    }
}
