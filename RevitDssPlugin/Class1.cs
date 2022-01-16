using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//=============================
using Autodesk.Revit.Creation;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;

namespace RevitDssPlugin
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class McSetting : IExternalApplication
    {

        public Result OnShutdown(UIControlledApplication application)
        {
            throw new NotImplementedException();
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("DSS");
            
            RibbonPanel Rp = application.CreateRibbonPanel("DSS", "DecisionSystem");
            string AssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            PushButtonData PBD = new PushButtonData("BtnDSS", "Calc", AssemblyPath, "RevitDssPlugin.Class2");
            PBD.LargeImage = new BitmapImage(new Uri(@"F:\2_Articles\3_ForSubmit\DecisionSupportSystemForRevit Family\Icon\1\decision 32x32.png"));
            //PBD.Image = new BitmapImage(new Uri(@"F:\Articles\ForSubmit\DecisionSupportSystemForRevit Family\Dss.ico"));
            //PBD.LongDescription = "این پلاگین برای کمک به تصمیم گیری برای انتخاب بهترین فمیلی از بین فمیلی های دیگر با استفاده از روش های تصمیم گیری از جمله تاپسیس ، ای اچ پی ، ویکور ، ساوو ، و الکتره می باشد.";
            //PBD.ToolTip = "Decision Support System";
            //PBD.ToolTipImage = new BitmapImage(new Uri(@"F:\Articles\ForSubmit\DecisionSupportSystemForRevitFamily\DSS.jpg"));
            PushButton PB = Rp.AddItem(PBD) as PushButton;
            return Result.Succeeded;
        }
    }
}
