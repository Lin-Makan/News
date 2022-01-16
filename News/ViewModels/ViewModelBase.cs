using System.ComponentModel;

namespace News.ViewModels
{
    public abstract class ViewModelBase
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}