using System.Collections.ObjectModel;

namespace Bug_GridCollectionView;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Somethinguseless { get; set; }
    public MainPage()
	{
        // place this line before InitializeComponent() will fail, move it after InitializeComponent(); will NOT;
        // use a Viewmodel from constructor by Dependce-Injection in mauiprogram.cs will fail also; In this sample, I removed Viewmodels to reduce codes.
        Somethinguseless = new ObservableCollection<string> { "", "" };
        InitializeComponent();
	}

}

