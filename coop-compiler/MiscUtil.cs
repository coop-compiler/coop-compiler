using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace coop_builder
{
    class MiscUtil
    {
        private static string shaUsRom = "9bef1128717f958171a4afac3ed78ee2bb4e86ce";

        public static void OpenUrl(string url)
        {
            try { Process.Start(url); }
            catch { }
        }

        public static bool ValidRom(string path)
        {
            // calculate sha
            string sha = "";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(bs);
                StringBuilder formatted = new StringBuilder(2 * hash.Length);
                foreach (byte b in hash)
                {
                    formatted.AppendFormat("{0:X2}", b);
                }
                sha = formatted.ToString();
            }

            return (sha.ToLower() == shaUsRom.ToLower());
        }

        public static bool VersionCheck(string path)
        {
            string remoteVersion = File.ReadAllText(path).Trim();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return remoteVersion == version;
        }

        public static bool IsIntelHd()
        {
            bool foundRealGpu = false;
            bool foundIntelHd = false;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject mo in searcher.Get())
            {
                PropertyData description = mo.Properties["Description"];
                if (description != null)
                {
                    string desc = description.Value.ToString().ToLower();
                    foundRealGpu = foundRealGpu || desc.Contains("nvidia");
                    foundRealGpu = foundRealGpu || desc.Contains("amd");
                    foundIntelHd = foundIntelHd || (desc.Contains("intel") && desc.Contains("hd"));
                }
            }
            return foundIntelHd && !foundRealGpu;
        }
    }
}
