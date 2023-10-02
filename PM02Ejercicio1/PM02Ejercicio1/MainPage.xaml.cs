namespace PM02Ejercicio1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    private void Suma_Clicked(object sender, EventArgs e)
    {
        // Limpiar el contenido del Label
        resultadoLabel.Text = string.Empty;

        if (double.TryParse(numero1Entry.Text, out double numero1) && double.TryParse(numero2Entry.Text, out double numero2))
        {
            double resultado = numero1 + numero2;
            resultadoLabel.Text = $"Resultado: {resultado}";
        }
        else
        {
            MostrarError("Error", "Por favor, ingrese números válidos en ambos campos.");
        }
    }

    private void Resta_Clicked(object sender, EventArgs e)
    {
        // Limpiar el contenido del Label
        resultadoLabel.Text = string.Empty;

        if (double.TryParse(numero1Entry.Text, out double numero1) && double.TryParse(numero2Entry.Text, out double numero2))
        {
            double resultado = numero1 - numero2;
            resultadoLabel.Text = $"Resultado: {resultado}";
        }
        else
        {
            MostrarError("Error", "Por favor, ingrese números válidos en ambos campos.");
        }
    }

    private void Multiplicacion_Clicked(object sender, EventArgs e)
    {
        // Limpiar el contenido del Label
        resultadoLabel.Text = string.Empty;

        if (double.TryParse(numero1Entry.Text, out double numero1) && double.TryParse(numero2Entry.Text, out double numero2))
        {
            double resultado = numero1 * numero2;
            resultadoLabel.Text = $"Resultado: {resultado}";
        }
        else
        {
            MostrarError("Error", "Por favor, ingrese números válidos en ambos campos.");
        }
    }

    private void Division_Clicked(object sender, EventArgs e)
    {
        // Limpiar el contenido del Label
        resultadoLabel.Text = string.Empty;

        if (double.TryParse(numero1Entry.Text, out double numero1) && double.TryParse(numero2Entry.Text, out double numero2))
        {
            if (numero2 != 0)
            {
                double resultado = numero1 / numero2;
                resultadoLabel.Text = $"Resultado: {resultado}";
            }
            else
            {
                MostrarError("Error", "La división por cero no está permitida.");
            }
        }
        else
        {
            MostrarError("Error", "Por favor, ingrese números válidos en ambos campos.");
        }
    }

    private void MostrarError(string titulo, string mensaje)
    {
        DisplayAlert(titulo, mensaje, "Aceptar");
    }


    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

