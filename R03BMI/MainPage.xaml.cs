using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A31 日野 雅貴";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string height=height.Text;
            string weight=weight.Text;

            try
            {
                double h=double.Parse(height);
                double w=double.Parse(weight);
                if (height>3)
                {
                    height=height/100;
                }

                if (weight > 400)
                {
                    weight=weight/1000;
                }

                double bmi=Math.Round(w/(h*h),1);

                if (bmi < 18.5)
                {
                    result.Text="BMI"+bmi+"(低体重)";
                }
                else if (bmi < 25)
                {
                    result.Text="BMI"+bmi+"(普通体重)";
                }
                else if (bmi < 30)
                {
                    result.Text="BMI"+bmi+"(肥満（１度）)";
                }
                else if (bmi < 35)
                {
                    result.Text="BMI"+bmi+"(肥満（２度）)";
                }
                else if (bmi < 40)
                {
                    result.Text="BMI"+bmi+"(肥満（３度）)";
                }
                else
                {
                    result.Text="BMI"+bmi+"(肥満（４度）)";
                }
            }
            catch
            {
                Console.WriteLine(ex);
                result.Text="error";
            }
            
        }
    }
}
