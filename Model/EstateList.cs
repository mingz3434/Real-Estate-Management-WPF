using Modern_Real_Estate.Model.EstateTypes;
using Modern_Real_Estate.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Modern_Real_Estate.Model
{
    public class EstateList : ObservableObject
    {

       public ObservableCollection<Estate> Estates => SharedCollection;

        private static ObservableCollection<Estate> _sharedCollection = new ObservableCollection<Estate>();

        public static ObservableCollection<Estate> SharedCollection
        {
            get { return _sharedCollection; }
            set
            {
                _sharedCollection = value;
            }
        }


        public EstateList()
        {
            SharedCollection.CollectionChanged += SharedCollection_Changed;
        }

        public void SharedCollection_Changed(object? sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Estates));
        }


        public static bool Create(Estate estate)
        {
            _sharedCollection.Add(estate);

            return true;
        }


        public static void Delete(Estate estate)
        {
            _sharedCollection.Remove(estate);
        }


        public static bool Update(Estate estate, string? streetName = null, int? zipCode = null, string? city = null, string? country = null, int? area = null, byte[]? selectedImage = null, int? rooms = null, int? sqrM = null, double? price = null)
        {

            return true;

        }
        public static bool Update(Estate estate, string streetName, int zipCode, string city, string country, int? area = null, double? price = null)
        {

            return true;

        }

    }
}
