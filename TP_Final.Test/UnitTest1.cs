using System;
using Xunit;
using TP_Final.Domain;

namespace TP_Final.Test
{
    public class UnitTest1
    {
        [Fact]
        public void EmailEstrategyTest()
        {
            //Arrange
            User usuario = new User() { Email = "fedestauber@gmail.com"};
            Loan prestamo = new Loan() { User = usuario };
            EmailEstrategy estrategia = new EmailEstrategy();
            //Act            
            estrategia.Notify(prestamo);
            //Assert
        }
    }
}
