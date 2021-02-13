using System.Diagnostics;

namespace googlearamavereklamatıklama
{
    public class Ebs
    {
        static Process Proc = new Process();
        static ProcessStartInfo Pinfo = new ProcessStartInfo();
        static string Dosya_Yolu="";

        public static void CommandArgumentExcute(string cml)
        {
            Pinfo.FileName = Dosya_Yolu + "\\adb.exe";
            Pinfo.Arguments = cml;
            Proc.StartInfo = Pinfo;
            Proc.Start();
        }
    }
}
