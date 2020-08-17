using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public Persona Persona { get; set; }


        public async Task<bool> Organizar()
        {
            Console.WriteLine("La empresa organiza a sus trabajadores");

            HttpClient cliente = new HttpClient();
            await cliente.GetAsync("http://paralelo.net");

            Console.WriteLine("La empresa coloca a cada trabajor en su respectivo puesto de trabajo");
            return true;
        }

        public void Funcionar()
        {
            Console.WriteLine("La empresa contrata a los empleados");

            Thread.Sleep(2000);

            Console.WriteLine("En la empresa despide a los empleados");
        }
    }
}
