using Microsoft.UI.Xaml;
using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using static Microsoft.UI.Colors;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Diagnostics;


namespace SWPupupu;

public sealed partial class PageBase : Page
{
    public PageBase()
    {
        InitializeComponent();
    }


    private void Check_run()
    {
        var swModel = new MainFunc().SwAppFunc();
        int mass_type = swModel.GetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsMassPropMass);
        CustomPropertyManager propMng = swModel.Extension.CustomPropertyManager[""];
        swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitSystem, 4);
        //propMng.Add3("Масса", (int)swCustomInfoType_e.swCustomInfoText, "\"SW-Mass\"", 1); // Добавление пользовательского свойства массы, с использованием переменной mass
        //propMng.Add3("Материал", (int)swCustomInfoType_e.swCustomInfoText, "\"SW-Material\"", 1); // Добавление пользовательского свойства материала, с использованием переменной material
        propMng.Get5("Масса", false, out string _, out string mass, out bool _);
        switch (mass_type)
        {
            case 2:
                TxMass.Text = $"{mass} г";
                break;

            case 3:
                TxMass.Text = $"{mass} кг";
                break;
        }
    }


    private void kgBtn_Click(object sender, RoutedEventArgs e)
    {
        GBtn.IsEnabled = true;
        KgBtn.IsEnabled = false;
        var swModel = new MainFunc().SwAppFunc();
        swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsMassPropMass, (int)3);
        var propMng = swModel.Extension.CustomPropertyManager[""];
        Check_run();
        propMng.Get5("Масса", false, out string _, out string mass, out bool _);
        if (TxMass.Text.Split(" ")[0] == mass)
        {
            TxMass.Foreground = new SolidColorBrush(Colors.Green);
        }
        
    }

    private void gBtn_Click(object sender, RoutedEventArgs e)
    {
        KgBtn.IsEnabled = true;
        GBtn.IsEnabled = false;
        var swModel = new MainFunc().SwAppFunc();
        swModel.SetUserPreferenceIntegerValue((int)swUserPreferenceIntegerValue_e.swUnitsMassPropMass, (int)2);
        var propMng = swModel.Extension.CustomPropertyManager[""];
        Check_run();
        propMng.Get5("Масса", false, out string _, out string mass, out bool _);
        if (TxMass.Text.Split(" ")[0] == mass)
        {   
            
            TxMass.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}