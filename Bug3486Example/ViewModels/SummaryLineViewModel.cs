using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bug3486Example.ViewModels;

public class SummaryLineViewModel : ObservableViewModelBase
{
    public SummaryLineViewModel(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public ICommand OnCopyAddress => new Command(async () => await CopyToClipboard(Address));

    private static Task CopyToClipboard(string text)
    {
        return Clipboard.SetTextAsync(text);
    }

    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
            RaisePropertyChanged(nameof(Address));
        }
    }
    private string _address;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
            RaisePropertyChanged(nameof(Name));
        }
    }
    private string _name;
}
