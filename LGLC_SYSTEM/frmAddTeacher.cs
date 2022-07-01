using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LGLC_SYSTEM
{
    public partial class frmAddTeacher : Form
    {
        public ListViewItem list = new ListViewItem();
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;

        string uID, loginID;
        frmLogin connection = new frmLogin();

        String x = "";
        Random rand = new Random();

        public frmAddTeacher()
        {
            InitializeComponent();
            cn = new SqlConnection(connection.constring);
            cn.Open();
        }

        public void dawat(string ID, string logID)
        {
            uID = ID;
            loginID = logID;
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    btnSave.Enabled = false;
        //    btnDelete.Enabled = true;
        //    enable();
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;

            enable();

            txtIDno.Text = teaacherList.FocusedItem.Text;
            txtLastName.Text = teaacherList.FocusedItem.SubItems[1].Text;
            txtMI.Text = teaacherList.FocusedItem.SubItems[2].Text;
            txtName.Text = teaacherList.FocusedItem.SubItems[3].Text;
            txtSuffix.Text = teaacherList.FocusedItem.SubItems[4].Text;
            cmbStatus.Text = teaacherList.FocusedItem.SubItems[5].Text;
            dateTimePicker1.Text = teaacherList.FocusedItem.SubItems[6].Text; 
            txtAge.Text = teaacherList.FocusedItem.SubItems[7].Text;
            txtTelephone.Text = teaacherList.FocusedItem.SubItems[8].Text;
            cmbGender.Text = teaacherList.FocusedItem.SubItems[9].Text;
            txtPBirth.Text = teaacherList.FocusedItem.SubItems[10].Text;
            txtHAddress.Text = teaacherList.FocusedItem.SubItems[11].Text;
            txtCAddress.Text = teaacherList.FocusedItem.SubItems[12].Text;
            
        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           // generateCode();

            if (txtIDno.Text == "")
            {
                generateCode();
            }
        }

        void generateCode()
        {
            string z = Convert.ToString(DateTime.Now.Year);

            for (int y = 1; y <= 2; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
                if (y == 2)
                {
                    x += "TC-";
                }

            }

            for (int y = 1; y <= 3; y++)
            {
                x += Convert.ToString(rand.Next(0, 9));
            }


            txtIDno.Text = z + "-" + x;
            if (txtIDno.Text == x)
            {
                x = null;
            }

        }

        private void frmAddTeacher_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender,e);
            disable();
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }
            

        void enable()
        {
            txtIDno.Enabled = true;
            btnGenerate.Enabled = true;
            txtName.Enabled = true;
            txtMI.Enabled = true;
            txtLastName.Enabled = true;
            txtSuffix.Enabled = true;
            cmbStatus.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtAge.Enabled = true;
            txtTelephone.Enabled = true;
            cmbGender.Enabled = true;
            txtHAddress.Enabled = true;
            txtCAddress.Enabled = true;
            txtPBirth.Enabled = true;
        }

        void disable()
        {
            txtIDno.Enabled = false;
            btnGenerate.Enabled = false;
            txtName.Enabled = false;
            txtMI.Enabled = false;
            txtLastName.Enabled = false;
            txtSuffix.Enabled = false;
            cmbStatus.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtAge.Enabled = false;
            txtTelephone.Enabled = false;
            cmbGender.Enabled = false;
            txtHAddress.Enabled = false;
            txtCAddress.Enabled = false;
            txtPBirth.Enabled = false;
        }

        void clear()
        {
            txtName.Text = "";
            txtMI.Text = "";
            txtLastName.Text = "";
            cmbStatus.Text = "";
            dateTimePicker1.Text = "";
            txtAge.Text = "";
            txtTelephone.Text = "";
            cmbGender.Text = "";
            txtHAddress.Text = "";
            txtCAddress.Text = "";
            txtPBirth.Text = "";
            txtIDno.Text = "";
        }

        public void auditrail(string ID, string action)
        {
            string sql = "insert into tbl_auditTrail(uID,actionmade,datemade) values('" + ID + "','" + action + "','" + DateTime.Now + "')";
            cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
       
            if (txtTelephone.Text.Length == 11)
            {
                if (txtIDno.Text == "" || txtName.Text == "" || txtLastName.Text == "")
                {
                    MessageBox.Show("Please input the empty fields", "Little Garden Learning Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string sql = "insert into tbl_teacher(teacherID,fname,mi,lname,tsuffix,status,bDate,age,telNo,gender,pBirth,hAddress,cAddress,date) values('" + txtIDno.Text + "','" + txtName.Text + "','" + txtMI.Text + "','" + txtLastName.Text + "','" + txtSuffix.Text + "','" + cmbStatus.Text +
                                   "','" + dateTimePicker1.Text + "','" + txtAge.Text + "','" + txtTelephone.Text + "','" + cmbGender.Text + "','" + txtPBirth.Text + "','" + txtHAddress.Text + "','" + txtCAddress.Text + "','" + DateTime.Now.ToString() + "')";
                    cm = new SqlCommand(sql, cn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Mr/Ms " + txtName.Text + " is successfully save", "Little Garden Learning Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    auditrail(uID, "Mr/Ms [" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + " " + txtSuffix.Text + "] was successfully added to the teacher list");

                    teaacherList.Items.Clear();
                    txtSearch_TextChanged(sender, e);
                    clear();
                    disable();
                    x = null;
                    cm.Dispose();
                    btnSave.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter 11 digits for contact number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            teaacherList.Items.Clear();
            string sql = "Select * from tbl_teacher where fname like '" + txtSearch.Text + "%' order by fname";
                 cm = new SqlCommand(sql, cn);
                 dr = cm.ExecuteReader();
                 while (dr.Read())
                 {
                    
                     list = teaacherList.Items.Add(dr.GetValue(0).ToString());
                     list.SubItems.Add(dr.GetValue(1).ToString());
                     list.SubItems.Add(dr.GetValue(2).ToString());
                     list.SubItems.Add(dr.GetValue(3).ToString());
                     list.SubItems.Add(dr.GetValue(4).ToString());
                     list.SubItems.Add(dr.GetValue(5).ToString());
                     list.SubItems.Add(dr.GetValue(6).ToString());
                     list.SubItems.Add(dr.GetValue(7).ToString());
                     list.SubItems.Add(dr.GetValue(8).ToString());
                     list.SubItems.Add(dr.GetValue(9).ToString());
                     list.SubItems.Add(dr.GetValue(10).ToString());
                     list.SubItems.Add(dr.GetValue(11).ToString());
                     list.SubItems.Add(dr.GetValue(12).ToString());
                     list.SubItems.Add(dr.GetValue(13).ToString());


            }
                 dr.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            x = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enable();
            btnSave.Enabled = true;
            txtIDno.Text = "";
            txtName.Text = "";
            txtMI.Text = "";
            txtSuffix.Text = "";
            txtLastName.Text = "";
            txtCAddress.Text = "";
            txtHAddress.Text = "";
            txtPBirth.Text = "";


        }

      
         
      private void btnUpdate_Click(object sender, EventArgs e) {
            btnUpdate.Enabled = true;


            if (txtIDno.Text == "" || txtName.Text == ""  || txtLastName.Text == "")
              {
                  MessageBox.Show("Please input the empty fields", "Little Garden Learning Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   return;
              }

            cm.ExecuteNonQuery();
            string sql = "Update tbl_teacher set lname = '" + txtLastName.Text + "',mi = '" + txtMI.Text + "',fname = '" + txtName.Text + "',tsuffix = '" + txtSuffix.Text + "',status = '" + cmbStatus.Text + "',bDate = '" + dateTimePicker1.Text + "',age = '" + txtAge.Text + "',telNo = '"  + txtTelephone.Text + "',gender = '" + cmbGender.Text + "',pBirth = '" + txtPBirth.Text +
                        "',hAddress = '" + txtHAddress.Text + "',cAddress = '" + txtCAddress.Text + "'"; 
               
               cm = new SqlCommand(sql, cn);
               cm.ExecuteNonQuery();
               MessageBox.Show("Mr/Ms " + txtName.Text + " is successfully update", "Little Garden Learning Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

               auditrail(uID, "Mr/Ms [" + txtName.Text + " " + txtMI.Text + " " + txtLastName.Text + "] was successfully updated to the teacher list");
            
              clear();
              frmAddTeacher_Load(sender, e);
            x = null;

                teaacherList.Items.Clear();
                  txtSearch_TextChanged(sender, e);
                  clear();
                  disable();
                  x = null;
                  cm.Dispose();
               
              
          }
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtSuffix_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtTelephone_Teacher(object sender, KeyPressEventArgs e)
        {

        }

        private void btnUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = Convert.ToString(Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dateTimePicker1.Value.Year));
        }



    }
}
