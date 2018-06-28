using System;
using System.Collections.Generic;
using System.Text;
using System.Net; //WebClient - Para buscar o endereço na web pelo CEP
using CEP.Servico.Modelo;
using Newtonsoft.Json;

namespace CEP.Servico
{

    /*
     * Esta classe tem o propósito de fazer o download da 
     * informação e converter para o formato útil ao projeto
     */
    public class ViaCepServico
    {

        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep) 
        {
            string EnderecoURLComCep = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient(); //using System.Net;

            //JSON retornado pelo WebClient é convertido para string
            string Conteudo = wc.DownloadString(EnderecoURLComCep);

            //Converter string em objeto do tipo Endereco 
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            //Tratamento de errro
            if (end.cep == null) return null;

            return end;
        }

    }
}
