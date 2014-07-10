using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace cuadrado_con_datos_privados
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //... class cuadrado
        }
                //area de datos
                private double lado;
                private double area;

                public double Lado{
                    get{
                        return Lado;
                    }

                    set
                    {
                        lado = value;
                    }

            

        }
    }
    }  