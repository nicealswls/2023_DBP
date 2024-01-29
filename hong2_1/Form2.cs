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
using System.Data.Odbc;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
//using System.Data.OracleClient;

namespace hong2_1
{

    public partial class Form2 : Form
    {

        Char a;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            switch (flavorTB1.Text)
            {
                case "31요거트":
                    a = 'a';
                    break;
                case "그린티":
                    a = 'b';
                    break;
                case "레인보우":
                    a = 'c';
                    break;
                case "민트초코":
                    a = 'd';
                    break;
                case "스트로베리":
                    a = 'e';
                    break;
                case "바닐라":
                    a = 'f';
                    break;
                case "사랑에빠진":
                    a = 'g';
                    break;
                case "슈팅스타":
                    a = 'h';
                    break;
                case "아몬드 봉봉":
                    a = 'i';
                    break;
                case "엄마는 외계인":
                    a = 'j';
                    break;
                case "월넛":
                    a = 'k';
                    break;
                case "자모카 아몬드":
                    a = 'l';
                    break;
                case "체리 쥬빌레":
                    a = 'n';
                    break;
                case "초콜릿":
                    a = 'm';
                    break;
                case "초콜릿 무스":
                    a = 'o';
                    break;
                case "쿠키 앤 크림":
                    a = 'p';
                    break;
                case "피스타치오":
                    a = 'q';
                    break;
                case "솜사탕":
                    a = 'r';
                    break;
                case "초코나무 숲":
                    a = 'x';
                    break;
                default:
                    Console.WriteLine("test1 > 3");
                    break;
            }
            char c = '1';

            string connectionString1 = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            string commandString1 = "select * from 주문";
            OracleDataAdapter DBAdapter1 = new OracleDataAdapter(commandString1, connectionString1);
            OracleCommandBuilder myCommandBuilder1 = new OracleCommandBuilder(DBAdapter1);
            DataSet DS1 = new DataSet();
            DBAdapter1.Fill(DS1, "주문");
            DataTable 주문Table = DS1.Tables["주문"];
            DataRow newRow1 = 주문Table.NewRow();
            DataRow lastRow = 주문Table.Rows[주문Table.Rows.Count - 1];
            int Lasrinfo = Convert.ToInt32(lastRow[0]);

            string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select * from 주문상세";
            OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
            OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "주문상세");
            DataTable 주문상세Table = DS.Tables["주문상세"];
            DataRow newRow = 주문상세Table.NewRow();
            


             int b = DS.Tables[0].Rows.Count;
            //string max = 고객Table.AsEnumerable().Max(row => row["회원코드"])
            if (b == null)
            {
                newRow["일련번호"] = c;
                newRow["주문코드"] = c;
                newRow["금액"] = 9800;
                newRow["구매날짜"] = 0;
                newRow["상품맛코드"] = a;
                newRow["사이즈코드"] = 'p';
                newRow["스푼갯수"] = spnum.Text;
                주문상세Table.Rows.Add(newRow);
                DBAdapter.Update(DS, "주문상세");
            }
            if (b != null)
            {
                newRow["일련번호"] = b + 1;
                newRow["주문코드"] = Lasrinfo;
                newRow["금액"] = 9800;
                newRow["구매날짜"] = 0;
                newRow["상품맛코드"] = a;
                newRow["사이즈코드"] = 'p';
                newRow["스푼갯수"] = spnum.Text;
                주문상세Table.Rows.Add(newRow);
                DBAdapter.Update(DS, "주문상세");
            }






           

        }

        private void order_header()
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flavorTB1.Text = flavordb.Rows[this.flavordb.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong2; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
OracleConnection myConnection = new OracleConnection(connectionString);
                string commandString = "select * from 상품";
                OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;
                OracleDataAdapter DBAdapter = new OracleDataAdapter();
                DBAdapter.SelectCommand = myCommand;
                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "상품");

                flavordb.DataSource = DS.Tables["상품"].DefaultView;
                flavor_header();


                //회원테이블에
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

        private void flavor_header()
        {
            flavordb.Columns[0].Visible = false;
            flavordb.Columns[1].HeaderText = "상품이름";
            flavordb.Columns[2].Visible = false;
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fcancell_Click(object sender, EventArgs e)
        {

        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            form2.ShowDialog();
        }
    }
}
