using System;
namespace practica2complejidad
{
    public class Voraz
    {
        public Voraz()
        {
        }
		//Falta array de objetos
		public static int mochila(Item[] array,int items, int capacidad_maxima)
		{

			int[] x = new int[items];
			//falta ordenar objetos segun el criterio
			int i = 1,peso_acumulado=0;
            while (peso_acumulado<capacidad_maxima && i<=items)
            {
                if ((array[i].setpeso) +peso_acumulado < capacidad_maxima )
                {

                }
            }
		}

		public static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
		{
			int[,] K = new int[itemsCount + 1, capacity + 1];

			for (int i = 0; i <= itemsCount; ++i)
			{
				for (int w = 0; w <= capacity; ++w)
				{
					if (i == 0 || w == 0)
						K[i, w] = 0;
					else if (weight[i - 1] <= w)
						K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
					else
						K[i, w] = K[i - 1, w];
				}
			}

			return K[itemsCount, capacity];
		}
	}
}
