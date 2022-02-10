using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coop_builder
{
    public class CmdlineUtil
    {
        public bool isUpdatedCompiler = false;
        public string workingDir = null;
        public string currentExePath = null;
        public string oldExePath = null;

        public static CmdlineUtil Get()
        {
            string[] args = Environment.GetCommandLineArgs();

            CmdlineUtil util = new CmdlineUtil();
            util.isUpdatedCompiler = false;
            util.currentExePath = args[0];
            util.workingDir = Environment.CurrentDirectory;
            util.oldExePath = null;

            // see if we're running the updated exe
            if (args.Length != 4) { return util; }
            if (args[1] != "--update-compiler") { return util; }
            if (args[2].Length == 0) { return util; }
            if (args[3].Length == 0) { return util; }
            if (!args[3].ToLower().EndsWith(".exe")) { return util; }

            util.isUpdatedCompiler = true;
            util.workingDir = args[2];
            util.oldExePath = args[3];

            return util;
        }
    }
}
