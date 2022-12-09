using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO;
using TP_Final.Domain;

namespace TP_Final.IO
{
    public static class UsefulMapper
    {
        private static Mapper iMapper;
        //probar con .includeAllDerived para los maps inherentes  o .include<cosaDTO, subCosa>
        public static Mapper Mapper
        {
            get
            {
                if (iMapper == null)
                {
                    iMapper = new Mapper(new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<User, UserDTO>();
                        cfg.CreateMap<UserDTO, User>();
                        cfg.CreateMap<BookDTO, Book>();
                        cfg.CreateMap<Book, BookDTO>();
                        cfg.CreateMap<Copy, CopyDTO>();
                        cfg.CreateMap<CopyDTO, Copy>();
                        cfg.CreateMap<Loan, LoanDTO>();
                        cfg.CreateMap<LoanDTO, Loan>();
                    }));
                }
                return iMapper
            ;}
            set {; } }
    }
}
