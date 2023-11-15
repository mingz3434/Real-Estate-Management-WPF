using System.Diagnostics;
using System.Windows.Input;

namespace Modern_Real_Estate.View{
   public class ApartmentViewModel : BaseViewModel{
      //P: TO-DO LIST
      //P: 1. Interfacessss : 1.1 RelayCommand
      //P: 2. Properties
      //P: 3. Copy Old Codesss....

      //P: Model Data Structure to Dummy
      // public int Id { get; set; } public string StreetName { get; set; } public int ZipCode { get; set; }
      // public string City { get; set; } public string Country { get; set; }
      // public double Area_InSqm { get; set; } public double Price { get; set; } 
      // public double Rate { get; set; } public double TaxedPrice { get; set; } public int PricePerSqm { get; set; }
      // public string ImagePath { get; set; }
      // public string Category { get; set; } public string Type { get; set; }

      #region Part A : Props ( UI Texts & Radio Bools )
      public string DummyId { get; set; } public string DummyAddress { get; set; }
      public string DummyZipCode { get; set; } public string DummyCity { get; set; } public string DummyCountry { get; set; }
      public string DummyArea_InSqm { get; set; } public string DummyPrice { get; set; }
      public double DummyRate { get; set; } public double DummyTaxedPrice { get; set; } public int DummyPricePerSqm { get; set; }
      public string DummyImagePath { get; set; }
      public string DummyCategory { get; set; } = string.Empty; public string DummyType { get; set; }
      #endregion

      #region Part B : Commands
      //! DCS for DummyCommandSequence
      public ICommand DCS_AddBtnClick { get;set; } //P: Declare
      public ApartmentViewModel(){
         //P: Point to method.
         DCS_AddBtnClick = new RelayCommand(DCS_AddBtnClick_Do);
      }
      #endregion

      #region Part C : Our Beloved Daily Methods
      public void DCS_AddBtnClick_Do(object parameter){ Debug.WriteLine(DummyId);}
      #endregion


   }

}

