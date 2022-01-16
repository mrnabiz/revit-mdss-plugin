using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//=============================
using Autodesk.Revit.UI;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using UIApplication = Autodesk.Revit.UI.UIApplication;
using Application = Autodesk.Revit.Creation.Application;
using Autodesk.Revit.DB;

namespace RevitDssPlugin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    class Class2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            DssSoftware.Form1 frm = new DssSoftware.Form1();
            frm.Show();
            return Result.Succeeded;
        }
    }
}
