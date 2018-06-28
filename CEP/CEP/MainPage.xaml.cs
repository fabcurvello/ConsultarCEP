using CEP.Servico;
using CEP.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //BOTAO.Clicked += BuscarCEP;
		}

        private void BuscarCEP(object sender, EventArgs args) 
        {
            string cep = "";
            
            //cep recebe o texto da caixa de texto (Entry), retirando espaços iniciais e finais (trim)
            if (CEP.Text != null) {
                cep = CEP.Text.Trim();
            }

            //Validações
            if (isValidCEP(cep)) {
                try {

                    //Passado o cep para o serviço ViaCEP, será retornado o obj Endereço.
                    Endereco end = ViaCepServico.BuscarEnderecoViaCep(cep);

                    if (end != null) {

                        //Inserindo texto na label
                        RESULTADO.Text = string.Format("Endereço: {0}, {1} - {2}, {3}",
                            end.logradouro, end.bairro, end.localidade, end.uf);
                    } else {
                        DisplayAlert("CEP inexistente", "Não foi econtrado endereço correspondente ao CEP informado: " + cep, "OK");
                        RESULTADO.Text = "CEP " + cep + " não localizado.";
                    }

                } catch (Exception e) {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
            
        }//fim BuscarCEP()

        //Validações
        private bool isValidCEP(string cep) 
        {
            bool valido = true;

            //CEP tem que ter algo digitado pelo usuário
            if (cep.Equals("")) {
                //ERRO
                valido = false;
                DisplayAlert("ERRO", "Por favor digite o CEP.", "OK");
                RESULTADO.Text = "";
                return valido;
            }

            //CEP tem que ter 8 dígitos
            if (cep.Length != 8) {
                //ERRO
                valido = false;
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres.", "OK");
                RESULTADO.Text = "CEP " + cep + " inválido.";
                return valido;
            }

            //CEP tem que ser somente números
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP)) {
                //ERRO
                valido = false;
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas por números.", "OK");
                RESULTADO.Text = "CEP " + cep + " inválido.";
                return valido;
            }

            return valido;
        } //fim isValidCEP()

	}
}
