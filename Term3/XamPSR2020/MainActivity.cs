using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace XamPSR2020
{
    [Activity(Label = "Rock Paper Sizzor")]
    public class MainActivity : AppCompatActivity
    {

        ImageView GamePic;
        TextView txtMainMessage;
        Button btnPlay;
        string hum, name, comp;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Game);
            name = Intent.GetStringExtra("Name");
            Init();
        }

        void Init()
        {
            txtMainMessage = FindViewById<TextView>(Resource.Id.tvMessage);
            GamePic = FindViewById<ImageView>(Resource.Id.imgAnswer);
            btnPlay = FindViewById<Button>(Resource.Id.btnPlay);

            RadioButton RPaper = FindViewById<RadioButton>(Resource.Id.radPaper);
            RadioButton RSiscor = FindViewById<RadioButton>(Resource.Id.radSiscor);
            RadioButton RRock = FindViewById<RadioButton>(Resource.Id.radRock);

            RPaper.Click += radioButton_Click;
            RSiscor.Click += radioButton_Click;
            RRock.Click += radioButton_Click;

            btnPlay.Click += btnPlay_Click;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            comp = GamePlay.ComputerChoice();
            string roundResult = GamePlay.Play(hum, comp);

            switch (roundResult)
            {
                case "Win":
                    txtMainMessage.Text = "Well, lucky you, you won that round mate";
                    GamePic.SetImageResource(Resource.Drawable.a);
                    break;
                case "Draw":
                    txtMainMessage.Text = "HAHAHAHAHHAHAHAHAHAHAHAHA SHAME THE CHANCES AM I RIGHT!";
                    GamePic.SetImageResource(Resource.Drawable.b);
                    break;
                default:
                    txtMainMessage.Text = "Welp, you have done it this time, you loose idiot";
                    GamePic.SetImageResource(Resource.Drawable.c);
                    break;
            }
        }



        private void radioButton_Click(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;

            hum = rb.Text;

            txtMainMessage.Text = $"{name} you chose {hum}";

        }


    }
}