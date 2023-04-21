using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void frmCustomerDataEntry_Load(object sender, EventArgs e)
        {
            loadCustomer();

        }

        private void loadCustomer()
        {
            string strConnection = "Data Source=LAPTOP-BV1PLFSM;Initial Catalog=CustomerDB;User ID=sa;Password=123456;Pooling=False";
            SqlConnection objCon = new SqlConnection(strConnection);
            objCon.Open();

            string strCommand = "Select * From Customer";
            SqlCommand objCommand = new SqlCommand(strCommand, objCon);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);
            dtgCustomer.DataSource = objDataSet.Tables[0];

            objCon.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (chkPainting.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (rdoMarried.Checked) Status = "1";
            else Status = "0";

            string strConnection = "Data Source=LAPTOP-BV1PLFSM;Initial Catalog=CustomerDB;User ID=sa;Password=123456;Pooling=False";
            SqlConnection objCon = new SqlConnection(strConnection);
            objCon.Open();

            string strCommand = "UPDATE Customer SET CustomerName =@CustomerName, Country=@Country, " +
                "Gender=@Gender,Hobby=@Hobby,Married= @Married WHERE id=@id";



            SqlCommand objCommand =new SqlCommand(strCommand,objCon);
            objCommand.Parameters.AddWithValue("@CustomerName",txtName.Text.Trim());
            objCommand.Parameters.AddWithValue("@Country",cmbCountry.SelectedItem.ToString().Trim());
            objCommand.Parameters.AddWithValue("@Gender", Gender);
            objCommand.Parameters.AddWithValue("@Hobby,", Hobby);
            objCommand.Parameters.AddWithValue("@Married",Status);
            objCommand.Parameters.AddWithValue("@id",lblID.Text.Trim());
            
            objCommand.ExecuteNonQuery();
            objCon.Close();
            clearForm();
            loadCustomer();
        }

         private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    clearForm();
                    string id = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                    displayCustomer(id);
                }

        private void displayCustomer(string id)
        {
            string strConnection = "Data Source=LAPTOP-BV1PLFSM;Initial Catalog=CustomerDB;User ID=sa;Password=123456;Pooling=False";
            SqlConnection objCon = new SqlConnection(strConnection);
            objCon.Open();

            string strCommand = "Select * From Customer where id =" + id;
            SqlCommand objCommand =new SqlCommand(strCommand,objCon);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataSet);
            objCon.Close();
            lblID.Text = objDataSet.Tables[0].Rows[0][1].ToString().Trim();
            cmbCountry.Text = objDataSet.Tables[0].Rows[0][2].ToString().Trim();
            string Gender=objDataSet.Tables[0].Rows[0][3].ToString().Trim();
            if (Gender.Equals("Male")) radioMale.Checked=true;
            else radioMale.Checked=true;
            string Hobby = objDataSet.Tables[0].Rows[0][4].ToString().Trim();
            if(Hobby.Equals("Reading")) chkPainting.Checked=true;
            else chkPainting.Checked=true;
            string Married = objDataSet.Tables[0].Rows[0][5].ToString().Trim();
            if (Married.Equals("True")) rdoMarried.Checked = true;
            else rdoMarried.Checked=true;


        }
       
        private void clearForm()
        {
            txtName.Text = "";
            cmbCountry.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            chkPainting.Checked = false;
            chkReading.Checked = false;
            rdoMarried.Checked = false;
            radioUnmarried.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConnection = "Data Source=LAPTOP-BV1PLFSM;Initial Catalog=CustomerDB;User ID=sa;Password=123456;Pooling=False";
            SqlConnection objCon = new SqlConnection(strConnection);
            objCon.Open();

            string strCommand = "Delete from Customer where id ='" + lblID.Text + "'";
            SqlCommand objCommand=new SqlCommand(strCommand,objCon);
            objCommand.ExecuteNonQuery();
            objCon.Close();
            clearForm();
            loadCustomer();
        }
    }
}
