using System.Diagnostics;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Modern_Real_Estate.Model;
using Modern_Real_Estate.Model.EstateTypes;
using System;

namespace Modern_Real_Estate.View{
   public class ApartmentViewModel : BaseViewModel{
      //P: TO-DO LIST
      //P: 1. Interfacessss : 1.1 RelayCommand
      //P: 2. Properties
      //P: 3. Copy Old Codesss....

      //P: Model Data Structure to Dummy
      #region Part A : Props ( UI Texts & Radio Bools )
      public string DummyId { get; set; } public string DummyAddress { get; set; }
      public string DummyZipCode { get; set; } public string DummyCity { get; set; } public string DummyCountry { get; set; }
      public string DummyArea_InSqm { get; set; } public string DummyPrice { get; set; }
      public string DummyRate { get; set; } public string DummyTaxedPrice { get; set; } public int DummyPricePerSqm { get; set; }
      public string DummyRooms { get; set; }
      public string DummyImagePath { get; set; }
      public string DummyCategory { get; set; } = string.Empty; public string DummyType { get; set; }
      #endregion

      #region Part A2 : Fuck
      public ObservableCollection<Estate> _dummyEntries; public ObservableCollection<Estate> DummyEntries { get{ return _dummyEntries; } set{ _dummyEntries = value; _OPC_M(DummyEntries);} }
      public Estate _selectedDummyEstate; public Estate SelectedDummyEstate { get{ return _selectedDummyEstate; } set{ _selectedDummyEstate = value; _OPC_M(SelectedDummyEstate);} }

      #endregion

      #region Part B : Commands
      //! DCS for DummyCommandSequence
      public ICommand DCS_AddBtnClick { get;set; } //P: Declare
      public ICommand DCS_EditBtnClick { get;set; }
      public ICommand DCS_DeleteBtnClick { get;set; }
      public ICommand DCS_SaveBtnClick { get;set; }
      public ICommand DCS_ClearBtnClick { get;set; }
      public ApartmentViewModel(){
         DummyEntries = new ObservableCollection<Estate>();
         DummyEntries.Add(new Apartment(0,"STREEEEEEEEET",0,"","",1,2.5,12.0,"Hi",9));


         //P: Point to method.
         DCS_AddBtnClick = new RelayCommand(DCS_AddBtnClick_Do);
         DCS_EditBtnClick = new RelayCommand(DCS_EditBtnClick_Do);

      }
      #endregion

      #region Part C : Our Beloved Daily Methods
      public void DCS_AddBtnClick_Do(object parameter){
         DummyEntries.Add(new Apartment(
            id: DummyEntries.Count,
            streetName: DummyAddress,
            zipCode: DummyZipCode.ToInt(),
            city: DummyCity,
            country: DummyCountry,
            area: DummyArea_InSqm.ToDouble(),
            price: DummyPrice.ToInt(),
            rate: DummyRate.ToDouble(),
            imagePath: DummyImagePath,
            rooms: DummyRooms.ToInt()
         ));
         Debug.WriteLine(DummyEntries[1]);
      }
      public void DCS_EditBtnClick_Do(object parameter){
      }
      public void DCS_DeleteBtnClick_Do(object parameter){
      }
      public void DCS_SaveBtnClick_Do(object parameter){
      }
      public void DCS_ClearBtnClick_Do(object parameter){
      }
      #endregion


   }

}

public static class StringEx{
   public static int ToInt(this string str){return Convert.ToInt16(str);}
   public static double ToDouble(this string str){return Convert.ToDouble(str);}
}