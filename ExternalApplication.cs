// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

/* ElevationDrawing
 * ExternalApplication.cs
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

    public sealed partial class ExternalApplication : IExternalApplication
    {
        Result IExternalApplication.OnStartup(UIControlledApplication uic_app)
        {

            string assemblyName = Assembly.GetExecutingAssembly().Location;

            RibbonPanel panel = uic_app.CreateRibbonPanel("Узлы");

            var resimage1 = Properties.Resources.Ico;
            System.Windows.Media.Imaging.BitmapSource Ico = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap
               (resimage1.GetHbitmap(), IntPtr.Zero, System.Windows.Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(resimage1.Width, resimage1.Height));


            var pushButtonData = new PushButtonData("DrawingsPlace", "Создать листы\nс узлами", assemblyName, "STP.WallTypeDrawing.WallTypeDraw");
            pushButtonData.ToolTip = "Разместить виды узлов на новых листах";
            pushButtonData.LongDescription = "На указанных листах с планов собираюттся все используемые типы конструкций (стены, полы, потолки). " +
                "Виды узлов, связанные с этими типами размещаются на вновь созданых листах";
            pushButtonData.LargeImage = Ico;

            panel.AddItem(pushButtonData);


            //panel.Visible = CheckSystem.DateCheck(new DateTime(2019, 10, 15));

            Result result = Result.Succeeded;
            return result;



            Result result = Result.Succeeded;
            return result;
        }


        Result IExternalApplication.OnShutdown(UIControlledApplication uic_app)
        {

            Result result = Result.Succeeded;
            return result;
        }
    }
}
