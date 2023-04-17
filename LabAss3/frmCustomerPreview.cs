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
    public partial class frmCustomerPreview : Form
    {
        public frmCustomerPreview()
        {
            InitializeComponent();
        }

        public void SetValues (String name, String Conutry,String Gender,String Hobby,String Status)
        {
            lblName.Text = Name;
            lblCountry.Text = Conutry;
            lblGender.Text = Gender;
            lblHobby.Text = Hobby;
            lblStatus.Text = Status;
        }

    }
}
