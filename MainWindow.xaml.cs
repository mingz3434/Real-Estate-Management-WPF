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
using Modern_Real_Estate.Widgets;
using System.Diagnostics;

namespace Modern_Real_Estate{

   public partial class MainWindow : Window{

      public HomeView homeViewIns = null;
      public ApartmentView apartmentViewIns = null;
      public VillaView villaViewIns = null;
      public TownhouseView townhouseViewIns = null;
      public HospitalView hospitalViewIns = null;
      public SchoolView schoolViewIns = null;
      public UniversityView universityViewIns = null;
      public WarehouseView warehouseViewIns = null;
      public ShopView shopViewIns = null;




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

         homeViewIns = new HomeView();
         apartmentViewIns = new ApartmentView();
         villaViewIns = new VillaView();
         townhouseViewIns = new TownhouseView();
         hospitalViewIns = new HospitalView();
         schoolViewIns = new SchoolView();
         universityViewIns = new UniversityView();
         warehouseViewIns = new WarehouseView();
         shopViewIns = new ShopView();

      }

      void Home_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = homeViewIns;
         var x = (HomeView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void Apartment_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = apartmentViewIns;
         var x = (ApartmentView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void Villa_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = villaViewIns;
         var x = (VillaView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void Townhouse_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = townhouseViewIns;
         var x = (TownhouseView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void Hospital_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = hospitalViewIns;
         var x = (HospitalView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void School_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = schoolViewIns;
         var x = (SchoolView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void University_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = universityViewIns;
         var x = (UniversityView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void Warehouse_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = warehouseViewIns;
         var x = (WarehouseView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      void Shop_Checked(object sender, RoutedEventArgs e){
         contentControl1.Content = shopViewIns;
         var x = (ShopView)contentControl1.Content;
         OneForAll.ViewEntries(x.dataGrid,x);
      }
      
   }
}
