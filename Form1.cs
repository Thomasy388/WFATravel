using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATravel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pilgrimsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pilgrimsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.israel_3DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'israel_3DataSet.Passport' table. You can move, or remove it, as needed.
            this.passportTableAdapter.Fill(this.israel_3DataSet.Passport);
            // TODO: This line of code loads data into the 'israel_3DataSet.Pilgrims' table. You can move, or remove it, as needed.
            this.pilgrimsTableAdapter.Fill(this.israel_3DataSet.Pilgrims);

        }

        private void passportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPassport_Click(object sender, EventArgs e)
        {
       /*   SqlCommand check_User_Name = new SqlCommand("SELECT * FROM Passport WHERE ([IDPilgrim] = '" + iDPilgrimTextBox + "') ", conn);
            if (check_User_Name.ExecuteScalar() != null)
            {
                int UserExist = (int)check_User_Name.ExecuteScalar();
                if (UserExist > 0)
                {
                    //Username Exist    
                }
            }*/
            Passport Passport = new Passport();
            Passport.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
