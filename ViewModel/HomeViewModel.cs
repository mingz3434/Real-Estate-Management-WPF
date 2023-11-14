using Modern_Real_Estate.Model;
using Modern_Real_Estate.Model.EstateTypes;
using Modern_Real_Estate.Utilities;
using Modern_Real_Estate.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Modern_Real_Estate.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private string fileName = Environment.CurrentDirectory + "\\estateList.dat";  //file at Application directory
        private string xmlFileName = Environment.CurrentDirectory + "\\estateList.xml";  //(file for testi


        public RelayCommand AddCommand => new RelayCommand(execute => AddEstate());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteEstate());
        public RelayCommand SaveCommand => new RelayCommand(execute => SaveEstate());
        public RelayCommand ClearCommand => new RelayCommand(execute => ClearEstate());

      


        public HomeViewModel()
        {
            //Estate apartment = new Apartment("hej", 2222, "stad", "land", 3, 73, 5000);

            //estateManager.Add(apartment);
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

        public void AddEstate()
        {

            //Estate apartment = new Apartment("hej", 2222, "stad", "land", 3, 73, 5000);



        }

        public void DeleteEstate()
        {
            if (SelectedEstate != null)
            {
            }
        }

        public void SaveEstate()
        {
        }


        public void ClearEstate()
        {
        }

        // switch case apartment...... or residential

        // switch the usercontrol

    }
}
