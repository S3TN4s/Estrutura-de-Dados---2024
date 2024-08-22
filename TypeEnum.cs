using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    public class TipoEnumerador
    {
        public enum Language
        {
            PTBR, EN, RU
        }

        public Language _language = Language.PTBR;

        public TipoEnumerador ()
        {

        }


        /*
        public TypeUnum(TipoEnumerador enum)
        {
            _language = enum;

        }
   
        */
        public Language GetLanguageEnum(string lang)
        {
            switch(lang.ToLower())

            {
            case "Portugues" : 
                return Language.PTBR;
            case "Ingles" :
                return Language.EN;
            case "Russo" :
                return Language.RU;
            default :
                return Language.PTBR;        
            }

        
        
        
        }


    }

}