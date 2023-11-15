using System.ComponentModel;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    protected virtual void _OPC_M(object property){
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(property)));
    }
}