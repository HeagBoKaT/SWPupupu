using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace SWPupupu
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nvSample_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer as NavigationViewItem;
            if (item != null)
            {
                switch (item.Tag.ToString())
                {
                    case "pageBase":
                        ContentFrame.Navigate(typeof(PageBase));
                        break;

                    case "pageList":
                        ContentFrame.Navigate(typeof(PageList));
                        break;

                    case "pageEditor":
                        ContentFrame.Navigate(typeof(PageEditor));
                        break;
                }
            }
        }
    }
}