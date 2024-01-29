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
    public partial class Form4 : Form
    {
        //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int SelectedRowIndex;
        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;
        // DataSet 객체입니다.
        DataSet DS;
        // 추가, 수정, 삭제시에 필요한 명령문을
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;
        // DataTable 객체입니다.
        DataTable 재고내역Table;
        // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        private int SelectedKeyValue;
        public Form4()
        {
            InitializeComponent();
            DB_Open();//*
        }


        private void ClearTextBoxes()
        {
            JGNum.Clear();
            Code.Clear();
            Count.Clear();
            bill.Clear();
        }
        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=hong2;Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
                string commandString = "select * from 재고내역";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();//****
                DBAdapter.Fill(DS, "재고내역");//****
                DataTable 재고내역Table = DS.Tables["재고내역"];
                if (e.RowIndex < 0)
                {
                    // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                    // 아무 메시지도 띄우지 않습니다.
                    return;
                }
                else if (e.RowIndex > 재고내역Table.Rows.Count - 1)
                {
                    MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                    return;
                }
                DataRow currRow = 재고내역Table.Rows[e.RowIndex];
                JGNum.Text = currRow["재고번호"].ToString();
                Code.Text = currRow["상품명코드"].ToString();
                Count.Text = currRow["수량"].ToString();
                bill.Text = currRow["단가"].ToString();
                SelectedRowIndex = Convert.ToInt32(currRow["재고번호"]);
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
                DS.Clear();//***
                DBAdapter.Fill(DS, "재고내역");
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

        private void search_Click(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "재고내역");
            재고내역Table = DS.Tables["재고내역"];
            DataRow[] ResultRows = 재고내역Table.Select("상품명코드 like '%" + txtSearch.Text + "%'");
            NameList.Items.Clear();
            foreach (DataRow currRow in ResultRows)
            {
                NameList.Items.Add(currRow["재고번호"].ToString() + " " + currRow["상품명코드"].ToString());
            }
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != 0)
            {
                NameList.SelectedIndex = NameList.SelectedIndex - 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 처음입니다.");
            }
        }

        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "재고내역");
            재고내역Table = DS.Tables["재고내역"];
            DataRow[] ResultRows = 재고내역Table.Select("상품명코드 like '%" + txtSearch.Text + "%'");
            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = 재고내역Table.Columns["재고번호"];
            재고내역Table.PrimaryKey = PrimaryKey;
            DataRow currRow = 재고내역Table.Rows.Find(NameList.Text.Substring(0, 2));//*

            SelectedKeyValue = Convert.ToInt32(currRow["재고번호"].ToString());
            JGNum.Text = currRow["재고번호"].ToString();
            Code.Text = currRow["상품명코드"].ToString();
            Count.Text = currRow["수량"].ToString();
            bill.Text = currRow["단가"].ToString();
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != NameList.Items.Count - 1)
            {
                NameList.SelectedIndex = NameList.SelectedIndex + 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 마지막입니다.");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력하셨으면 추가합니다!");
                DS.Clear();///***
                DBAdapter.Fill(DS, "재고내역");
                재고내역Table = DS.Tables["재고내역"];//****
                DataRow newRow = 재고내역Table.NewRow();
                newRow["재고번호"] = JGNum.Text;
                newRow["상품명코드"] = Code.Text;
                newRow["수량"] = Convert.ToInt32(Count.Text);
                newRow["단가"] = Convert.ToInt32(bill.Text);

                재고내역Table.Rows.Add(newRow);
                DBAdapter.Update(DS, "재고내역");
                DS.AcceptChanges();//***
                ClearTextBoxes(); //***
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "재고내역");
                재고내역Table = DS.Tables["재고내역"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = 재고내역Table.Columns["재고번호"];
                재고내역Table.PrimaryKey = PrimaryKey;
                DataRow currRow = 재고내역Table.Rows.Find(SelectedRowIndex);
                currRow.BeginEdit();
                currRow["재고번호"] = JGNum.Text;
                currRow["상품명코드"] = Code.Text;
                currRow["수량"] = Convert.ToInt32(Count.Text);
                currRow["단가"] = Convert.ToInt32(bill.Text);

                currRow.EndEdit();
                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    DBAdapter.Update(UpdatedSet, "재고내역");
                    DS.AcceptChanges();
                }
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear();///***
                DBAdapter.Fill(DS, "재고내역");
                재고내역Table = DS.Tables["재고내역"];//*
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = 재고내역Table.Columns["재고번호"];
                재고내역Table.PrimaryKey = PrimaryKey;
                DataRow currRow = 재고내역Table.Rows.Find(SelectedRowIndex);
                currRow.Delete();
                DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "재고내역");
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
