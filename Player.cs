using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLM
{
    internal class Player
    {
        int playerHp;
        int playerSTR;
       
        public int PlayerHealth()
        {
            int playerHp = this.playerHp;
            playerHp = int.Parse(Console.ReadLine());
            return playerHp;
        }
        public int PlayerStrength()
        {
            int playerSTR = this.playerSTR;
            playerSTR = int.Parse(Console.ReadLine());
            return playerSTR;
        }
                         
    }
}
