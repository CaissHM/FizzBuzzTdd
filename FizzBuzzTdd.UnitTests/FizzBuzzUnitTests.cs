using FizzBuzzTdd.Domain;
using System;
using Xunit;

namespace FizzBuzzTdd.UnitTests
{
    public class FizzBuzzUnitTests
    {
        private FizzBuzz fizzBuzz;

        public FizzBuzzUnitTests()
        {
            fizzBuzz = new FizzBuzz(); //coloquei a inst�ncia em uma vari�vel que se inicializa no construtor pq o construtor roda antes de cada teste, ou seja, que vou ter uma vari�vel s� sendo usada e inicializada em todos os testes ao inv�s de uma nova inst�ncia manual (var sut = new FizzBuzz()) em cada teste
        }

        [Fact]
        public void NumberIsMultiple_Of3And5_ReturnsFizzBuzz() //NumberIsMultiple_Of<n�meros que t�m que ser m�ltiplo>_Returns<retorno esperado>
        {
            //Assert.Equal("FizzBuzz", fizzBuzz.Of(15));

            //refatorando:
            //Arrange
            var expected = "FizzBuzz";

            //Act
            var actual = fizzBuzz.Of(-15);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberIsMultiple_Of3_ReturnsFizz() 
        {
            //Assert.Equal("Fizz", fizzBuzz.Of(9));

            //refatorando:
            //Arrange
            var expected = "Fizz";

            //Act
            var actual = fizzBuzz.Of(9);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberIsMultiple_Of5_ReturnsBuzz()
        {
            //Assert.Equal("Buzz", fizzBuzz.Of(25));

            //refatorando:
            //Arrange
            var expected = "Buzz";

            //Act
            var actual = fizzBuzz.Of(25);

            //Assert
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void NumberIsntMultiple_Of3Or5Or3And5_ReturnsNumber()              *m�todo do "Caso contr�rio, retorna o pr�prio n�mero."*
        //{
        //    //Assert.Equal("Buzz", fizzBuzz.Of(25));

        //    //refatorando:
        //    //Arrange
        //    var expected = "Buzz";

        //    //Act
        //    var actual = fizzBuzz.Of(25);

        //    //Assert
        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void NumberIs0_ReturnsFizzBuzz()
        {
            Assert.Equal("FizzBuzz", fizzBuzz.Of(0));

            ////refatorando:
            ////Arrange
            //var expected = "Buzz";

            ////Act
            //var actual = fizzBuzz.Of(25);

            ////Assert
            //Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberIs1_Returns1() //t� dando erro pq depende do "NumberIsntMultiple_Of3Or5Or3And5_ReturnsNumber()"
        {
            //Assert.Equal("1", fizzBuzz.Of(1));

            //refatorando:
            //Arrange
            var expected = "1";

            //Act
            var actual = fizzBuzz.Of(1);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
