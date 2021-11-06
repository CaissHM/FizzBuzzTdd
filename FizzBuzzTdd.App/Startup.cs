using FizzBuzzTdd.Domain;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzTdd.App
{
    public class Startup : IHostedService
    {
        private readonly FizzBuzz _fizzBuzz;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public Startup(FizzBuzz fizzBuzz, CancellationTokenSource cancellationTokenSource)
        {
            _fizzBuzz = fizzBuzz;
            _cancellationTokenSource = cancellationTokenSource;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var firstOp = _fizzBuzz.Of(5);
            Console.WriteLine($"Resultado (esperado = Buzz): {firstOp}");

            var secondOp = _fizzBuzz.Of(10);
            Console.WriteLine($"Resultado (esperado = Buzz): {secondOp}");

            var thirdOp = _fizzBuzz.Of(9);
            Console.WriteLine($"Resultado (esperado = Fizz): {thirdOp}");

            var fourthOp = _fizzBuzz.Of(15);
            Console.WriteLine($"Resultado (esperado = FizzBuzz): {fourthOp}");

            var fifthOp = _fizzBuzz.Of(0);
            Console.WriteLine($"Resultado (esperado = FizzBuzz): {fifthOp}");

            var sixthOp = _fizzBuzz.Of(1);
            Console.WriteLine($"Resultado (esperado = 1): {sixthOp}");

            var seventhOp = _fizzBuzz.Of(-15);
            Console.WriteLine($"Resultado (esperado = FizzBuzz): {seventhOp}");

            _cancellationTokenSource.Cancel();

            return;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Parando a aplicação...");
            return;
        }
    }
}
