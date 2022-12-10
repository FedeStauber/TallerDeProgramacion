using System;
using Xunit;
using TP_Final.Domain;

namespace TP_Final.Test
{
    public class UserUT
    {
        [Fact]
        public void LoadUsuario()
        {
            //Arrange
            User user = new User() { Id = 1, DNI = 95980549, Email = "echevestevillavicenciolucas@gmail.com", Score = 0, Password = "1230", Name = "Lucas", LastName = "Echeveste", Avatar = null, _Admin = 0, _Active = 1};
            //Act            
            copy.ChangeCondition(Copy.ConditionEnum.Broken);
            //Assert
            Assert.Equal(Copy.ConditionEnum.Broken, copy.Condition);
        }

    }
}
