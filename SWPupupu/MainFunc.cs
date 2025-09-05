using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SWPupupu
{
    public class MainFunc
    {
        public ModelDoc2 SwAppFunc()
        {
            SldWorks swApp = (SldWorks)HeagBoKaT.HeagBoKaT.GetActiveObject("SldWorks.Application");
            ModelDoc2 swModel = (ModelDoc2)swApp.ActiveDoc;
            return swModel;
        }
    }
    }

