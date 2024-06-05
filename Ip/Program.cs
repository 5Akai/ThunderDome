using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Formacion.CSharp.Ejercicios.ConsoleAppHTTP
{
    internal class Program
    {
        static HttpClient http;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n░░░░░░░░░░░▄▄▀▀▀▀▀▀▀▀▄▄\n░░░░░░░░▄▀▀░░░░░░░░░░░░▀▄▄\n░░░░░░▄▀░░░░░░░░░░░░░░░░░░▀▄\n░░░░░▌░░░░░░░░░░░░░▀▄░░░░░░░▀▀▄\n░░░░▌░░░░░░░░░░░░░░░░▀▌░░░░░░░░▌\n░░░▐░░░░░░░░░░░░▒░░░░░▌░░░░░░░░▐\n░░░▌▐░░░░▐░░░░▐▒▒░░░░░▌░░░░░░░░░▌\n░░▐░▌░░░░▌░░▐░▌▒▒▒░░░▐░░░░░▒░▌▐░▐\n░░▐░▌▒░░░▌▄▄▀▀▌▌▒▒░▒░▐▀▌▀▌▄▒░▐▒▌░▌\n░░░▌▌░▒░░▐▀▄▌▌▐▐▒▒▒▒▐▐▐▒▐▒▌▌░▐▒▌▄▐\n░▄▀▄▐▒▒▒░▌▌▄▀▄▐░▌▌▒▐░▌▄▀▄░▐▒░▐▒▌░▀▄\n▀▄▀▒▒▌▒▒▄▀░▌█▐░░▐▐▀░░░▌█▐░▀▄▐▒▌▌░░░▀\n░▀▀▄▄▐▒▀▄▀░▀▄▀░░░░░░░░▀▄▀▄▀▒▌░▐\n░░░░▀▐▀▄▒▀▄░░░░░░░░▐░░░░░░▀▌▐\n░░░░░░▌▒▌▐▒▀░░░░░░░░░░░░░░▐▒▐\n░░░░░░▐░▐▒▌░░░░▄▄▀▀▀▀▄░░░░▌▒▐\n░░░░░░░▌▐▒▐▄░░░▐▒▒▒▒▒▌░░▄▀▒░▐\n░░░░░░▐░░▌▐▐▀▄░░▀▄▄▄▀░▄▀▐▒░░▐\n░░░░░░▌▌░▌▐░▌▒▀▄▄░░░░▄▌▐░▌▒░▐\n░░░░░▐▒▐░▐▐░▌▒▒▒▒▀▀▄▀▌▐░░▌▒░▌\n░░░░░▌▒▒▌▐▒▌▒▒▒▒▒▒▒▒▐▀▄▌░▐▒▒▌\n   Gimme ur IP address UwU\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"Conectando");
            Console.Write(".");
            Console.Write(".");
            Console.Write($".");
            Console.WriteLine("");
            Console.ResetColor();

            http = new HttpClient();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Conectado!");

            ConsultarIp2();
        }
        static void ConsultarIp2()
        {

            Console.Write("Escribe una dirección de red: "); Console.ResetColor();
            string direccion = Console.ReadLine();

            var response = http.GetAsync($"http://ip-api.com/json/{direccion}").Result;
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);


                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Dirección: "); Console.ResetColor(); Console.WriteLine($"{data["query"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"ESTADO: "); Console.ResetColor(); Console.WriteLine($" {data["status"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"País: "); Console.ResetColor(); Console.WriteLine($" {data["country"]}[{data["countryCode"]}]");

                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Región: "); Console.ResetColor(); Console.WriteLine($" {data["regionName"]}[{data["region"]}]");

                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Ciudad: "); Console.ResetColor(); Console.WriteLine($" {data["city"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Código Postal: "); Console.ResetColor(); Console.WriteLine($" {data["zip"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Latitud: "); Console.ResetColor(); Console.WriteLine($" {data["lat"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Longitud: "); Console.ResetColor(); Console.WriteLine($" {data["lon"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Zona Horaria: "); Console.ResetColor(); Console.WriteLine($" {data["timezone"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Proveedor de Servicio: "); Console.ResetColor(); Console.WriteLine($" {data["isp"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"Organización: "); Console.ResetColor(); Console.WriteLine($" {data["org"]}");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write($"as: "); Console.ResetColor(); Console.WriteLine($" {data["as"]}");

            }
            else Console.WriteLine($"Error: {response.StatusCode}");

        }


    }
}
