using App_ConsultarCEP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{        

		public MainPage()
		{
			InitializeComponent();

            BuscarCep.Clicked += SearchCep;
		}

        private void SearchCep(object sender , EventArgs args)
        {
            
            //TODO - Lógica do problema.

            //TODO - Validações.

            //TODO - Usar AddressService.
            var cep = Cep.Text;
            if (IsValidCep(cep))
            {
                try
                {
                    var address = AddressService.SearchForCep(cep);

                    if (address == null)
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado.", "OK");
                    else
                        RetornoAPI.Text = $"Endereço: {address.Logradouro} , {address.Bairro}  {address.Localidade} , {address.UF}";

                }catch(Exception ex)
                {
                    DisplayAlert("ERRO CRÍTICO", ex.Message, "OK");
                }
                
            }            
        }

        private bool IsValidCep(string cep)
        {            
            if (string.IsNullOrWhiteSpace(cep) )
            {
                DisplayAlert("Error", "CEP não informado ! Favor inserir um CEP.", "OK");
                return false;
            }
            cep.Trim();
            if( cep.Any(c => !Char.IsNumber(c)) ) {
                DisplayAlert("Error", "CEP Inválido ! O CEP deve conter apenas valores numéricos.", "OK");
                return false;
            }
            
            if(cep.Length != 8 )
            {
                DisplayAlert("Error", "CEP Inválido ! O CEP deve conter 8 digitos numéricos.", "OK");
                return false;
            }


            return true;
                
        }
	}
}
