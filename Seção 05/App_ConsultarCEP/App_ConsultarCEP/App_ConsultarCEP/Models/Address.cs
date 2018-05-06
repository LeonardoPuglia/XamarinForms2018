using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App_ConsultarCEP.Services.Models
{
    public struct Address
    {

        public string CEP { get; set; }

        public string StreetName { get; set; }

        public int Number { get; set; }

        public string Complement { get; set; }

        public string Neighborhood { get; set; }

        public string Locality { get; set; }

        public UF UF { get; set; }

        public Region Region { get; set; }


    }

    public enum UF
    {
        //Norte
        [Description("Acre")]
        AC = 1,
        [Description("Amapá")]
        AP = 2,
        [Description("Amazonas")]
        AM = 3,
        [Description("Rondônia")]
        RO = 4,
        [Description("Roraima")]
        RR = 5,
        [Description("Tocantins")]
        TO = 6,

        //Nordeste
        [Description("Alagoas")]
        AL = 7,        
        [Description("Bahia")]
        BA = 8,
        [Description("Ceará")]
        CE = 9,
        [Description("Maranhão")]
        MA = 10,
        [Description("Pará")]
        PA = 11,
        [Description("Paraíba")]
        PB = 12,
        [Description("Pernambuco")]
        PE = 13,
        [Description("Piauí")]
        PI = 14,
        [Description("Rio Grande do Norte")]
        RN = 15,
        [Description("Sergipe")]
        SE = 16,

        //Centro-Oeste
        [Description("Distrito Federal")]
        DF = 17,
        [Description("Goiás")]
        GO = 18,
        [Description("Mato Grosso")]
        MT = 19,
        [Description("Mato Grosso do Sul")]
        MS = 20,

        //Sudeste
        [Description("Espírito Santo")]
        ES = 21,
        [Description("Minas Gerais")]
        MG = 22,                       
        [Description("Rio de Janeiro")]
        RJ = 23,
        [Description("São Paulo")]
        SP = 24,

        //Sul
        [Description("Rio Grande do Sul")]
        RS = 25,
        [Description("Paraná")]
        PR = 26,
        [Description("Santa Catarina")]
        SC = 27,
        
        
        
    }

    public enum Region
    {
        [Description("Norte")]
        Norte = 1,
        [Description("Nodeste")]
        Nordeste = 2,
        [Description("Centro-Oeste")]
        Centro = 3,               
        [Description("Sudeste")]
        Sudeste = 4,
        [Description("Sul")]
        Sul = 5
    }
}
