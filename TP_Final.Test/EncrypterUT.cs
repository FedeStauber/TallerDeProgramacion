using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TP_Final.Domain;

namespace TP_Final.Test
{
    public class EncrypterUT
    {
        [Fact]
        public void Encrypt_Decrypt_HP1()
        {
            //Arrange
            string stringToEncrypt = "Hola";
            string result;
            //Act
            result = Encrypter.Encrypt(stringToEncrypt);            
            //Assert         
            Assert.Equal(stringToEncrypt, result);
        }
    }
}
