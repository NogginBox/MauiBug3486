using System.Collections.ObjectModel;

namespace Bug3486Example.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<SummaryLineViewModel> Items { get; init; } = new() { 
        new SummaryLineViewModel("Name 1", "Address 1"),
        new SummaryLineViewModel("Name 2", "Address 2"),
        new SummaryLineViewModel("Name 3", "Address 3"),
        new SummaryLineViewModel("Name 4", "Address 4"),
        new SummaryLineViewModel("Name 5", "Address 5"),
        new SummaryLineViewModel("Name 6", "Address 6"),
        new SummaryLineViewModel("Name 7", "Address 7"),
        new SummaryLineViewModel("Name 8", "Address 8"),
        new SummaryLineViewModel("Name 9", "Address 9"),
        new SummaryLineViewModel("Name 10", "Address 10"),
        new SummaryLineViewModel("Name 11", "Address 11"),
        new SummaryLineViewModel("Name 12", "Address 12"),
        new SummaryLineViewModel("Name 13", "Address 13"),
        new SummaryLineViewModel("Name 14", "Address 14"),
    };
}
