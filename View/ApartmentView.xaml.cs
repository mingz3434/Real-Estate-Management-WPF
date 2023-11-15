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
using Modern_Real_Estate.Widgets;
using Modern_Real_Estate.Model.EstateTypes;


namespace Modern_Real_Estate.View
{
    public partial class ApartmentView : UserControl
    {
        public ApartmentView()
        {
            InitializeComponent();
        }

      private void Button_Click(object sender, RoutedEventArgs e)
      {
         OneForAll.AddEntry(dataGrid1,this,
            new Apartment(0,"",0,"","",59.6,2800000,.12f,"",2));
         dataGrid1.ItemsSource = SM.ApartmentList;
      }
   }
}
