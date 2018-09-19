using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExemploStateButton
{
    public partial class MainPage : ContentPage
    {
        private ICommand _selectedCommand;

        public ICommand SelectCommand => _selectedCommand ?? (_selectedCommand = new Command((selectedItem) => lblbotao.Text = $"O botão {selectedItem.ToString()} foi apertado"));


        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            btnImagemAtiva.InnerPadding = new Thickness(10, 0);

        }
    }
}
