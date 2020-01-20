// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

/* ElevationDrawing
 * STPsystemUtils.cs
 * https://stroytekproekt.ru/
 * © Stroytekproekt, 2020
 *
 * The external application. This is the entry point of the
 * 'ElevationDrawing' (Revit add-in).
 */
#region Namespaces
using System;
using System.IO;
using System.Collections.Generic;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Resources;
using System.Reflection;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using WPF = System.Windows;
using System.Linq;
using System.Xml.Linq;
#endregion

namespace STP.ElevationDrawing
{
    public class VersionInfo
    {
        static public string Compiled()
        {
            System.Version MyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            // MyVersion.Build = days after 2000-01-01
            // MyVersion.Revision*2 = seconds after 0-hour  (NEVER daylight saving time)
            DateTime MyTime = new DateTime(2000, 1, 1).AddDays(MyVersion.Build).AddSeconds(MyVersion.Revision * 2);
            return string.Format("Version:{0}  Compiled:{1:s}", MyVersion, MyTime);
        }
    }

    public class CheckSystem
    {
        static public bool Domain()
        {
            if (Environment.UserDomainName == "MIR-PROJECT") return true;
            else return false;
        }

        static public bool Date (DateTime chekDate)
        {
            return DateTime.Now < chekDate;
        }
    }
}