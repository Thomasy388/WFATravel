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
    public partial class Passport : Form
    {
        public Passport()
        {
            InitializeComponent();
        }

        private void passportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.israel_3DataSet);

        }

        private void Passport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'israel_3DataSet.Passport' table. You can move, or remove it, as needed.
            this.passportTableAdapter.Fill(this.israel_3DataSet.Passport);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
