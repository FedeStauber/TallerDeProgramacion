using System;
using Xunit;
using TP_Final.Domain;

namespace TP_Final.Test
{
    public class CopyUT
    {
        [Fact]
        public void ChangeConditionHP()
        {
            //Arrange
            Copy copy = new Copy() { Id = 1, Condition = Copy.ConditionEnum.Available, LastModify = DateTime.Today };
            //Act            
            copy.ChangeCondition(Copy.ConditionEnum.Broken);
            //Assert
            Assert.Equal(Copy.ConditionEnum.Broken, copy.Condition);
        }

        //public void ChangeConditionNHP()
        //{
        //Arrange
        // Copy copy = new Copy() { Id = 2, Condition = Copy.ConditionEnum.Borrowed, LastModify = DateTime.Today };
        //Act            
        //  copy.ChangeCondition(Copy.ConditionEnum.Unavailable);
        //Assert
        //Assert.ThrowsAny<Exception>(copy.ChangeCondition(Copy.ConditionEnum.Unavailable));
        //  }

        [Fact]
        public void ReturnRegisterHP()
        {
            //Arrange
            string strFecha = "6/1/2016 6:34:53";
            DateTime fecha = DateTime.Parse(strFecha);
            Copy copy = new Copy() { Id = 3, Condition = Copy.ConditionEnum.Borrowed, LastModify = fecha };
            //Act            
            copy.ReturnRegister(Copy.ConditionEnum.Available);
            //Assert
            Assert.Equal(Copy.ConditionEnum.Available, copy.Condition);
            Assert.Equal(DateTime.Today, copy.LastModify);

        }

        [Fact]

        public void ReturnRegisterNHP()
        {
            //Arrange
            string strFecha = "25/12/2016 8:39:51";
            DateTime fecha = DateTime.Parse(strFecha);
            Copy copy = new Copy() { Id = 4, Condition = Copy.ConditionEnum.Broken, LastModify = fecha };
            //Act 
            copy.ReturnRegister(Copy.ConditionEnum.Available);
            //Assert
            //falta encontrar como hacer el assert.equals
        }

    }
}
