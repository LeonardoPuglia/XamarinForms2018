using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using App_ConsultarCEP.DTOs;
using Newtonsoft.Json;

namespace App_ConsultarCEP.Services
{
    public class AddressService
    {
        private static string AddressUrl = "https://viacep.com.br/ws/{0}/json/";

        public static AddressDTO SearchForCep(string cep)
        {
            var newAddressUrl = string.Format(AddressUrl, cep);

            var webClient = new WebClient();

            var content = webClient.DownloadString(newAddressUrl);

            var addressConvertToJson = JsonConvert.DeserializeObject<AddressDTO>(content);

            return addressConvertToJson.Cep == null ? null : addressConvertToJson;
        }
    }
}
