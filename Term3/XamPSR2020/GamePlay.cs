using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamPSR2020
{
    public static class GamePlay
    {
        public static string ComputerChoice()
        {
            var CompGuess = new Random();

            string[] Guess = { "", "Paper", "Siscor", "Rock" };


            return Guess[CompGuess.Next(1, 4)];
        }

        public static string Play(string hum, string comp)
        {
            //Win
            if ((hum == "Paper" && comp == "Rock") || (hum == "Siscor" && comp == "Paper") || (hum == "Rock" && comp == "Siscor"))
            {
                return "Win";
            }
            else if (hum == comp)
            {
                return "Draw";
            }
            else
            {
                return "Lose";
            }
        }


    }
}