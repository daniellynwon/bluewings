using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class ProdFinder : Form
    {
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;
        public string _kind;
        public string _stockFlag;

        public ProdFinder()
        {
            InitializeComponent();
        }
        private void ProdFinder_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public void ListSearch()
        {
            try
            {
                string sSearch = tbSearch.Text.Trim();
                string sGubun = cbGubun.Text;
                if (sGubun == "<전체>") sGubun = "ABCDZ";
                else sGubun = sGubun.Substring(0, 1) + "----";

                sP_Product_CommonTableAdapter.Fill(dataSetCOMMON.SP_Product_Common, sGubun, _kind, _stockFlag, sSearch);

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
        private void cbGubun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 2) return;

            this.FormSendEvent(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() + "#1/" + dataGridView1[3, e.RowIndex].Value.ToString() + "#2/" + dataGridView1[5, e.RowIndex].Value.ToString());
            this.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
