using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_ORDER_SUB1 : Form
    {
        public P1C01_PROD_ORDER parentWin;
        private int rowIndex = 0;
        public string sRecipe;

        public P1C01_PROD_ORDER_SUB1()
        {
            InitializeComponent();
        }

        private void P1C01_PROD_ORDER_SUB1_Load(object sender, EventArgs e)
        {
            sP_RecipeDetail_QueryTableAdapter.Fill(dataSetP1C.SP_RecipeDetail_Query, sRecipe);

            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();
        }

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 1) return;

            try
            {
                string sCodeA = dataGridView1.Rows[0].Cells[2].Value.ToString();

                for (int i = 1; i < dataGridView1.RowCount; i++)
                {
                    if (sCodeA == dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
                    }
                    sCodeA = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")  // 비율이 0이면 안보이게 하기.
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion
    }
}
