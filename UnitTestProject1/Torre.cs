using System;
using System.Collections.Generic;

public class Torre
{
	public List <int> TorreJugador; 
	public Torre() 
	{
		Random rd = new Random();
        int pisos = rd.Next(0,11);

		TorreJugador = new List<int>(pisos);

		for (int i = 0; i < pisos; i ++){

			jugador.Jugador = TorreJugador[i];
		}
	}

	//Sobrecarga
	public Torre(int niveles)
	{		
		int pisos;
		pisos = niveles;

		List<int> TorreJugador = new List<int>(pisos);

		for (int i = 0; i < pisos; i++)
		{
			jugador.Jugador = TorreJugador[i];
		}

	}
}
