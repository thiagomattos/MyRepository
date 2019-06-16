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
    public partial class Pagamento : ContentPage
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        public bool Checked { get; set; }

        private void OnConcluir(object sender, EventArgs e)
        {
            if (cartao.IsChecked==false && dinheiro.IsChecked==false)
            {
                DisplayAlert("Erro", "Selecione um Método de Pagamento", "OK");
                return;
            }          
            else 
            {
                DisplayAlert("Excelente!", "Você concluiu o pedido", "OK");
            }
            
        }
    }
}
