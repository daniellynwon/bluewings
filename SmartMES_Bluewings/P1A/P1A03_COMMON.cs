using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A03_COMMON : SmartMES_Bluewings.FormBasic
    {
        public P1A03_COMMON()
        {
            InitializeComponent();
        }
        private void P1A03_COMMON_Load(object sender, EventArgs e)
        {
            lblSubject.Text = btnB.Text;
            lblSubject.Tag = btnB.Tag;
            ListSearch();
        }

        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sKind = lblSubject.Tag.ToString();

                sP_Common_QueryTableAdapter.Fill(dataSetP1A.SP_Common_Query, sKind);
                var data = dataSetP1A.SP_Common_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1A03_COMMON_SUB sub = new P1A03_COMMON_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.kind = lblSubject.Tag.ToString();
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        #region Select Bar Events
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblSubject.Text = btn.Text;
            lblSubject.Tag = btn.Tag;

            ListSearch();
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 3) return;

            P1A03_COMMON_SUB sub = new P1A03_COMMON_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            sub.kind = lblSubject.Tag.ToString();
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}
