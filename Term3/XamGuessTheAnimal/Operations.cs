using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

using Android.App;
using Android.Content;
using Android.Drm;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamGuessTheAnimal
{
    static class Operations
    {

        // Some favourite animals

        private static string[] animalData()
        {
            return new string[] { "qwer", "tree", "wer" };
        }

        public static IEnumerable<string> getAnimals(string[] animalData)
        {
            List<string> listNames = new List<string>();

            foreach (var animal in animalData)
            {
                listNames.Add(animal.Replace("-", " ").ToLower());
            }
            return listNames;
        }

        public static int randomNumber(int max)
        {
            Random rnd = new Random();

            int rndNumber = rnd.Next(0, max);

            return rndNumber;
        }

        public static string GetRandomWord()
        {
            List<string> words = new List<string>();
            words.AddRange(getAnimals(animalData()));
            int rnd = randomNumber(words.Count);

            return words[rnd];
        }


    }
}