namespace SuperficieDelTrianguloprac15;

//<Summary>
//<Createddate>15/7/2023</createddate>
//<company>INDEL</company>
//<lastmodificationdate>16/7/2023</lastmodificationdate>
//<lastmodificationdescription>
// Construya un programa en MAUI que dadas la base y la altura de un triangulo, calcule e imprima la superficie 
//</lastmodificationdescription>
//<lastmodifierautor> Maycol Barrera </lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double AlturaTriangulo = Convert.ToDouble(Altura.Text);
        double BaseTriangulo = Convert.ToDouble(basee.Text);


        double superficie = BaseTriangulo * AlturaTriangulo /2;

        SuperficieRespuesta.Text = Convert.ToString(superficie);

    }
}

