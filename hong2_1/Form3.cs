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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                int c = 1;
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from 주문상세";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "주문상세");
                DataTable 고객Table = DS.Tables["주문상세"];
                DataRow newRow = 고객Table.NewRow();

                int a = DS.Tables[0].Rows.Count;
                chview.DataSource = DS.Tables["주문상세"].DefaultView;
                order_header();



            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }

            TP.Text = "9800";



        }

        private void order_header()
        {
            chview.Columns[0].HeaderText = "일련번호";
            chview.Columns[1].HeaderText = "주문번호";
            chview.Columns[2].HeaderText = "맛";
            chview.Columns[3].HeaderText = "사이즈";
            chview.Columns[4].Visible = false;
            chview.Columns[5].Visible = false;
            chview.Columns[6].HeaderText = "스푼";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
