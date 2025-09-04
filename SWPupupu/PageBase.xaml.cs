using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Shapes;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Diagnostics;
using HeagBoKaT;
using Microsoft.UI.Xaml.Controls;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SWPupupu;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class PageBase : Page
{
    public PageBase()
    {
        InitializeComponent();
    }
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

    private void Test_btn_Click(object sender, RoutedEventArgs e)
    {

    }
}
