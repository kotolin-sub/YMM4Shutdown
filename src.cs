using System;
using System.Diagnostics;
using YukkuriMovieMaker.Plugin;
using YukkuriMovieMaker.Plugin.Voice;

namespace YMM4Danger
{
    public class YMM4Danger : IPlugin
    {
        public string Name => "ShutDown";


        static void command()
        {
            var com = new ProcessStartInfo("shutdown", "shutdown /s /t 0");
            Process.Start(com);
        }

    }
}
