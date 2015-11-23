using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    public class TratamentoDeString
    {
        public static void validar(String texto) {
            if (string.IsNullOrEmpty(texto))
                throw new Exception("String Null ou Vazia!");
            else if (texto.Length < 4)
                 throw new Exception("String muito pequena!");
            else if (texto.Equals("     "))
                 throw new Exception("String em branco!");
        }

        public static string removerCaracterEspecial(string texto)
        {
            #region Lista De Caracters
            List<string> listaCaracter = new List<string>();
            listaCaracter.Add("#");
            listaCaracter.Add("%");
            listaCaracter.Add("$");
            listaCaracter.Add("@");
            listaCaracter.Add("!");
            listaCaracter.Add("¨");
            listaCaracter.Add("*");
            listaCaracter.Add(")");
            listaCaracter.Add("(");
            listaCaracter.Add("-");
            listaCaracter.Add("_");
            listaCaracter.Add("+");
            listaCaracter.Add("=");
            listaCaracter.Add("{");
            listaCaracter.Add("}");
            listaCaracter.Add("~");
            listaCaracter.Add(":");
            listaCaracter.Add(";");
            #endregion
            foreach (string caracter in listaCaracter) {
                texto.Replace(caracter, "");
            }
            return texto;
        }

        public static void verificarCaracterEspecial(string texto) {
            #region Lista De Caracters
            List<string> listaCaracter = new List<string>();
            listaCaracter.Add("#");
            listaCaracter.Add("%");
            listaCaracter.Add("$");
            listaCaracter.Add("@");
            listaCaracter.Add("!");
            listaCaracter.Add("¨");
            listaCaracter.Add("*");
            listaCaracter.Add(")");
            listaCaracter.Add("(");
            listaCaracter.Add("-");
            listaCaracter.Add("_");
            listaCaracter.Add("+");
            listaCaracter.Add("=");
            listaCaracter.Add("{");
            listaCaracter.Add("}");
            listaCaracter.Add("~");
            listaCaracter.Add(":");
            listaCaracter.Add(";");
            #endregion

            if(listaCaracter.Contains(texto))
                throw new Exception("Caracter especial encontrado!!");
        }
    }
}
