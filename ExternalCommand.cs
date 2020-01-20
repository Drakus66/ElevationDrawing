// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

/* ElevationDrawing
 * ExternalCommand.cs
 * https://stroytekproekt.ru/
 * © Stroytekproekt, 2020
 *
 * The external command.
 */
#region Namespaces
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Resources;
using System.Reflection;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using WPF = System.Windows;
using System.Linq;
#endregion

namespace STP.ElevationDrawing
{

    /// <summary>
    /// Revit external command.
    /// </summary>	
	[Transaction(TransactionMode.Manual)]
    public sealed partial class ExternalCommand : IExternalCommand
    {
        /// <summary>
        /// This method implements the external command within 
        /// Revit.
        /// </summary>
        Result IExternalCommand.Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {


            Result result = Result.Failed;
            return result;
        }
    }
}
