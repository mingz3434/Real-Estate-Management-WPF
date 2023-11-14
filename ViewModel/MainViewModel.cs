using Microsoft.VisualBasic.ApplicationServices;
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
        //public string fileContent;
        public ObservableList<Estate> MyList;

        //public FileHandler fileHandler;







        public HomeViewModel Home;
        public ApartmentViewModel ApartmentView;
        public ShopViewModel ShopView;
        public HospitalViewModel HospitalView;
        public SchoolViewModel SchoolView;
        public TownhouseViewModel TownhouseView;
        public UniversityViewModel UniversityView;
        public VillaViewModel VillaView;
        public WarehouseViewModel WarehouseView;



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

      public void SetView(object view)
      {
         CurrentView = view;
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

           // Estate apartment = new Apartment("hej", 2222, "stad", "land", 3, 73, 5000);



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
