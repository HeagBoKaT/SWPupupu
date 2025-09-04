using HeagBoKaT;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Shapes;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Diagnostics;


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


        private void nvSample_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer as NavigationViewItem;
            if (item != null)
            {
                switch (item.Tag.ToString())
                {
                    case "pageBase":
                        contentFrame.Navigate(typeof(PageBase));
                        break;
                    case "pageList":
                        contentFrame.Navigate(typeof(PageList));
                        break;
                    case "pageEditor":
                        contentFrame.Navigate(typeof(PageEditor));
                        break;
                    default:
                        break;
                }

            }
        }
    }
}