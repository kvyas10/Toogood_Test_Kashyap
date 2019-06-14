using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Toogood_Test_Kashyap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable dtstandard = new DataTable();
        public DataTable dtexport = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Assuming that file read code exists

            dtstandard.Columns.Add("AccountCode");
            dtstandard.Columns.Add("Name");
            dtstandard.Columns.Add("Type");
            dtstandard.Columns.Add("Open Date");
            dtstandard.Columns.Add("Currency");

            DataRow dr = dtstandard.NewRow();

            dr[0] = "123|AbcCode";
            dr[1] = "My Account";
            dr[2] = "2";
            dr[3] = "01-01-2018";
            dr[4] = "CD";
            dtstandard.Rows.Add(dr);

            dtexport.Columns.Add("AccountCode");
            dtexport.Columns.Add("Name");
            dtexport.Columns.Add("Type");
            dtexport.Columns.Add("Open Date");
            dtexport.Columns.Add("Currency");
      

        }

        private void Btn_Standard_Click(object sender, EventArgs e)
        {
            // take input, process them and insert to export to the file.
            Type_Collection tc = new Type_Collection();
            User_Account ua = new User_Account();
            foreach(DataRow dr in dtstandard.Rows)
            {
                if (Convert.ToString(dr[0]).Contains('|'))
                {
                    string[] acode = Convert.ToString(dr[0]).Split('|');
                    if (acode.Length > 0)
                    {
                        ua.Account_Code = acode[1];
                    }
                }
                ua.Name = Convert.ToString(dr[1]);

                // get type
                string acc_type = tc.Get_Account_Type(Convert.ToString(dr[2]));
                ua.Account_Type = acc_type;
                ua.Account_Opened = Convert.ToString(dr[3]);
                string cur = tc.Get_Currency(Convert.ToString(dr[4]));
                ua.Currency = cur;

                // get values and assign to export datatable
                DataRow drex = dtexport.NewRow();
                drex["AccountCode"] = ua.Account_Code;
                drex["Name"] = ua.Name;
                drex["Type"] = ua.Account_Type;
                drex["Open Date"] = ua.Account_Opened;
                drex["Currency"] = ua.Currency;
                dtexport.Rows.Add(drex);

            }
            create_csv();
        }
        public void create_csv()
        {
            // creating csv, file will be saved in bin>debug folder
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dtexport.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in dtexport.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            File.WriteAllText("testOutput.csv", sb.ToString());
            MessageBox.Show(this,"Standard target file generated and saved in testOutput.csv at bin > debug folder Successfully");
        }
    }
}
