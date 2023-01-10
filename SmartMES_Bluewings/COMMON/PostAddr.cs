using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SmartMES_Bluewings
{
    public partial class PostAddr : Form
    {
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        string currentPage = "1";  //현재 페이지
        string countPerPage = "50"; //1페이지당 출력 갯수(MAX 50)
        string confmKey = "WtbPKUAb3poZA%2B8TwVB9hzx03tt%2FlWKaT%2FU3fmFS1%2FIxcPbAL7ZnbchfYgV3yybDQ3F8gq5Cu5hmeVySOqvihw%3D%3D";

        public PostAddr()
        {
            InitializeComponent();
        }

        private void PostAddr_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbSearch;
        }

        private void PosAddrFind(string _keyword)
        {
            lbMsg.Text = "";
            dataGridView1.Refresh();

            try
            {
                string apiurl = "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdSearchAllService/retrieveNewAdressAreaCdSearchAllService/getNewAddressListAreaCdSearchAll";
                apiurl = apiurl + "?ServiceKey=" + confmKey + "&countPerPage=" + countPerPage + "&currentPage=" + currentPage + "&srchwrd=" + _keyword;

                WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };

                XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));

                DataSet ds = new DataSet();
                ds.ReadXml(read);

                DataRow[] rows = ds.Tables[0].Select();

                if (string.IsNullOrEmpty(rows[0]["totalCount"].ToString()))
                {
                    lbCount.Text = "검색 결과가 없습니다.";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                else if (Int32.Parse(rows[0]["totalCount"].ToString()) > 0)
                {
                    dataGridView1.DataSource = ds.Tables[1];

                    if (Int32.Parse(rows[0]["totalCount"].ToString()) > 50)
                    {
                        lbCount.Text = "검색 결과량이 너무 많습니다.";
                    }
                }

                read.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowCnt = dataGridView1.Rows.Count;

            if (rowCnt <= 0)
                lbCount.Text = "검색결과 0건";
            else
                lbCount.Text = "검색결과 " + rowCnt.ToString() + "건";
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sSearch = tbSearch.Text.Trim();

                if (string.IsNullOrEmpty(sSearch)) return;

                if (sSearch.Length < 2)
                {
                    lbMsg.Text = "2음절 이상 입력해 주세요.";
                    return;
                }

                PosAddrFind(sSearch);
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string sSearch = tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(sSearch)) return;

            if (sSearch.Length < 2)
            {
                lbMsg.Text = "2음절 이상 입력해 주세요.";
                return;
            }

            PosAddrFind(sSearch);
        }

        private void pbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X + 1, pbSearch.Location.Y + 1);
        }
        private void pbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X - 1, pbSearch.Location.Y - 1);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0) return;

            this.FormSendEvent("[" + dataGridView1[0, e.RowIndex].Value.ToString() + "] " + dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
            this.Dispose();
        }
    }
}
