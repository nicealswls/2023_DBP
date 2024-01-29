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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectionString = "User Id=hong3; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-S5FRT3U)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
            // 실제 데이터베이스 정보로 대체해주세요.

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    // 데이터베이스 연결 열기
                    connection.Open();

                    // 데이터베이스에서 데이터 가져오기
                    string query = "SELECT  주문상세.상품맛코드,주문상세.주문코드,주문상세.결제방식,사이즈.사이즈명, 사이즈.금액 AS 사이즈금액 " +
                    "FROM 주문상세 " +
                    "INNER JOIN 사이즈 ON 주문상세.사이즈코드 = 사이즈.사이즈코드";

                    OracleCommand command = new OracleCommand(query, connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView에 데이터 바인딩
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    // 에러 메시지 처리
                }
                finally
                {
                    // 연결이 열려 있는지 확인 후 닫기
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Example: Display the cell value in a MessageBox
            MessageBox.Show("Cell Value: " + cellValue.ToString());
        }
    }
}
