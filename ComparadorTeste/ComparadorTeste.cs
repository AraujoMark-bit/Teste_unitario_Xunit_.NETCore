using CompararNumeros;
using Xunit;

namespace ComparadorTeste {
    public class ComparadorTeste {
        [Fact]
        public void VerificarN1MaiorNumero_ResultTrue() {

            // Arrange
            int  n1 = 10;
            int n2 = 9;
            // Act
            bool result = CompararNumero.MaiorNumero(n1, n2);
            // Assert
            Assert.True(result);
        }


        [Fact]
        public void VerificarMenorNumero_ResultFalse() {

            // Arrange
            int n1 = 10;
            int n2 = 9;
            // Act
            bool result = CompararNumero.MenorNumero(n1, n2);
            // Assert
            Assert.False(result);
        }


        [Fact]
        public void VerificarNumerosIguais_ResultTrue() {

            // Arrange
            int n1 = 200;
            int n2 = 250;
            int n3 = 200;
            // Act
            bool result = CompararNumero.SemNumeroMaior(n1, n2, n3);
            // Assert
            Assert.True(result);
        }
    }
}
