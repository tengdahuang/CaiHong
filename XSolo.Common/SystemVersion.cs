using System;
using System.Collections.Generic;
using System.Text;

namespace XSolo.Common
{
    public static class SystemVersion
    {
        public static int GetSystemVertion()
        {
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            int versionMajor = osInfo.Version.Major;
            return versionMajor;
        }
    }
}
