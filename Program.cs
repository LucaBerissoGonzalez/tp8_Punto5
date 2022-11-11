using System;

namespace tp8_Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes, dia;
            int acumulador = 0;
            int diasParaTerminar;
           
            string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            int[] diasMeses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Ingrese el Numero de Mes del año: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el dia del mes {0} :" , meses[mes-1] );
            dia = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < mes-1;i++){

                 acumulador = acumulador + diasMeses[i];   

            }

            diasParaTerminar = 365 - (acumulador + dia);

            Console.WriteLine("Te Faltan {0} dias para terminar el año.\n", diasParaTerminar);


            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
