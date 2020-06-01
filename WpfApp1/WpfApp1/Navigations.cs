using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public static class Navigations
    {
        private static List<Page> _pages = new List<Page>();
        public static MainWindow main;

        public static void NextPage(Page page)
        {
            _pages.Add(page);
            main.FrameMain.Navigate(page);
            main.LbNamePages.Content = page.Title;
        }

        public static void BackPage()
        {
            if (_pages.Count > 1)
            {
                _pages.RemoveAt(_pages.Count - 1);
                main.LbNamePages.Content = _pages[_pages.Count - 1].Title;
                main.FrameMain.GoBack();
                if (_pages.Count == 1)
                    main.BackBtn.Visibility = Visibility.Hidden;
            }
        }
    }
}
