using System;

namespace practica2complejidad
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int items,capacidad,peso,valor,divisibles;
            int flag = 0;

            //Creacion de arrays para mochilas de 3, 5 y 10 objetos
            //3
            int[] pesos3=new int [3];
            int[] valores3 = new int[3];
            //5
            int[] pesos5 = new int[5];
            int[] valores5= new int[5];
            //10
            int[] pesos10 = new int[10];
            int[] valores10 = new int[10];


            int[] value = { 60, 100, 120 };
            int[] weight = { 10, 20, 30 };
            int capacity = 50;
            int itemsCount = 3;
            int result;
            

            Console.WriteLine("Introduzca el numero de elementos: ");
            items = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el peso de la mochila: ");
            capacidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el peso y el valor de cada objeto");

            switch (items)
            {
                case 3:
                    for (int i = 0; i < items; i++)
                    {
                        Console.Write("Objeto");
                        Console.Write(i);
                        peso = int.Parse(Console.ReadLine());
                        valor = int.Parse(Console.ReadLine());
                        pesos3[i] = peso;
                        valores3[i] = valor;
                        flag = 3;
                    }
                    break;
                case 5:
                    for (int i = 0; i < items; i++)
                    {
                        Console.Write("Objeto");
                        Console.Write(i);
                        peso = int.Parse(Console.ReadLine());
                        valor = int.Parse(Console.ReadLine());
                        pesos5[i] = peso;
                        valores5[i] = valor;
                        flag = 5;
                    }
                    break;
                case 10:
                    for (int i = 0; i < items; i++)
                    {
                        Console.Write("Objeto");
                        Console.Write(i);
                        peso = int.Parse(Console.ReadLine());
                        valor = int.Parse(Console.ReadLine());
                        pesos10[i] = peso;
                        valores10[i] = valor;
                        flag = 10;
                    }
                    break;
                default: Console.WriteLine("Introduce el numero correcto de items");
                    break;
            }

            Console.WriteLine("Criterio de seleccion:");
            Console.WriteLine("Peso de menor a mayor");
            //
            Console.WriteLine("Peso de mayor a menor");
            //
            Console.WriteLine("Valor/peso de mayor a menor");
            //
            Console.WriteLine("Son divisibles=0 o no divisibles=1 ");
            divisibles = int.Parse(Console.ReadLine());
            switch (divisibles)
            {
                case 0:
                    //Voraz estatico
                    switch (flag)
                    {
                        case 3:
                             result = Voraz.KnapSack(items, pesos3, valores3, itemsCount);
                            Console.WriteLine(result);
                            break;
                        case 5:
                             result = Voraz.KnapSack(items, pesos5, valores5, itemsCount);
                            Console.WriteLine(result);
                            break;
                        case 10:
                             result = Voraz.KnapSack(items, pesos10, valores10, itemsCount);
                            Console.WriteLine(result);
                            break;
                        default:
                            break;
                    }
                    
                    break;
                case 1:
                    //Voraz dinamico
                    break;
                default:
                    Console.WriteLine("Numero incorrecto");
                    break;
            }
        }
    }
}
