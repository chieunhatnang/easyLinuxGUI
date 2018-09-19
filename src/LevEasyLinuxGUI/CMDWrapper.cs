using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevEasyLinuxGUI
{
    class CMDWrapper
    {
        public static void runExternalExe(string filename, string arguments = null)
        {
            var process = new Process();

            process.StartInfo.FileName = filename;
            if (!string.IsNullOrEmpty(arguments))
            {
                process.StartInfo.Arguments = arguments;
            }

            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.RedirectStandardOutput = false;

            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}
