using System.Diagnostics;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Modern_Real_Estate.Model;
using Modern_Real_Estate.Model.EstateTypes;
using System;
using System.Linq;

namespace Modern_Real_Estate.View{
   public class ApartmentViewModel : BaseViewModel{
      public ApartmentViewModel() : base(){  }

      public override void DCS_AddBtnClick_Do(object parameter){
         int maxId = DummyEntries.Count == 0 ? -1 : DummyEntries.Max(_ => _.Id);

         DummyEntries.Add(new Apartment(
            id: maxId + 1,
            streetName: DummyStreetName,
            zipCode: DummyZipCode.ToInt(),
            city: DummyCity,
            country: DummyCountry,
            area: DummyArea.ToDouble(),
            price: DummyPrice.ToInt(),
            rate: DummyRate.ToDouble(),
            imagePath: DummyImagePath,
            rooms: DummyRooms.ToInt()
         ));
      }

      public override void DCS_EditBtnClick_Do(object parameter){
         base.DCS_EditBtnClick_Do(parameter);
         DummyRooms = ((Apartment)SelectedDummyEstate).Rooms.ToString();
      }

 

   }

   public class HomeViewModel : BaseViewModel{
      public HomeViewModel() : base(){  }
   }

   public class HospitalViewModel : BaseViewModel{
      public HospitalViewModel() : base(){  }
   }

   public class SchoolViewModel : BaseViewModel{
      public SchoolViewModel() : base(){  }
   }

   public class ShopViewModel : BaseViewModel{
      public ShopViewModel() : base(){  }
   }

   public class WarehouseViewModel : BaseViewModel{
      public WarehouseViewModel() : base(){  }
   }
   
   public class TownhouseViewModel : BaseViewModel{
      public TownhouseViewModel() : base(){  }
   }

   public class VillaViewModel : BaseViewModel{
      public VillaViewModel() : base(){  }
   }
   
   public class UniversityViewModel : BaseViewModel{
      public UniversityViewModel() : base(){  }
   }

}

public static class StringEx{
   public static int ToInt(this string str){return Convert.ToInt32(str);}
   public static double ToDouble(this string str){return Convert.ToDouble(str);}
}