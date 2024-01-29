using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace hong2_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from 재고내역";

                OracleDataAdapter DBAdapter
                    = new OracleDataAdapter(commandString, connectionString);

                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "재고내역");
                dataGridView1.DataSource = DS.Tables["재고내역"].DefaultView;  //****
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void JGBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from 재고내역";

                OracleDataAdapter DBAdapter
                    = new OracleDataAdapter(commandString, connectionString);

                OracleCommandBuilder myCommandBuilder
                    = new OracleCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "재고내역");

                DataTable 재고내역Table = DS.Tables["재고내역"];
                DataRow newRow = 재고내역Table.NewRow();
                newRow["재고번호"] = JGNum.Text;
                newRow["상품명코드"] = Code.Text;
                newRow["단가"] = Convert.ToInt32(Count.Text);
                newRow["수량"] = Convert.ToInt32(bill.Text);

                재고내역Table.Rows.Add(newRow);

                DBAdapter.Update(DS, "재고내역");

                dataGridView1.DataSource = DS.Tables["재고내역"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}
