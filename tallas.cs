using System;
public class tallas {
	public static void Main()
	{
		int talla1,talla2,talla3,talla4; 
		string tallas;
		
		Console.Write("Introduce tu talla de zapato : ");
		talla1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce tu talla de zapato : ");
		talla2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce tu talla de zapato : ");
		talla3 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce tu talla de zapato : ");
		talla4 = Convert.ToInt32(Console.ReadLine());
		
		tallas = talla1 > 40 && talla2 > 40 && talla3 > 40 && 
		talla4 > 40 ? "Todos calzan más de un 40" : talla1 < 40 &&
		talla2 < 40 && talla3 < 40 
		&& talla4 < 40? "Ninguno calza más de un 40" 
		: "Algunos sí otros no";
		
		Console.Write(tallas);
	}
}
