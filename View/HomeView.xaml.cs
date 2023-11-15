using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Modern_Real_Estate.Model;
namespace Modern_Real_Estate.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
           
        }

     

      private void AddBtn_Click(object sender, RoutedEventArgs e)
      {
         SM.HomeList.Add(new Estate(0, "Hong Fat Street", 00000, "HK", "HK", 51, 2.8, "HI"));
         this.dataGrid1.ItemsSource = SM.HomeList;
         Debug.WriteLine(SM.HomeList[0]);
      }
   }
}
