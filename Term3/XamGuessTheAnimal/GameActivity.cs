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

namespace XamGuessTheAnimal
{
    [Activity(Label = "GameActivity", MainLauncher = true)]
    public class GameActivity : Activity
    {

        // Keyboard
        Button btnQ;
        Button btnW;
        Button btnE;
        Button btnR;
        Button btnT;

        // General
        TextView txtWord;
        Button btnPlay;

        // Global Variables
        char[] chosenWordArray;
        char[] currentGameWordArray;
        string chosenWord;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.game);

            // Binding General Resources
            generalInit();

            //Binding Keyoard Inputs
            keyboardInit();

            //
        }

        private void generalInit()
        {
            txtWord = FindViewById<TextView>(Resource.Id.tvWord);
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);

            btnPlay.Click += btnPlay_Click;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            loadWord();
        }

        private void keyboardInit()
        {
            btnQ = FindViewById<Button>(Resource.Id.btnQ);
            btnW = FindViewById<Button>(Resource.Id.btnW);
            btnE = FindViewById<Button>(Resource.Id.btnE);
            btnR = FindViewById<Button>(Resource.Id.btnR);
            btnT = FindViewById<Button>(Resource.Id.btnT);

            btnQ.Click += keyboardButton_Click;
            btnW.Click += keyboardButton_Click;
            btnE.Click += keyboardButton_Click;
            btnR.Click += keyboardButton_Click;
            btnT.Click += keyboardButton_Click;
        }

        private void keyboardButton_Click(object sender, EventArgs e)
        {
            Button fakeBtn = (Button)sender;
            fakeBtn.Enabled = false;
            gamePlay(fakeBtn.Text.ToLower());


        }


        /// <summary>
        /// Load in our word, and fill the Char Arrays and Text View
        /// </summary>
        private void loadWord()
        {
            // Empty the Text View
            txtWord.Text = string.Empty;

            chosenWord = Operations.GetRandomWord();

            // Getting random word then Turn the word into a Char array
            chosenWordArray = chosenWord.ToCharArray();

            // Setting the Array with the hidden letters to the length of the chosen word
            currentGameWordArray = new char[chosenWordArray.Length];
            for (int i = 0; i < chosenWordArray.Length; i++)
            {
                txtWord.Text += "_ ";
                currentGameWordArray[i] = '_';
            }


        }

        /// <summary>
        /// General Gameplay Checks
        /// </summary>
        /// <param name="letter">The button letter that you press</param>
        private void gamePlay(string letter)
        {
            if (chosenWord.Contains(letter))
            {
                for (int i = 0; i < chosenWordArray.Length; i++)
                {
                    if (letter == chosenWordArray[i].ToString())
                    {
                        currentGameWordArray[i] = Convert.ToChar(letter);
                    }
                }
            }
            else
            {
                return;
            }

            string txt = "";

            foreach (var l in currentGameWordArray)
            {
                txt += $"{l} ".ToString();
            }

            txtWord.Text = txt;

        }

    }
}