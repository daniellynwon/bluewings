using MySql.Data.MySqlClient;
using OpenCvSharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1B03_RORDER_DOC : Form
    {
        public P1B03_RORDER parentWin;       
        public string sNo;
        public string sSeq;
        public string sFileName;
        public int rowIdx;

        CvCapture capture;
        IplImage src;

        public P1B03_RORDER_DOC()
        {
            InitializeComponent();
        }
        private void P1B03_RORDER_DOC_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sFileName)) //파일이 없으면...
            {
                txtPath.Text = "";
                btnRun.Enabled = false;
                btnDel.Enabled = false;
            }
            else
            {
                txtPath.Text = sFileName;
                string sEx = sFileName.Substring(sFileName.Length - 3, 3).ToLower();
                if (sEx == "jpg" || sEx == "png")
                {
                    ImageLoad();
                }
            }
        }
        private void ImageLoad()
        {
            string FileName;
            UInt32 FileSize;
            byte[] rawData;
            FileStream fs;

            MySqlConnection con = new MySqlConnection(G.conStr);
            MySqlCommand cmd = new MySqlCommand();
                        
            string sql = "SELECT doc1, doc1_size, doc1_name " +
                "from tb_rorder_sub " +
                "where rorder_id = '" + sNo + "' and rorder_seq = " + sSeq ;

            try
            {
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = sql;

                MySqlDataReader myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                {
                    myData.Close();
                    return;
                }

                myData.Read();

                FileSize = myData.GetUInt32(myData.GetOrdinal("doc1_size"));

                if (FileSize <= 0)
                {
                    myData.Close();
                    return;
                }

                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("doc1"), 0, rawData, 0, (int)FileSize);

                FileName = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                FileName = FileName + "\\" + myData.GetString(myData.GetOrdinal("doc1_name"));

                GC.Collect();
                GC.WaitForPendingFinalizers();
                FileInfo file = new FileInfo(FileName);
                file.Delete();

                fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                fs.Write(rawData, 0, (int)FileSize);
                fs.Close();

                pictureBoxIpl1.Image = Image.FromFile(FileName);

                myData.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void P1B03_RORDER_DOC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cv.ReleaseImage(src);
            if (src != null) src.Dispose();
        }

        //문서 저장
        private void DocumentSave()
        {
            MariaCRUD m = new MariaCRUD();
            string sql = string.Empty;
            string msg = string.Empty;

            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                UInt32 FileSize;
                string FileName;
                byte[] rawData;
                FileStream fs;

                MySqlConnection con = new MySqlConnection(G.conStr);
                MySqlCommand cmd = new MySqlCommand();

                try
                {
                    fs = new FileStream(@txtPath.Text, FileMode.Open, FileAccess.Read);
                    FileSize = (UInt32)fs.Length;
                    FileName = txtPath.Text.Substring(txtPath.Text.LastIndexOf("\\") + 1,
                        txtPath.Text.Length - txtPath.Text.LastIndexOf("\\") - 1);

                    rawData = new byte[FileSize];
                    fs.Read(rawData, 0, (int)FileSize);
                    fs.Close();

                    con.Open();
                    sql = "UPDATE tb_rorder_sub " +
                        "SET doc1 = @File, doc1_size = @FileSize, doc1_name = @FileName " +
                        "WHERE rorder_id = '" + sNo + "' and rorder_seq = " + sSeq;

                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@File", rawData);
                    cmd.Parameters.AddWithValue("@FileSize", FileSize);
                    cmd.Parameters.AddWithValue("@FileName", FileName);
                    cmd.ExecuteNonQuery();

                    parentWin.dataGridView1.Rows[rowIdx].Cells[23].Value = Properties.Resources.clipA;
                    parentWin.dataGridView1.Rows[rowIdx].Cells[22].Value = FileName;

                    MessageBox.Show("문서가 정상 저장되었습니다.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        //문서 실행
        private void DocumentRun()
        {
            string FileName;
            UInt32 FileSize;
            byte[] rawData;
            FileStream fs;

            MySqlConnection con = new MySqlConnection(G.conStr);
            MySqlCommand cmd = new MySqlCommand();

            string sql = "SELECT doc1, doc1_size, doc1_name " +
                "from tb_rorder_order " +
                "where rorder_id = '" + sNo + "' and rorder_seq = " + sSeq;

            try
            {
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = sql;

                MySqlDataReader myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                {
                    myData.Close();
                    return;
                }

                myData.Read();

                FileSize = myData.GetUInt32(myData.GetOrdinal("doc1_size"));

                if (FileSize <= 0)
                {
                    myData.Close();
                    return;
                }

                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("doc1"), 0, rawData, 0, (int)FileSize);

                FileName = @System.IO.Directory.GetCurrentDirectory();
                //FileName = @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //바탕화면
                FileName = FileName + "\\" + myData.GetString(myData.GetOrdinal("doc1_name"));

                GC.Collect();
                GC.WaitForPendingFinalizers();
                FileInfo file = new FileInfo(FileName);
                file.Delete();

                fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                fs.Write(rawData, 0, (int)FileSize);
                fs.Close();
                myData.Close();

                Process.Start(FileName); //문서실행
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        #region 실행, 저장, 삭제, 종료 버튼 이벤트
        private void btnRun_Click(object sender, EventArgs e)
        {
            DocumentRun();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "모든파일(*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            txtPath.Text = openFileDialog1.FileName;
            DocumentSave();

            this.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("해당 첨부파일은 영구 삭제됩니다.\r\r삭제 작업을 진행 하시겠습니까?", "첨부파일[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;


            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            MySqlConnection con = new MySqlConnection(G.conStr);

            try
            {
                con.Open();
                string sql = "UPDATE tb_rorder_sub SET doc1 = NULL, doc1_size = 0, doc1_name = null WHERE rorder_id = '" + sNo + "' and rorder_seq = " + sSeq;

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                parentWin.dataGridView1.Rows[rowIdx].Cells[23].Value = Properties.Resources.clipB;
                parentWin.dataGridView1.Rows[rowIdx].Cells[22].Value = "";

                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            finally
            {
                con.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 카메라, 캡쳐 버튼 이벤트
        private void btnCamera_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            try
            {
                timer1.Enabled = true;
                capture = CvCapture.FromCamera(CaptureDevice.DShow, 0);
                capture.SetCaptureProperty(CaptureProperty.FrameWidth, 848);
                capture.SetCaptureProperty(CaptureProperty.FrameHeight, 480);
                btnCapture.Enabled = true;
            }
            catch
            {
                timer1.Enabled = false;
            }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (src == null)
            {
                MessageBox.Show("카메라가 활성화되지 않았습니다.");
                return;
            }

            string sFile = sNo + "_" + sSeq + ".jpg";
            FileInfo file_info = new FileInfo(sFile);
            
            txtPath.Text = file_info.FullName;

            Cv.SaveImage(sFile, src);
            timer1.Enabled = false;

            //

            DialogResult dr = MessageBox.Show("해당 이미지를 시스템에 저장하시겠습니?\r\r기존의 파일은 영구 삭제됩니다.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                DocumentSave();
                this.Close();
            }
            else
            {
                txtPath.Text = "";
                pictureBoxIpl1.ImageIpl = null;
            }

            try
            {
                file_info.Delete();
            }
            catch (System.IO.IOException)
            {
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            src = capture.QueryFrame();
            pictureBoxIpl1.ImageIpl = src;
        }
        #endregion
    }
}
