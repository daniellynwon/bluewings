using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class MachineFinder : Form
    {
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        public MachineFinder()
        {
            InitializeComponent();
        }

        private void MachineFinder_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public void ListSearch()
        {
            try
            {
                string sSearch = tbSearch.Text.Trim();

                sP_Machine_CommonTableAdapter.Fill(dataSetCOMMON.SP_Machine_Common, G.Pos, sSearch);

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
            if (e.ColumnIndex != 2) return;

            string sID = dataGridView1[0, e.RowIndex].Value.ToString();
            string sHo = dataGridView1[1, e.RowIndex].Value.ToString();
            string sName = dataGridView1[2, e.RowIndex].Value.ToString();
            string sModel = dataGridView1[3, e.RowIndex].Value.ToString();
            string sGroup = dataGridView1[4, e.RowIndex].Value.ToString();

            this.FormSendEvent(sID + "#1/" + sHo + "#2/" + sName + "#3/" + sModel + "#4/" + sGroup);
            this.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
