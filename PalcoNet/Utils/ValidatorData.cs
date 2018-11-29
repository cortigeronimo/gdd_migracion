using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalcoNet.Utils
{
    public class ValidatorData
    {

        private String messagesErrors = String.Empty;
        private int countErrors = 0;
        public static readonly PairData REGEX_CUIT 
            = new PairData("El número de cuit debe contar con una longitud de 11 cifras.", "REGEX");
        public static readonly PairData REGEX_EMAIL 
            = new PairData("El email no es correcto.", "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");

        public String MessagesErrors
        {
            get
            {
                return messagesErrors;
            }
        }

        public int CountErros 
        {
            get 
            {
                return countErrors;
            }
        }

        public void ValidateTextWithRegex(String text, PairData pair)
        {
            if(!Regex.IsMatch(text, pair.regex)){
                AddMessaggeError(pair.errorMessagge);
            }
        }

        public void ValidateLength(String fieldName, String text, int lengthMax)
        {
            if (text.Length > lengthMax)
            {
                String messaggeError = "El campo "
                    + fieldName + " debe tener una longitud maxima de " 
                    + lengthMax + " caracteres";
                AddMessaggeError(messaggeError);
            }
        }

        public void ValidateBetweenTwoLengths(String fieldName, String text, int lengthMin, int lengthMax)
        {
            if (text.Length < lengthMin || text.Length > lengthMax)
            {
                String messaggeError = "El campo "
                    + fieldName + " debe tener una longitud minima de "
                    + lengthMin + " y una maxima de " + lengthMax + " caracteres";
                AddMessaggeError(messaggeError);
            }
        }

        private void AddMessaggeError(String Message)
        {
            countErrors++;
            this.messagesErrors += Message + "\n";
        }

        public bool HasErrors()
        {
            return countErrors > 0;
        }

        public class PairData
        {
            public readonly String errorMessagge;
            public readonly String regex;

            public PairData(String errorMessagge, String regex){
                this.errorMessagge = errorMessagge;
                this.regex = regex;
            }
        }

    }
}
