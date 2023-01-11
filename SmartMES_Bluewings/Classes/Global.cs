using System.Configuration;

namespace SmartMES_Bluewings
{
    public static class G
    {
        public static string Pos;
        public static string ComName;
        public static string PosName;

        public static string UserID;
        public static string UserName;
        public static string Authority;

        public static string conStr = ConfigurationManager.ConnectionStrings["SmartMES_Bluewings.Properties.Settings.Bluewings_mesConnectionString"].ConnectionString;
        //public static string conStr = "server=db.mes.innobe.co.kr;user id=bluewings;password=bluewings!;database=bluewings_mes;SSL Mode=None";
        public static string bprinterName = ConfigurationManager.AppSettings["BPrinterName"];
         
    }
}
