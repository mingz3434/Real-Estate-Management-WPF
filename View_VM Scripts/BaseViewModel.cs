using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Modern_Real_Estate.Model;

public class BaseViewModel : INotifyPropertyChanged
{
   public BaseViewModel(){
      DummyEntries = new ObservableCollection<Estate>();

      DCS_AddBtnClick = new RelayCommand(DCS_AddBtnClick_Do);
      DCS_EditBtnClick = new RelayCommand(DCS_EditBtnClick_Do);

   }
   #region Part A : Props ( UI Texts & Radio Bools )
   public string DummyId { get; set; } public string DummyStreetName { get; set; }
   public string DummyZipCode { get; set; } public string DummyCity { get; set; } public string DummyCountry { get; set; }
   public string DummyArea { get; set; } public string DummyPrice { get; set; }
   public string DummyRate { get; set; } public string DummyTaxedPrice { get; set; } public string DummyPricePerSqm { get; set; }
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

   #endregion


   public event PropertyChangedEventHandler PropertyChanged;

   protected virtual void OnPropertyChanged(string propertyName){ PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
   protected virtual void _OPC_M(object property){ PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(property))); }

   #region Part C : Our Beloved Daily Methods
   public virtual void DCS_AddBtnClick_Do(object parameter){ /*...*/  }
   public virtual void DCS_EditBtnClick_Do(object parameter){
      DummyId = SelectedDummyEstate.Id.ToString();
      DummyStreetName = SelectedDummyEstate.StreetName;
      DummyZipCode = SelectedDummyEstate.ZipCode.ToString();
      DummyCity = SelectedDummyEstate.City;
      DummyCountry = SelectedDummyEstate.Country;
      DummyArea = SelectedDummyEstate.Area.ToString();
      DummyPrice = SelectedDummyEstate.Price.ToString();
      DummyRate = SelectedDummyEstate.Rate.ToString();
      DummyImagePath = SelectedDummyEstate.ImagePath;
      /*...*/
   }
   public virtual void DCS_DeleteBtnClick_Do(object parameter){ DummyEntries.Remove(SelectedDummyEstate); }
   public virtual void DCS_SaveBtnClick_Do(object parameter){ /*Do some save*/ }
   public virtual void DCS_ClearBtnClick_Do(object parameter){ DummyEntries.Clear(); }
   #endregion
}