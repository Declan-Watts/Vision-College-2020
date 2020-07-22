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

namespace XamCalculator2020
{
    [Activity(Label = "BMIActivity")]
    public class BMIActivity : Activity
    {
        private EditText txtWeight;
        private EditText txtHeight;

        private TextView txtResult;
        private TextView txtMessage;

        private double weight;
        private double height;
        private double bmiResult;

        private Button bmiCalc;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.BMI);
            InitializeControlls();
            // Create your application here
        }

        void InitializeControlls()
        {
            txtWeight = FindViewById<EditText>(Resource.Id.textWeight);
            txtHeight = FindViewById<EditText>(Resource.Id.textHeight);
            txtResult = FindViewById<TextView>(Resource.Id.txtResult);
            txtMessage = FindViewById<TextView>(Resource.Id.txtMessage);

            bmiCalc = FindViewById<Button>(Resource.Id.bmiCalc);

            bmiCalc.Click += onCalculate_Click;

        }

        private void onCalculate_Click(object sender, EventArgs e)
        {
            weight = Convert.ToDouble(txtWeight.Text);
            height = Convert.ToDouble(txtHeight.Text) / 100;

            bmiResult = weight / (height * height);

            txtResult.Text = Math.Round(bmiResult, 2).ToString();
            txtMessage.Text = Math.Round(bmiResult, 2).ToString();

        }
    }
}