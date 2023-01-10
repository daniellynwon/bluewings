using MySql.Data.MySqlClient;
using System.Data;
using System.Net;

namespace SmartMES_Bluewings
{
    class MariaCRUD
    {
        private MySqlConnection con;
        MySqlCommand cmd;

        public MariaCRUD()
        {
            //
            // TODO: 여기에 생성자 논리를 추가합니다.
            //
        }

        //데이터 Table
        public DataTable dbDataTable(string sql, ref string msg)
        {
            try
            {
                con = new MySqlConnection(G.conStr);
                con.Open();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);

                msg = "OK";
                return dt;
            }
            catch (MySqlException ex)
            {
                msg = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //단일 한 건 Read
        public object dbRonlyOne(string sql, ref string msg)
        {
            try
            {
                con = new MySqlConnection(G.conStr);
                con.Open();

                cmd = new MySqlCommand(sql, con);
                object o = cmd.ExecuteScalar();

                msg = "OK";
                return o;
            }
            catch (MySqlException ex)
            {
                msg = ex.Message;
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //데이터 생성, 업데이트, 삭제
        public int dbCUD(string sql, ref string msg)
        {
            try
            {
                con = new MySqlConnection(G.conStr);
                con.Open();

                cmd = new MySqlCommand(sql, con);
                int cnt = cmd.ExecuteNonQuery();

                msg = "OK";
                return cnt;
            }
            catch (MySqlException ex)
            {
                msg = ex.Message;
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        //트랜잭션 로그를 기록
        public void TransLogCreate(string grade, string userID, string gubun, string pgID, string pgName, string contents)
        {
            if (grade == "A") return;

            try
            {
                con = new MySqlConnection(G.conStr);
                con.Open();

                //string sqlStr = @"INSERT INTO tb_sys_log(user_id, gubun, log_ip, pg_id, pg_name, contents) " +
                //                    "VALUES(@USERID, @GUBUN, @LOGIP, @PGID, @PGNAME, @CONTENTS)";
                string sqlStr = @"INSERT INTO tb_sys_log(user_id, gubun, log_ip, pg_id, pg_name, contents) " +
                                    "VALUES(@USERID, @GUBUN, @LOGIP, @PGID, @PGNAME, @CONTENTS) " +
                                    "ON DUPLICATE KEY UPDATE " +
                                    "log_ip = @LOGIP, pg_id = @PGID, pg_name = @PGNAME, contents = @CONTENTS";

                cmd = new MySqlCommand(sqlStr, con);
                cmd.Parameters.AddWithValue("@USERID", userID);
                cmd.Parameters.AddWithValue("@GUBUN", gubun);
                cmd.Parameters.AddWithValue("@LOGIP", GetIP());
                cmd.Parameters.AddWithValue("@PGID", pgID);
                cmd.Parameters.AddWithValue("@PGNAME", pgName);
                cmd.Parameters.AddWithValue("@CONTENTS", contents);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        private string GetIP()
        {
            string strHostName = Dns.GetHostName();

            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString() + "(" + strHostName + ")";
        }

    }
}
