using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EntryCompletedBug;

[ObservableObject]
public sealed partial class MainViewModel
{
    [ObservableProperty]
    private string _testText;

    [ICommand]
    private void EntryReturnPressed()
    {
        this.TestText = "This will not appear!";
    }
}
