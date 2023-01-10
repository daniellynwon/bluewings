using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using ZPLPrinterProject;

namespace SmartMES_Bluewings
{
    public partial class P1C03_PROD_DONE_SUB1 : Form
    {
        public P1C02_PROD_RESULT parentWin;
        public int rowIndex;
        public P1C03_PROD_DONE_SUB1()
        {
            InitializeComponent();
        }
        private void Serial_Open()
        {
            m_SP.PortName = "COM5";//현장
                                   //m_SP.PortName = "COM4";//내노트북
            m_SP.BaudRate = 9600;
            m_SP.DataBits = 8;
            m_SP.StopBits = StopBits.One;
            m_SP.Parity = Parity.None;
            m_SP.Encoding = Encoding.Default;//한글라벨출력을 위해서 꼭 필요!!
            if (m_SP.IsOpen)
                m_SP.Close();
            m_SP.Open();
        }
        private void Serial_Close()
        {
            if (m_SP.IsOpen)
                m_SP.Close();
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            string sJobNo = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();   //생산번호.로드번호-가져올 수 없음.
            string sDate = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString()).ToString("MM-dd");  //생산일자
            string sProdNo = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();  //품목코드(포대번호)
            string sWeight = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();  // 양품량
            string str = string.Empty;

            str = "^XA^BY2,2.0^FS";
            str += "^SEE:UHANGUL.DAT^FS";
            str += "^CWJ,E:KFONT3.FNT^FS^CI26^FS";
            str += "^FO70,60^FR^GB680,4,4^FS";
            str += "^FO70,420^FR^GB680,4,4^FS";
            str += "^FO70,60^FR^GB4,360,4^FS";
            str += "^FO750,60^FR^GB4,363,4^FS";
            str += "^FO410,65^FR^GB2,360,2^FS";
            str += "^FO70,140^FR^GB340,2,2^FS";
            str += "^FO70,210^FR^GB340,2,2^FS";
            str += "^FO70,280^FR^GB340,2,2^FS";
            str += "^FO70,350^FR^GB340,2,2^FS";
            //str += "^FO450,180^BAN,90,Y,N,N ^FD sProdNo ^FS";
            str += "^FO420,180^BAN,90,Y,N,N ^FD" + sProdNo + " ^FS";

            //str += "^FO100,100 ^AJN,30,20  ^FD 로트번호: " + sJobNo + " ^FS";
            str += "^FO100,100 ^AJN,30,20  ^FD 생산번호: " + sJobNo + " ^FS";
            str += "^FO100,170 ^AJN,30,20   ^FD 생산일자: " + sDate + " ^FS";
            //str += "^FO100,240 ^AJN,30,20   ^FD 포대번호: " + sProdNo + " ^FS";
            str += "^FO100,240 ^AJN,30,20   ^FD 품목코드: " + sProdNo + " ^FS";
            str += "^FO100,310 ^AJN,30,20   ^FD 생산량: " + sWeight + " ^FS";
            //str += "^FO100,280 ^AJN,30,20   ^FD " + sWeight + " ^FS";
            //str += "^FO100,330 ^AJN,30,20   ^FD " + sDate + " ^FS";
            //str += "^FO100,390 ^AJN,30,20   ^FD " + sDate + " ^FS";
            //str += "^FO500,380 ^AJN,30,20   ^FD " + sDate + " ^FS";
            str += "^XZ";

            //try
            //{
            //    Serial_Open();
            //    for (int i = 1; i <= nud_COUNT.Value; i++)
            //    {
            //        m_SP.Write(str);
            //    }
            //    Serial_Close();
            //}
            //catch (Exception ex)
            //{
            //    //
            //}

            var bytes = Encoding.Default.GetBytes(str);  // 이거는 한글이 깨짐을 해결
            //var bytes = Encoding.ASCII.GetBytes(str);  // 이거는 한글이 깨짐
            // Send a printer-specific to the printer.

            try
            {

                //   RawPrinterHelper.SendBytesToPrinter(pd.PrinterSettings.PrinterName, bytes, bytes.Length);

                RawPrinterHelper.SendBytesToPrinter(G.bprinterName, bytes, bytes.Length);
                //RawPrinterHelper.SendBytesToPrinter("Zebra ZT230 (203 dpi)", bytes, bytes.Length);
                //RawPrinterHelper.SendBytesToPrinter("ZDesigner ZT230-200dpi ZPL (1 복사)", bytes, bytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
