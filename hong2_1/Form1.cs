using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.DataAccess.Client;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hong2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
         


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int c = 1;
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from 고객";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "고객");
                DataTable 고객Table = DS.Tables["고객"];
                DataRow newRow = 고객Table.NewRow();

               int a = DS.Tables[0].Rows.Count;
                //string max = 고객Table.AsEnumerable().Max(row => row["회원코드"])
                if(a == null)
                {
                    newRow["회원코드"] = c;
                    고객Table.Rows.Add(newRow);
                    DBAdapter.Update(DS, "고객");
                }
                if (a != null)
                { 
                    newRow["회원코드"] = a+1;
                    고객Table.Rows.Add(newRow);
                    DBAdapter.Update(DS, "고객");
                }
               


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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                char c = '1';
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from 주문";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "주문");
                DataTable 주문Table = DS.Tables["주문"];
                DataRow newRow = 주문Table.NewRow();

                int a = DS.Tables[0].Rows.Count;
                //string max = 고객Table.AsEnumerable().Max(row => row["회원코드"])
                if (a == null)
                {
                    newRow["주문코드"] = c;
                    newRow["회원코드"] = c;
                    주문Table.Rows.Add(newRow);
                    DBAdapter.Update(DS, "주문");
                }
                if (a != null)
                {
                    newRow["주문코드"] = a + 1;
                    newRow["회원코드"] = a + 1;
                    주문Table.Rows.Add(newRow);
                    DBAdapter.Update(DS, "주문");
                }

            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }


            Form2_1 form2 = new Form2_1();
            form2.ShowDialog();



        }

        private void 재고확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.ShowDialog();
        }

        private void 재고주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form4 = new Form5();
            form4.ShowDialog();
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 매출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
