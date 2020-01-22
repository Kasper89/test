using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        static public SqlCommand sqlmycommand;
        static public SqlDataAdapter sqlmyadapter;
        static public DataSet sqlmydataset;
        static public SqlConnection sqlmyconnection;
        static public SqlDataReader sqldatareader;
        static public Int64 iID, iIDtemp;
        static public string sTemp, sName, sData, sFile, sfilename;

        private void dgEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string temp = dgEmployee.CurrentRow.Cells[0].Value.ToString();
                Form1.iID = Convert.ToInt64(temp);
                tbFIO.Text = dgEmployee.CurrentRow.Cells[1].Value.ToString();
                cbFloor.Text = dgEmployee.CurrentRow.Cells[2].Value.ToString();
                dtBirth.Text = dgEmployee.CurrentRow.Cells[3].Value.ToString();
                cbTypedoc.Text = dgEmployee.CurrentRow.Cells[4].Value.ToString();
                tbSerial.Text = dgEmployee.CurrentRow.Cells[5].Value.ToString();
                dtDate.Text = dgEmployee.CurrentRow.Cells[6].Value.ToString();
                tbBy.Text = dgEmployee.CurrentRow.Cells[7].Value.ToString();
                cbTypePhone.Text = dgEmployee.CurrentRow.Cells[8].Value.ToString();
                tbPhone.Text = dgEmployee.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception except)
            {
                MessageBox.Show("Ошибка редактирования!\n" + except.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                Form1.sqlmyconnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Form1.sqlmyconnection;
                command.CommandText = @"exec [DeleteEmployee] @id";
                command.Parameters.Add("@id", SqlDbType.BigInt);
                command.Parameters["@id"].Value = Form1.iID;
                command.ExecuteNonQuery();
                Form1.sqlmyconnection.Close();
                MessageBox.Show("Сотрудник удален!");
                Form1_Load(null, null);
            }
            catch (Exception except)
            {
                MessageBox.Show("Ошибка удаления!\n" + except.Message);
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (tbSearch.Text != "")
                {
                    Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                    Form1.sqlmyconnection.Open();
                    Form1.sQuery = "select * from ViewEmployee where [Ф.И.О.] like '" + tbSearch.Text + "%'";
                    Form1.sqlmyadapter = new SqlDataAdapter(Form1.sQuery, Form1.sConnect);
                    Form1.sqlmydataset = new DataSet();
                    Form1.sqlmyadapter.Fill(Form1.sqlmydataset, "Employee");
                    dgEmployee.DataSource = Form1.sqlmydataset.Tables["Employee"].DefaultView;
                    Form1.sqlmyconnection.Close();
                }
                else
                {
                    Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                    Form1.sqlmyconnection.Open();
                    Form1.sQuery = "select * from ViewEmployee";
                    Form1.sqlmyadapter = new SqlDataAdapter(Form1.sQuery, Form1.sConnect);
                    Form1.sqlmydataset = new DataSet();
                    Form1.sqlmyadapter.Fill(Form1.sqlmydataset, "Employee");
                    dgEmployee.DataSource = Form1.sqlmydataset.Tables["Employee"].DefaultView;
                    Form1.sqlmyconnection.Close();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show("Ошибка поиска!\n" + except.Message);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Form1.sConnect))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"exec [EditEmployee] @idEmployee,@FIO,@Floor,@Date_of_Dirth,@SerialNumber,
                                            @TypeDocuments,@Date_of_issue,@issued_by,@Number,@Typetelephon";
                    command.Parameters.Add("@idEmployee", SqlDbType.BigInt);
                    command.Parameters.Add("@FIO", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@Floor", SqlDbType.NVarChar, 8);
                    command.Parameters.Add("@Date_of_Dirth", SqlDbType.Date);
                    command.Parameters.Add("@SerialNumber", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@TypeDocuments", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@Date_of_issue", SqlDbType.Date);
                    command.Parameters.Add("@issued_by", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Number", SqlDbType.NVarChar, 11);
                    command.Parameters.Add("@Typetelephon", SqlDbType.NVarChar, 10);
                    command.Parameters["@idEmployee"].Value = Form1.iID;
                    command.Parameters["@FIO"].Value = tbFIO.Text;
                    command.Parameters["@Floor"].Value = cbFloor.Text;
                    command.Parameters["@Date_of_Dirth"].Value = dtBirth.Text;
                    command.Parameters["@SerialNumber"].Value = tbSerial.Text;
                    command.Parameters["@TypeDocuments"].Value = cbTypedoc.Text;
                    command.Parameters["@Date_of_issue"].Value = dtDate.Text;
                    command.Parameters["@issued_by"].Value = tbBy.Text;
                    command.Parameters["@Number"].Value = tbPhone.Text;
                    command.Parameters["@Typetelephon"].Value = cbTypePhone.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Form1_Load(null, null);
                MessageBox.Show("Сотрудник изменен.");
            }
            catch (Exception except)
            {
                MessageBox.Show("Ошибка изменения!\n" + except.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                Form1.sqlmyconnection.Open();
                using (SqlConnection connection = new SqlConnection(Form1.sConnect))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"exec [AddEmployee] @FIO,@Floor,@Date_of_Dirth,@SerialNumber,
                                            @TypeDocuments,@Date_of_issue,@issued_by,@Number,@Typetelephon";
                    command.Parameters.Add("@FIO", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@Floor", SqlDbType.NVarChar, 8);
                    command.Parameters.Add("@Date_of_Dirth", SqlDbType.Date);
                    command.Parameters.Add("@SerialNumber", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@TypeDocuments", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@Date_of_issue", SqlDbType.Date);
                    command.Parameters.Add("@issued_by", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Number", SqlDbType.NVarChar, 11);
                    command.Parameters.Add("@Typetelephon", SqlDbType.NVarChar, 10);
                    command.Parameters["@FIO"].Value = tbFIO.Text;
                    command.Parameters["@Floor"].Value = cbFloor.Text;
                    command.Parameters["@Date_of_Dirth"].Value = dtBirth.Text;
                    command.Parameters["@SerialNumber"].Value = tbSerial.Text;
                    command.Parameters["@TypeDocuments"].Value = cbTypedoc.Text;
                    command.Parameters["@Date_of_issue"].Value = dtDate.Text;
                    command.Parameters["@issued_by"].Value = tbBy.Text;
                    command.Parameters["@Number"].Value = tbPhone.Text;
                    command.Parameters["@Typetelephon"].Value = cbTypePhone.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Сотрудник добавлен.");
                Form1_Load(null,null);
            }
            catch (Exception except)
            {
                MessageBox.Show("Ошибка добавления!\n" + except.Message);
            }
        }

        static public string sQuery, sConnect = @"Data Source=KASPER-PC;Initial Catalog=Exercise 1;Persist Security Info=True;User ID=sa;Password=111", sCommand, sBase, sServer, sUser, sPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                tbFIO.Clear();
                tbSerial.Clear();
                tbBy.Clear();
                tbPhone.Clear();
                cbFloor.Text = "Пол";
                cbTypedoc.Items.Clear();
                cbTypePhone.Items.Clear();
                Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                Form1.sqlmyconnection.Open();
                Form1.sQuery = "select * from ViewEmployee";
                Form1.sqlmyadapter = new SqlDataAdapter(Form1.sQuery, Form1.sConnect);
                Form1.sqlmydataset = new DataSet();
                Form1.sqlmyadapter.Fill(Form1.sqlmydataset, "Employee");
                dgEmployee.DataSource = Form1.sqlmydataset.Tables["Employee"].DefaultView;
                Form1.sqlmyconnection.Close();
                Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                Form1.sqlmyconnection.Open();
                Form1.sQuery = "select Name from Typedocuments";
                Form1.sqlmyadapter = new SqlDataAdapter(Form1.sQuery, Form1.sConnect);
                Form1.sqlmydataset = new DataSet();
                Form1.sqlmyadapter.Fill(Form1.sqlmydataset, "Typedocuments");
                int iDoc = Form1.sqlmydataset.Tables["Typedocuments"].Rows.Count;
                for (int i = 0; i < iDoc; i++)
                {
                    cbTypedoc.Items.Add(Form1.sqlmydataset.Tables["Typedocuments"].Rows[i][0].ToString());
                }
                Form1.sqlmyconnection.Close();
                Form1.sqlmyconnection = new SqlConnection(Form1.sConnect);
                Form1.sqlmyconnection.Open();
                Form1.sQuery = "select Name from Typetelephon";
                Form1.sqlmyadapter = new SqlDataAdapter(Form1.sQuery, Form1.sConnect);
                Form1.sqlmydataset = new DataSet();
                Form1.sqlmyadapter.Fill(Form1.sqlmydataset, "Typetelephon");
                int iPhone = Form1.sqlmydataset.Tables["Typetelephon"].Rows.Count;
                for (int i = 0; i < iPhone; i++)
                {
                    cbTypePhone.Items.Add(Form1.sqlmydataset.Tables["Typetelephon"].Rows[i][0].ToString());
                }
                Form1.sqlmyconnection.Close();
            }
            catch
            {

            }
        }
    }
}
