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
   public partial class ApartmentView : UserControl{
   
      public DataGrid dataGrid;

      public ApartmentView(){
         InitializeComponent();
         dataGrid = dataGrid1;
      }

      private void AddBtn_Click(object sender, RoutedEventArgs e)
      {
         OneForAll.AddEntry(dataGrid1,this,
            new Apartment(
                  id: SM.ApartmentList.Count,
                  streetName: tb_StreetName.Text,
                  zipCode: Convert.ToInt16(tb_ZipCode.Text),
                  city: tb_City.Text,
                  country: cb_Country.SelectedItem == null ? "" : cb_Country.SelectedItem.ToString(),
                  area: Convert.ToDouble(tb_Area.Text),
                  price: Convert.ToDouble(tb_Price.Text),
                  rate: (double)0.12f,
                  imagePath: "",
                  rooms:2
            )
         );
      }

      public void DeleteBtn_Click(object sender, RoutedEventArgs e){
         OneForAll.DeleteEntry(dataGrid1,this,(Modern_Real_Estate.Model.Estate)dataGrid1.SelectedItem);
      
      }
   }


   public static class ObjEx{
      // public static Modern_Real_Estate.Model.Estate ToEstate(this object selectedItem){
      //    return selectedItem as Estate;
      // }
   }
}
