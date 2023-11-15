using Modern_Real_Estate.View;
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
using Modern_Real_Estate.Model;

/*
IsChecked="True" Checked="Home_Checked"/>
            <RadioButton Name="Apartment"   
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="Apartment_Checked"/>
            <RadioButton Name="Villa"  
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="Villa_Checked"/>
            <RadioButton Name="Townhouse"  
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="Townhouse_Checked"/>
            <RadioButton Name="Hospital"  
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="Hospital_Checked"/>
            <RadioButton Name="School"   
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="School_Checked"/>
            <RadioButton Name="University"  
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="University_Checked"/>
            <RadioButton Name="Warehouse"  
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="Warehouse_Checked"/>
            <RadioButton Name="Shop"   
                         Height="40" 
                         Margin="0, 0, 5, 0" 
                         Style="{StaticResource ButtonStyle}" Checked="Shop_Checked"/>

*/
namespace Modern_Real_Estate{
    public partial class MainWindow : Window{
      public MainWindow(){
         List<Estate> HomeList = new List<Estate>(); SM.HomeList = HomeList;
         List<Estate> ApartmentList = new List<Estate>(); SM.ApartmentList = ApartmentList;
         List<Estate> VillaList = new List<Estate>(); SM.VillaList = VillaList;
         List<Estate> TownhouseList = new List<Estate>(); SM.TownhouseList = TownhouseList;
         List<Estate> HospitalList = new List<Estate>(); SM.HospitalList = HospitalList;
         List<Estate> SchoolList = new List<Estate>(); SM.SchoolList = SchoolList;
         List<Estate> UniversityList = new List<Estate>(); SM.UniversityList = UniversityList;
         List<Estate> WarehouseList = new List<Estate>(); SM.WarehouseList = WarehouseList;
         List<Estate> ShopList = new List<Estate>(); SM.ShopList = ShopList;
         
         InitializeComponent();
      }

      void Home_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new HomeView();  }
      void Apartment_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new ApartmentView();  }
      void Villa_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new VillaView(); }
      void Townhouse_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new TownhouseView(); }
      void Hospital_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new HospitalView(); }
      void School_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new SchoolView(); }
      void University_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new UniversityView(); }
      void Warehouse_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new WarehouseView(); }
      void Shop_Checked(object sender, RoutedEventArgs e){ contentControl1.Content = new ShopView(); }
      
   }
}
