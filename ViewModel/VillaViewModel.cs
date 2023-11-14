using Microsoft.Win32;
using Modern_Real_Estate.Model;
using Modern_Real_Estate.Model.EstateTypes;
using Modern_Real_Estate.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Modern_Real_Estate.ViewModel
{
    public class VillaViewModel : ViewModelBase
    {
        public ObservableCollection<string> Countries;
        public int TextBoxValueId;
        public string TextBoxValueStreetName;
        public int TextBoxValueZipCode;
        public string TextBoxValueCity;
        public string TextBoxValueCountry;
        public int TextBoxValueArea;
        public int TextBoxValueRooms;
        public int TextBoxValueSqrM;
        public string TextBoxValueType;
        public double TextBoxValuePrice;


        public RelayCommand AddCommand => new RelayCommand(execute => AddEstate());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteEstate(), canExecute => SelectedEstate != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => UpdateEstate(), canExecute => CanSave());
        public RelayCommand ImagePickerCommand => new RelayCommand(execute => OpenImagePicker());


        public VillaViewModel()
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
                if (SelectedImage != null)
                {
                    // Om en bild har valts, konvertera den till en byte-array för lagring (om det är din avsikt) eller hantera den på annat sätt
                    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create((BitmapSource)SelectedImage));

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        encoder.Save(memoryStream);
                        byte[] imageBytes = memoryStream.ToArray();

                        // Lagra imageBytes på rätt ställe, t.ex., i din Estate-objekt om du vill
                        // SelectedEstate.ImageBytes = imageBytes; // Antag att du har en ImageBytes-egenskap i ditt Estate-objekt
                    }
                }
                var isUpdated = EstateList.Update(SelectedEstate, TextBoxValueStreetName, TextBoxValueZipCode, TextBoxValueCity, TextBoxValueCountry, TextBoxValueArea, imageBytes, TextBoxValueRooms, TextBoxValueSqrM, TextBoxValuePrice);
                if (isUpdated)
                {
                }
            }
        }

        private bool CanSave()
        {
            return true;
        }

        public byte[]? imageBytes { get; private set; }

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
