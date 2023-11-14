using Microsoft.Win32;
using Modern_Real_Estate.Model;
using Modern_Real_Estate.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Modern_Real_Estate.Model.EstateTypes;

namespace Modern_Real_Estate.ViewModel
{
    public class ShopViewModel : ViewModelBase
    {
        public ObservableCollection<string> Countries;
        public int TextBoxValueId;
        public string TextBoxValueStreetName;
        public int TextBoxValueZipCode;
        public string TextBoxValueCity;
        public string TextBoxValueCountry;
        public int TextBoxValueArea;
        public string TextBoxValueType;
        public double TextBoxValuePrice;

        public RelayCommand AddCommand => new RelayCommand(execute => AddEstate());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteEstate(), canExecute => SelectedEstate != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => UpdateEstate(), canExecute => CanSave());
        public RelayCommand ImagePickerCommand => new RelayCommand(execute => OpenImagePicker());


        public ShopViewModel()
        {
            Countries = new ObservableCollection<string>();


            SetCountry();
        }

        private string _selectedCountry;
        public string SelectedCountry
        {
            get { return _selectedCountry; }
            set
            {
                _selectedCountry = value;
                OnPropertyChanged();
            }
        }

        public void SetCountry()
        {
            foreach (string countryName in Enum.GetNames(typeof(Countries)))
            {
                Countries.Add(countryName);
            }
        }

        private void UpdateTextBoxValues()
        {
            
        }


        private Estate _selectedEstate;
        public Estate SelectedEstate
        {
            get { return _selectedEstate; }
            set
            {
                if (_selectedEstate != value)
                {
                    _selectedEstate = value;
                    OnPropertyChanged(nameof(SelectedEstate));
                    UpdateTextBoxValues();
                }
            }
        }

        private Estate _selectedTextBoxValue;
        public Estate SelectedTextBoxValue
        {
            get { return _selectedTextBoxValue; }
            set
            {
                if (_selectedTextBoxValue != value)
                {
                    _selectedTextBoxValue = value;
                    OnPropertyChanged(nameof(SelectedTextBoxValue));
                    UpdateTextBoxValues();
                }
            }
        }


        public void AddEstate()
        {


        }

        public void DeleteEstate()
        {
            EstateList.Delete(SelectedEstate);
        }

        public void UpdateEstate()
        {
            if (SelectedEstate != null)
            {
                var isUpdated = EstateList.Update(SelectedEstate, TextBoxValueStreetName, TextBoxValueZipCode, TextBoxValueCity, TextBoxValueCountry, TextBoxValueArea, TextBoxValuePrice);
                if (isUpdated)
                {
                }
            }
        }

        private bool CanSave()
        {
            return true;
        }

        private ImageSource _selectedImage;
        public ImageSource SelectedImage
        {
            get { return _selectedImage; }
            set
            {
                _selectedImage = value;
                OnPropertyChanged(nameof(SelectedImage));
            }
        }

        public byte[]? imageBytes { get; private set; }

        private void OpenImagePicker()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bildfiler (*.jpg; *.png)|*.jpg;*.png|Alla filer (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedImagePath = openFileDialog.FileName;
                SelectedImage = new BitmapImage(new Uri(selectedImagePath));
            }
        }
    }
 }
