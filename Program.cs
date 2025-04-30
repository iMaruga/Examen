using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp;
            int playerSTR;
            Boolean LoopStats = true;


            int QuantityEnemies;

            Player player = new Player();


            
            Console.WriteLine("Ingresa tu nombre.");

            string name = Console.ReadLine();

            Console.WriteLine($"Bienvenid@ {name} a esta aventura.\n Ingresaremos tus estadisticas. de Vida y Fuerza, estas no pueden superar 100 juntas\n (Ejm: 50 Vida, 50 Fuerza)"  );

            while (LoopStats == true)
            {

                Console.WriteLine("Dime, cuanta Vida tienes?");
                playerHp = player.PlayerHealth();
                Console.WriteLine("Ahora, cuanta Fuerza tienes?");
                playerSTR = player.PlayerStrength();

            
                if (playerHp + playerSTR <= 100) 
                {
                    Console.WriteLine($"Genial! Tienes {playerHp} de Vida y {playerSTR} de fuerza!\n Empecemos....");
                    LoopStats = false;
                    Gameplay(playerHp, playerSTR);

                }
                else 
                {
                    Console.WriteLine("Los valores juntos no pueden ser mayor a 100!");
                    LoopStats = true;
                }


            }

            



        }

        private int Gameplay(int playerHp, int playerSTR)
        {
            Boolean LoopGameplay;
            LoopGameplay = true;

            while (LoopGameplay == true)

            {
                Console.WriteLine("Cuantos enemigos quieres enfrentar? (No puede superar 5)");
                int enemyamount = int.Parse(Console.ReadLine());




            }


        }
    }
}
