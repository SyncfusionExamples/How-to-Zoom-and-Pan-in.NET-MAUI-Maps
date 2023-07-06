using Syncfusion.Maui.Maps;

namespace MAUI_Maps_ZoomingPanning;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		mapTileLayer.Center = new MapLatLng(-27.469771, 153.025124);
    }
}
