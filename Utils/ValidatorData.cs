using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PalcoNet.Utils
{
    public class ValidatorData
    {

        private String messagesErrors = String.Empty;
        private int countErrors = 0;
        public static readonly PairData REGEX_CUIT 
            = new PairData("El número de cuit debe contar con una longitud de 11 cifras, y comenzar con 30, 33 o 34. Se permiten guiones. No debe ser nulo.",
                "(30|33|34)(-)?[0-9]{8}(-)?[0-9]");
        public static readonly PairData REGEX_CUIL
            = new PairData("El número de cuit debe contar con una longitud de 11 cifras, y comenzar con 20, 23, 24 0 27. Se permiten guiones. No debe ser nulo.",
                "(20|23|24|27)(-)?[0-9]{8}(-)?[0-9]");
        public static readonly PairData REGEX_EMAIL 
            = new PairData("El formato de email debe corresponder a uno válido. No debe ser nulo.",
                "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        public static readonly PairData REGEX_TELEFONO
            = new PairData("El telefono es incorrecto, debe tener entre 3 y 20 dígitos sin guiones.",
                "[0-9]{3,20}");
        public static readonly PairData REGEX_PISO
            = new PairData("El Piso debe tener un máximo de 3 dígitos. Admite nulo.",
                "[\\d]{0,3}");
        public static readonly PairData REGEX_DEPARTAMENTO
             = new PairData("El Departamento debe tener una longitud alfanumérica máxima de 3. Admite nulo.",
                 "[\\w\\d]{0,3}");
        public static readonly PairData REGEX_CIUDAD
             = new PairData("La ciudad debe tener una longitud alfanumérica mínima de 3 y una máxima de 255.",
                 "[\\w\\dáéíóú]{3,255}");
        public static readonly PairData REGEX_CODIGO_POSTAL
             = new PairData("El Código Postal debe tener una longitud alfanumérica mínima de 3 y una máxima de 8.",
                 "[\\w\\d]{3,8}");
        public static readonly PairData REGEX_RAZON_SOCIAL
             = new PairData("La razón social debe tener una longitud alfanumérica mínima de 3 y una máxima de 255.",
                 "[\\w\\dáéíóú]{3,255}");
        public static readonly PairData REGEX_LOCALIDAD
             = new PairData("La Localidad debe tener una longitud alfanumérica mínima de 3 y una máxima de 255.",
                 "[\\w\\dáéíóú]{3,255}");
        public static readonly PairData REGEX_DIRECCION
             = new PairData("La Dirección debe tener una longitud alfanumérica mínima de 3 y una máxima de 255.",
                 "[\\w\\dáéíóú]{3,255}");
        public static readonly PairData REGEX_NOMBRE
             = new PairData("El nombre debe tener una longitud mínima de 3 y una máxima de 255 caracteres.",
                 "[\\wáéíóú]{3,255}");
        public static readonly PairData REGEX_APELLIDO
             = new PairData("El apellido debe tener una longitud mínima de 3 y una máxima de 255 caracteres.",
                 "[\\wáéíóú]{3,255}");
        public static readonly PairData REGEX_NUMERO_DOCUMENTO
             = new PairData("El número de documento debe tener entre 3 y 10 dígitos.",
                 "[\\d]{3,10}");
        public static readonly PairData REGEX_TARJETA_CREDITO
             = new PairData("La tarjeta de crédito debe tener entre 13 y 19 dígitos. Admite nulos.",
                 "^$|([\\d]{13,19})");
        public static readonly PairData REGEX_DESCRIPCION_GRADO
            = new PairData("La descripción del grado debe tener una longitud alfanumérica mínima de 3 y una máxima de 255 caracteres.",
                "[\\wáéíóú]{3,10}");
        public static readonly PairData REGEX_COMISION
            = new PairData("La comisión debe estar entre 0 y 100 y representa un porcentaje.",
                "([0-9]|[1-9][0-9]|100)");
        public static readonly PairData REGEX_PASSWORD
            = new PairData("La contraseña debe tener un mínimo de 8 y un máximo de 20 caracters, con al menos 1 número.",
                "(?=.*\\d)(?=.*[a-z])[0-9a-zA-Z]{8,20}");
        public static readonly PairData REGEX_USUARIO
            = new PairData("El usuario debe debe tener un minimo de 5 y un máximo de 15 caracteres.",
                "(?=.*\\d)(?=.*[a-z])[0-9a-zA-Z]{8,20}");

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
                    + lengthMax + " caracteres.";
                AddMessaggeError(messaggeError);
            }
        }

        public void ValidateBetweenTwoLengths(String fieldName, String text, int lengthMin, int lengthMax)
        {
            if (text.Length < lengthMin || text.Length > lengthMax)
            {
                String messaggeError = "El campo "
                    + fieldName + " debe tener una longitud minima de "
                    + lengthMin + " y una maxima de " + lengthMax + " caracteres.";
                AddMessaggeError(messaggeError);
            }
        }

        private void AddMessaggeError(String Message)
        {
            countErrors++;
            this.messagesErrors += "-> " + Message + "\n";
        }

        private bool HasErrors()
        {
            return countErrors > 0;
        }

        public bool ShowIfThereAreErrors()
        {
            if (HasErrors()) {
                String messaggeToShow = "Se han detectado " + this.countErrors + " errores: \n";
                messaggeToShow += messagesErrors;
                MessageBox.Show(messaggeToShow, "Error");
                return true;
            }
            return false;
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

        public static bool validateEmptyFields(GroupBox groupBox)
        {
            var textBoxes = groupBox.Controls.Cast<Control>()
                                     .OfType<TextBox>()
                                     .OrderBy(control => control.TabIndex);

            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Error");
                    return true;
                }
            }

            return false;

        }

    }
}
