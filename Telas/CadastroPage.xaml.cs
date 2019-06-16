using CarWash3.Modelos;
using CarWash3.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarWash3.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPage : ContentPage
    {
        private CarWash carWash;
        public CadastroPage(bool isEdit, CarWash carWash)
        {
            InitializeComponent();

            CadastrarButton.IsVisible = !isEdit;
            if (carWash != null)
            {
                this.carWash = carWash;
                nomeEntry.Text = carWash.Nome;
                cpfEntry.Text = carWash.CPF;
                endereçoEntry.Text = carWash.Endereço;
                emailEntry.Text = carWash.Email;
                senhaEntry.Text = carWash.Senha;



            }

        }

        private void OnCadastrarNew(object sender, EventArgs e)
        {

            var carWash = new CarWash();
            carWash.Nome = nomeEntry.Text;
            carWash.CPF = cpfEntry.Text;
            carWash.Endereço = endereçoEntry.Text;
            carWash.Email = emailEntry.Text;
            carWash.Senha = senhaEntry.Text;

            CarWashDAO dao = new CarWashDAO();
            dao.Adicionar(carWash);


            Navigation.PushAsync(new MainPage(null));

            if (string.IsNullOrEmpty(nomeEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar um nome", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;
            }

            if (string.IsNullOrEmpty(cpfEntry.Text))
            {
                DisplayAlert("Erro", "Digite seu CPF", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;
            }

            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar um endereço", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;


            }
            if (string.IsNullOrEmpty(senhaEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar um endereço", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;


            }
            if (string.IsNullOrEmpty(endereçoEntry.Text))
            {
                DisplayAlert("Erro", "É necessário digitar um endereço", "OK");

                Navigation.PushAsync(new CadastroPage(false, null));

                return;


            }



        }


    }
}