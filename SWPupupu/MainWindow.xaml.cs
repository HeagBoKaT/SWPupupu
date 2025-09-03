<<<<<<< HEAD
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Shapes;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Diagnostics;
using HeagBoKaT;

=======
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.
>>>>>>> a13e272c2d7c60cc2e094009f9444e0dc1c8c0bb

namespace SWPupupu
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        private ModelDoc2 SwAppFunc()
        {
            SldWorks swApp = (SldWorks)HeagBoKaT.HeagBoKaT.GetActiveObject("SldWorks.Application");
            ModelDoc2 swModel = (ModelDoc2)swApp.ActiveDoc;
            return swModel;
        }

        private void Check_run()
        {
            ModelDoc2 swModel = SwAppFunc();
            int mass_type = swModel.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsMassPropMass);
            CustomPropertyManager propMng = swModel.Extension.CustomPropertyManager[""];
            swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitSystem, 4);
            propMng.Add3("Масса", (int)swCustomInfoType_e.swCustomInfoText, "\"SW-Mass\"", 1); // Добавление пользовательского свойства массы, с использованием переменной mass
            propMng.Add3("Материал", (int)swCustomInfoType_e.swCustomInfoText, "\"SW-Material\"", 1); // Добавление пользовательского свойства материала, с использованием переменной material
            propMng.Get5("Материал", false, out string _, out string mass, out bool _);
            switch (mass_type)
            {
                case 2:
                    //txMass.Text = $"{mass} �";
                    break;
                case 3:
                    //txMass.Text = $"{mass} ��";
                    break;
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Check_run();
        }


        private void tsType_Toggled(object sender, RoutedEventArgs e)
        {
            ModelDoc2 swModel = SwAppFunc();
            Debug.WriteLine("Тип изменен");
            //if (tsType.IsOn) {
            //    swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsMassPropMass, (int)3);
            //    Debug.WriteLine("кг");
            //    Check_run();
            //}
            //else
            //{
            //    swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsMassPropMass, (int)2);
            //    Debug.WriteLine("�");
            //    Check_run();
            //}
        }
    }
}

=======
    }
}
>>>>>>> a13e272c2d7c60cc2e094009f9444e0dc1c8c0bb
