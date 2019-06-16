using CarWash3.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarWash3.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private CarWash carWash;
        public MainPage(CarWash carWash)
        {
            InitializeComponent();

            if (carWash != null)
            {
                this.carWash = carWash;
                nomeEntry.Text = carWash.Nome;
                senhaEntry.Text = carWash.Senha;
            }
        }
        private void OnLogar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logIn.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um login", "OK");
                return;
            }
            if (string.IsNullOrEmpty(senhaEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar uma senha", "OK");
                return;
            }


            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Usuario.db3");
            var db = new SQLiteConnection(dbPath);
            var dados = db.Table<CarWash>(); //Chama tabela
            var login = dados.Where(x => x.Nome == nomeEntry.Text && x.Senha == senhaEntry.Text).FirstOrDefault();
            if (login != null)
            {

                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Erro", "É necessário efetuar um cadastro", "OK");
                return;

            }

        }


        private void OnRegistrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage(false, null));
        }
    }
}
