using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Net.Http;

namespace AfectacionMedioAmbiental.Models
{
    public class Persona
    {
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required(ErrorMessage =@"Ingrese el apellido")]
        [DisplayName("El Apellido")]
        public string Apellido { get; set; }
        public Celular Celular { get; set; }


        public async Task<bool> Saludar() 
        {
            Console.WriteLine("Saluda al Jefe y compañeros de trabajo");

            HttpClient cliente = new HttpClient();
            await cliente.GetAsync("http://paralelo.net");

            Console.WriteLine("Puedes ir a tu puesto de trabajo");
            return true;
        }

        public void Trabajar()
        {
            Console.WriteLine("Comienza a realizar el trabajo");

            Thread.Sleep(3000);

            Console.WriteLine("Termina de hacer el trabajo");
        }



    }
}
