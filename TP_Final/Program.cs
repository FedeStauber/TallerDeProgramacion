using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;
using Serilog;
using TP_Final.IO;
using TP_Final.API;
using TP_Final.API.OpenLibrary;
using TP_Final.UI;
using AutoMapper;
using TP_Final.DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TP_Final
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            // Se crea y configura el Scheduler.          
             IScheduler sched = StdSchedulerFactory.GetDefaultScheduler().Result;
             sched.Start();
             IJobDetail job = JobBuilder.Create<Notificate>()
                     .WithIdentity("job1", "group1")
                     .Build();
             ITrigger trigger = TriggerBuilder.Create()
                 .WithIdentity("trigger1", "group1")
                 .WithSimpleSchedule(x => x.WithIntervalInSeconds(30).RepeatForever())
                 .Build();
             sched.ScheduleJob(job, trigger);

           
            // Se configura la clase estatica Log.           
            Log.Logger = new LoggerConfiguration().WriteTo.RollingFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Logs\Log-{Date}.txt"))
                .MinimumLevel.Verbose()
                .CreateLogger();

           
            // Se configura la clase estatica BookApiManager para seleccionar la API de la cual se obtienen los datos para agregar nuevos libros.           
            BookApiManager.CurrentApi = new OpenLibraryApi();



            // Se asegura de que existe el modelo en la base de datos, si no existe lo crea y agrega el usuario administrador por defecto.            
            using (LibraryManagerDbContext dbContext = new LibraryManagerDbContext())
            {
                if (dbContext.Database.EnsureCreated())
                {
                  LibraryManager.AddUser(new UserDTO() { Admin = true, Email = "admin@admin.com", Password = "123", Name = "Federico", LastName = "Stauber", DNI = 156, Active = true });
                }                
            }
          


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow()); ;
            

           
            
          
        }
    }
}
