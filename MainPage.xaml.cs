using CalculadoraCombustivel.Model;
using CalculadoraCombustivel.View;
using System;
using Xamarin.Forms;

namespace CalculadoraCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcular(object sender, EventArgs e)
        {
            if (precoEtanolEntry.Text == null || precoGasolinaEntry.Text == null || consumoMedioEtanolEntry.Text == null || consumoMedioGasolinaEntry.Text == null)
                {
                    DisplayAlert("Atenção!", "Preencha todos os campos antes de continuar", "Ok");
                    return;
                }

                Combustivel etanol = new Combustivel();
            etanol.Preco = Convert.ToDouble(precoEtanolEntry.Text);
            etanol.Consumo = Convert.ToDouble(consumoMedioEtanolEntry.Text);

            Combustivel gasolina = new Combustivel();
            gasolina.Preco = Convert.ToDouble(precoGasolinaEntry.Text);
            gasolina.Consumo = Convert.ToDouble(consumoMedioGasolinaEntry.Text);

            Navigation.PushAsync(new ResultadoPage(etanol, gasolina));
        }
    }
}