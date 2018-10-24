using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent();

            //Button botaoVoltar = new Button()
            //{
            //    Text = "Voltar"
            //};
            //botaoVoltar.Clicked += async (sender, evargs) =>
            //{
            //    await Navigation.PopAsync();
            //};

            //rootLayout.Childrens.Add(botaoVoltar);


        }

        private void OnAlterarIntensidadeSlider(object sender, ValueChangedEventArgs e)
        {
            var vermelho = sliderVermelho.Value;
            var verde = sliderVerde.Value;
            var azul = sliderAzul.Value;

            boxviewCor.Color = Color.FromRgb(vermelho, verde, azul);
        }
    }
}