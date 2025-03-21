using System;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace hello_git
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.marca = "fiat uno";
            auto.color = "blanco";
            auto.patente = "dgr123";

            Console.WriteLine($"Los datos del auto son: {auto.marca}, {auto.color}, {auto.patente} ");

            auto.EncenderAuto();
            auto.Avanzar();


            Jugador jugador = new Jugador();
            jugador.vida = 10;
            jugador.nivel = 43;
            jugador.nombre = "jugador_1";

            Console.WriteLine($"Info del jugador: Nombre: {jugador.nombre}, Nivel {jugador.nivel}, Vida: {jugador.vida}/20");

            jugador.Comer();
            jugador.Atacar();




        }
        public class Auto
        {
            public string patente;
            public string marca;
            public string color;


            public void EncenderAuto()
            {
                Console.WriteLine("BRUMMMMMM");
            }
            public void Avanzar()
            {
                Console.WriteLine("El auto esta avanzando");
            }
        }

        public class Jugador
        {
            public int vida;
            public int nivel;
            public string nombre;


            public void Comer()
            {

                Console.WriteLine("ñom ñom ñom");
            }


            public void Atacar()
            {
                Console.WriteLine($"El jugador {nombre} ataco");
            }


        }


    }
}