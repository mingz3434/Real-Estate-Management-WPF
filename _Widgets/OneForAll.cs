using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Modern_Real_Estate.View;
using Modern_Real_Estate.Model;
namespace Modern_Real_Estate.Widgets{
   //Home,Apartment,Hospital,School,Shop,Townhouse,University,Villa,Warehouose
   public static class OneForAll{

      public static void ViewEntries(DataGrid dataGrid, UserControl userControl){
         if(userControl is Home){ dataGrid.ItemsSource = SM.HomeList; }
         if(userControl is ApartmentView){ dataGrid.ItemsSource = SM.ApartmentList; }
         if(userControl is HospitalView){ dataGrid.ItemsSource = SM.HospitalList; }
         if(userControl is SchoolView){ dataGrid.ItemsSource = SM.SchoolList; }
         if(userControl is ShopView){ dataGrid.ItemsSource = SM.ShopList; }
         if(userControl is TownhouseView){ dataGrid.ItemsSource = SM.TownhouseList; }
         if(userControl is UniversityView){ dataGrid.ItemsSource = SM.UniversityList; }
         if(userControl is VillaView){ dataGrid.ItemsSource = SM.VillaList; }
         if(userControl is WarehouseView){ dataGrid.ItemsSource = SM.WarehouseList; }
      }


      public static void AddEntry(DataGrid dataGrid, UserControl userControl, Estate estate){
         if(userControl is Home){
            SM.HomeList.Add(estate);
            dataGrid.ItemsSource = SM.HomeList;
         }
         if (userControl is ApartmentView){
            SM.ApartmentList.Add(estate);
            dataGrid.ItemsSource = SM.ApartmentList;
         }
         if (userControl is HospitalView){
            SM.HospitalList.Add(estate);
            dataGrid.ItemsSource= SM.HospitalList;
         }
         if (userControl is SchoolView){
            SM.SchoolList.Add(estate);
            dataGrid.ItemsSource = SM.SchoolList;
         }
         if (userControl is ShopView){
            SM.ShopList.Add(estate);
            dataGrid.ItemsSource = SM.ShopList;
         }
         if (userControl is TownhouseView){
            SM.TownhouseList.Add(estate);
            dataGrid.ItemsSource = SM.TownhouseList;
         }
         if (userControl is UniversityView){
            SM.UniversityList.Add(estate);
            dataGrid.ItemsSource = SM.UniversityList;
         }
         if (userControl is VillaView){
            SM.VillaList.Add(estate);
            dataGrid.ItemsSource = SM.VillaList;
         }
         if (userControl is WarehouseView){
            SM.WarehouseList.Add(estate);
            dataGrid.ItemsSource = SM.WarehouseList;
         }


      }

      public static void EditEntry(DataGrid dataGrid, UserControl userControl, Estate entry){
         if(userControl is Home){
            Estate matchResult = SM.HomeList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.HomeList;
         }

         if (userControl is ApartmentView){
            Estate matchResult = SM.ApartmentList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.ApartmentList;
         
         }
         if (userControl is HospitalView){
            Estate matchResult = SM.HospitalList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.HospitalList;
         
         }
         if (userControl is SchoolView){
            Estate matchResult = SM.SchoolList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.SchoolList;
         
         
         }
         if (userControl is ShopView){
            Estate matchResult = SM.ShopList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.ShopList;
         
         }
         if (userControl is TownhouseView){
            Estate matchResult = SM.TownhouseList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.TownhouseList;
         
         }
         if (userControl is UniversityView){
            Estate matchResult = SM.UniversityList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.UniversityList;
         
         }
         if (userControl is VillaView){
            Estate matchResult = SM.VillaList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.VillaList;
         
         }
         if (userControl is WarehouseView){
            Estate matchResult = SM.WarehouseList.First(_=>_.Id==entry.Id);
            matchResult.Id = entry.Id;
            matchResult.StreetName = entry.StreetName;
            matchResult.ZipCode = entry.ZipCode;
            matchResult.City = entry.City;
            matchResult.Country = entry.Country;
            matchResult.Area = entry.Area;
            matchResult.Price = entry.Price;
            matchResult.ImagePath = entry.ImagePath;

            dataGrid.ItemsSource = SM.WarehouseList;
         
         }
      }

      public static void DeleteEntry(DataGrid dataGrid, UserControl userControl, Estate estate){
         if(userControl is Home){
            Estate matchResult = SM.HomeList.First(_=>_.Id==estate.Id);
            SM.HomeList.Remove(matchResult);

            dataGrid.ItemsSource = SM.HomeList;
         }
         if (userControl is ApartmentView){
            Estate matchResult = SM.ApartmentList.First(_=>_.Id==estate.Id);
            SM.ApartmentList.Remove(matchResult);

            dataGrid.ItemsSource = SM.ApartmentList;
         }
         if (userControl is HospitalView){
            Estate matchResult = SM.HospitalList.First(_=>_.Id==estate.Id);
            SM.HospitalList.Remove(matchResult);

            dataGrid.ItemsSource = SM.HospitalList;
         }
         if (userControl is SchoolView){
            Estate matchResult = SM.SchoolList.First(_=>_.Id==estate.Id);
            SM.SchoolList.Remove(matchResult);

            dataGrid.ItemsSource = SM.SchoolList;
         }
         if (userControl is ShopView){
            Estate matchResult = SM.ShopList.First(_=>_.Id==estate.Id);
            SM.ShopList.Remove(matchResult);

            dataGrid.ItemsSource = SM.ShopList;
         }
         if (userControl is TownhouseView){
            Estate matchResult = SM.TownhouseList.First(_=>_.Id==estate.Id);
            SM.TownhouseList.Remove(matchResult);

            dataGrid.ItemsSource = SM.TownhouseList;
         }
         if (userControl is UniversityView){
            Estate matchResult = SM.UniversityList.First(_=>_.Id==estate.Id);
            SM.UniversityList.Remove(matchResult);

            dataGrid.ItemsSource = SM.UniversityList;
         }
         if (userControl is VillaView){
            Estate matchResult = SM.VillaList.First(_=>_.Id==estate.Id);
            SM.VillaList.Remove(matchResult);

            dataGrid.ItemsSource = SM.VillaList;
         }
         if (userControl is WarehouseView){
            Estate matchResult = SM.WarehouseList.First(_=>_.Id==estate.Id);
            SM.WarehouseList.Remove(matchResult);

            dataGrid.ItemsSource = SM.WarehouseList;
         }
      }
   }
}
