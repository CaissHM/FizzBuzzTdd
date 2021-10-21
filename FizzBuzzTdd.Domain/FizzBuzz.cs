using System;

namespace FizzBuzzTdd.Domain
{
    public class FizzBuzz
    {
        public string Of(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
            else if (num % 3 == 0) return "Fizz";
            else if (num % 5 == 0) return "Buzz";
            else return ""; //1º teste: se eu não colocar um retorno vazio em uma linha do código o método não compila - o código não aceita só "return" já que o retorno é "string"
        }
    }
}
