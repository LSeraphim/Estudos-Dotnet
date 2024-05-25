using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;
        private string data;
            public CalculadoraImp(string data)
            {
                listaHistorico = new List<string>();
                this.data = data; 
            }

        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, "Resultado : " + resultado + "- data: " + data);
            return resultado;
        }
        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, "Resultado : " + resultado + "- data: " + data);
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, "Resultado : " + resultado + "- data: " + data);
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listaHistorico.Insert(0, "Resultado : " + resultado + "- data: " + data);   
            return resultado;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}