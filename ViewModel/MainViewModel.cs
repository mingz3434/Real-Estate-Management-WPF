﻿using Microsoft.VisualBasic.ApplicationServices;
using Modern_Real_Estate.Model;
using Modern_Real_Estate.Model.EstateTypes;
using Modern_Real_Estate.Utilities;
using Modern_Real_Estate.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace Modern_Real_Estate.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        //private string fileName = Environment.CurrentDirectory + "\\estateList.dat";
        //private string filePath = Environment.CurrentDirectory + @"\estateList.xml";
        //public string fileContent { get; set; }
        public ObservableList<Estate> MyList { get; set; }

        //public FileHandler fileHandler { get; set; }

       public EstateManager estateManager { get; set; }


        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ApartmentViewCommand { get; set; }
        public RelayCommand ShopViewCommand { get; set; }
        public RelayCommand HospitalViewCommand { get; set; }
        public RelayCommand SchoolViewCommand { get; set; }
        public RelayCommand TownhouseViewCommand { get; set; }
        public RelayCommand UniversityViewCommand { get; set; }
        public RelayCommand VillaViewCommand { get; set; }
        public RelayCommand WarehouseViewCommand { get; set; }

        public RelayCommand MenuItem_New => new RelayCommand(execute => NewFile());
        public RelayCommand MenuItem_Open => new RelayCommand(execute => OpenFile());
        public RelayCommand MenuItem_Save => new RelayCommand(execute => SaveFile());
        public RelayCommand MenuItem_Exit => new RelayCommand(execute => ExitMenu());

        public RelayCommand AddCommand => new RelayCommand(execute => AddEstate());
        //public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteEstate());
        //public RelayCommand SaveCommand => new RelayCommand(execute => SaveEstate());
        //public RelayCommand ClearCommand => new RelayCommand(execute => ClearEstate());





        public HomeViewModel Home { get; set; }
        public ApartmentViewModel ApartmentView { get; set; }
        public ShopViewModel ShopView { get; set; }
        public HospitalViewModel HospitalView { get; set; }
        public SchoolViewModel SchoolView { get; set; }
        public TownhouseViewModel TownhouseView { get; set; }
        public UniversityViewModel UniversityView { get; set; }
        public VillaViewModel VillaView { get; set; }
        public WarehouseViewModel WarehouseView { get; set; }



        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            //fileHandler = new FileHandler();

            //fileHandler.CreateFile(estateManager);




            // NAVIGATION //
            Home = new HomeViewModel();
            ApartmentView = new ApartmentViewModel();
            ShopView = new ShopViewModel();
            HospitalView = new HospitalViewModel();
            SchoolView = new SchoolViewModel();
            TownhouseView = new TownhouseViewModel();
            UniversityView = new UniversityViewModel();
            VillaView = new VillaViewModel();
            WarehouseView = new WarehouseViewModel();
            CurrentView = Home;


            HomeViewCommand = new RelayCommand(o => { CurrentView = Home; });
            ApartmentViewCommand = new RelayCommand(o => { CurrentView = ApartmentView; });
            ShopViewCommand = new RelayCommand(o => { CurrentView = ShopView; });
            HospitalViewCommand = new RelayCommand(o => { CurrentView = HospitalView; });
            SchoolViewCommand = new RelayCommand(o => { CurrentView = SchoolView; });
            TownhouseViewCommand = new RelayCommand(o => { CurrentView = TownhouseView; });
            UniversityViewCommand = new RelayCommand(o => { CurrentView = UniversityView; });
            VillaViewCommand = new RelayCommand(o => { CurrentView = VillaView; });
            WarehouseViewCommand = new RelayCommand(o => { CurrentView = WarehouseView; });
            // NAVIGATION //
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
                }
            }
        }

        private string _fileContent;

        public string FileContent
        {
            get { return _fileContent; }
            set
            {
                _fileContent = value;
                OnPropertyChanged(nameof(FileContent));
            }
        }

        //public void NewFile()
        //{
        //    fileHandler = new FileHandler();

        //    fileHandler.CreateFile(estateManager);

        //}

        public void NewFile(){
        
        }
        public void OpenFile()
        {
            //FileHandler fileHandler = new FileHandler();
            //fileHandler.OpenFile(filePath);

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c://";
            openFileDialog.Filter = "Alla filer (*.json)|*.json";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if ( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                string readFilePath = openFileDialog.FileName;
                estateManager.DeSerialize(readFilePath);
            }
        }

        public void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Alla filer (*.json)|*.json";
            saveFileDialog.FilterIndex= 1;
            saveFileDialog.Title = "Spara en fil";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                //estateManager.XMLSerialize(fileName);
                estateManager.Serialize(fileName);
                //using (FileStream fs = new FileStream(fileName, FileMode.Create))
                //{
                //    BinaryFormatter binaryFormatter = new BinaryFormatter();
                //    binaryFormatter.Serialize(fs, fileContent);
                //}
            }
        }

        public void ExitMenu()
        {

        }


        public void AddEstate()
        {

            Estate apartment = new Apartment("hej", 2222, "stad", "land", 3, 73, 5000);


            estateManager.Add(apartment);

            //estateManager.ToStringList();
        }

        //public void DeleteEstate()
        //{
        //    EstateManager.GetAt(SelectedEstate.Id);
        //}

        //public void SaveEstate()
        //{
        //    EstateManager.ChangeAt(SelectedEstate, 0);

        //}


        //public void ClearEstate()
        //{
        //    EstateManager.DeleteAll();
        //}
    }
}
