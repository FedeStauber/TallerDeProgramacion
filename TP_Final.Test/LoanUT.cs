using System;
using Xunit;
using TP_Final.Domain;

namespace TP_Final.Test
{
    public class LoanUT
    {

        //hice solo este porque no se si esta bien crear copy y user para este test,
        //y tampoco se como comparar todo junto con un solo assert
        [Fact]
        public void ReturnRegisterHP1()
        {
            //Arrange
            string strStartDate = "6/1/2020 6:34:53";
            DateTime startDate = DateTime.Parse(strStartDate);
            string strEndDate = "16/1/2020 6:34:53";
            DateTime endDate = DateTime.Parse(strEndDate);
            string strReturnDate = "15/1/2016 6:34:53";
            DateTime returnDate = DateTime.Parse(strReturnDate);
            User user = new User() { Id = 1, Score = 0};
            Loan loan = new Loan() { Id = 1, StartDate = startDate, EndDate = endDate, ReturnDate = null };
            Copy copy = new Copy() { Id = 3, Condition = Copy.ConditionEnum.Borrowed, LastModify = startDate };
            //Act
            loan.ReturnRegister(Copy.ConditionEnum.Available);
            //Assert
            Assert.Equal(user.Score, 5);
            Assert.Equal(loan.LoanScore, 5);
            Assert.Equal(loan.ReturnDate, DateTime.Today);
            Assert.Equal(Copy.ConditionEnum.Available, copy.Condition);

        }




    }
}
