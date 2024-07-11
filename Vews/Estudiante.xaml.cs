using System.Collections.ObjectModel;

namespace sSandovalS6.Vews;

public partial class Estudiante : ContentPage
{
	private const string Url =""
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Modelos.Estudiante> est;
	public Estudiante()
	{
		InitializeComponent();
	}
	public 
}