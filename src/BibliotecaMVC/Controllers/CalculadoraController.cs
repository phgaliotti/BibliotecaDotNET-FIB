using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class CalculadoraController : Controller
    {
        public String Index()
        {
            return "Olá Mundo PH na area!";
        }
        public String NovaMensagem(string valor = "padrão")
        {
            return "O valor passado: " + valor;
        }
        public string Somar(decimal valor1 = 0, decimal valor2 = 0)
        {
            return string.Format("{0:N4} + {1:N4} = {2:N4}", valor1, valor2, valor1 + valor2);
        }
        public String Subtrair(decimal valor1 = 0, decimal valor2 = 0)
        {
            return string.Format("{0:N4} - {1:N4} = {2:N4}", valor1, valor2, valor1 - valor2);
        }
        public String Multiplicar(decimal valor1 = 1, decimal valor2 = 1)
        {
            return string.Format("{0:N4} * {1:N4} = {2:N4}", valor1, valor2, valor1 * valor2);
        }
        public String Dividir(decimal valor1 = 1, decimal valor2 = 1)
        {
            if (valor2 == 0) {
                return "Nao eh possivel dividir por zero! Digite outro numero";
            } else {

                return string.Format("{0:N4} / {1:N4} = {2:N4}", valor1, valor2, valor1 / valor2);
            }
        }
    }
}