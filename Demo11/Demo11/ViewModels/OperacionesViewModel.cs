using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo11.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {

        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor3;
        public int Valor3
        {
            get { return valor3; }
            set
            {
                if (valor3 != value)
                {
                    valor3 = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Sumar { protected set; get; }
        public ICommand Multiplicar{ protected set; get; }

        public OperacionesViewModel() { 
            Sumar = new Command(() =>
            {
                ResultadoSuma = Valor1 + Valor2+ Valor3;
            });

            Multiplicar = new Command(() =>
            {
                ResultadoSuma = Valor1 * Valor2 * Valor3;
            });
        }
    }
}
