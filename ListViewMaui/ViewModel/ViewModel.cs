using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ListViewMaui
{
    public class ListViewOrientationViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<PlaceInfo>? places;
        private PlaceInfo selectedItem;

        #endregion

        #region Constructor

        public ListViewOrientationViewModel()
        {
            var placesRepository = new PlaceInfoRepository();
            Places = placesRepository.GeneratePlaces();
            SelectedItem = Places[0];
        }

        #endregion

        #region Properties

        public PlaceInfo SelectedItem
        {
            get
            {
                return selectedItem;
            }

            set
            {
                if(selectedItem != value)
                {
                    if (selectedItem != null)
                        selectedItem.IsSelected = false;

                    selectedItem = value;
                    selectedItem.IsSelected = true;
                }

                OnPropertyChanged("SelectedItem");
            }
        }

        public ObservableCollection<PlaceInfo>? Places
        {
            get { return places; }
            set { this.places = value; OnPropertyChanged("Places"); }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion

    }
}
