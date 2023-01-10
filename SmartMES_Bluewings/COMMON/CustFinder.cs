using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class CustFinder : Form
    {
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;
        public string _gubun;

        public CustFinder()
        {
            InitializeComponent();
        }

        private void CustFinder_Load(object sender, EventArgs e)
        {
            if (_gubun == "103") lblGubun.Text = "매출처";
            else lblGubun.Text = "매입처";

            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public void ListSearch()
        {
            try
            {
                string sSearch = tbSearch.Text.Trim();

                sP_Customer_CommonTableAdapter.Fill(dataSetCOMMON.SP_Customer_Common, sSearch, _gubun);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X + 1, pbSearch.Location.Y + 1);
        }
        private void pbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X - 1, pbSearch.Location.Y - 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            this.FormSendEvent(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() + "#1/" + dataGridView1[1, e.RowIndex].Value.ToString() + "#2/" + dataGridView1[2, e.RowIndex].Value.ToString());
            this.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
