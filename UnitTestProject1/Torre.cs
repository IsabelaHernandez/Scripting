using System;
using System.Collections.Generic;

public class Torre
{
	
	Jugador jugador = new Jugador();

	List<int> TorreJugador; 
	public Torre()
	{
		Random rd = new Random();
        int pisos = rd.Next(0,11);

		TorreJugador = new List<int>(pisos);

		int posicion = rd.Next(0,pisos);

		TorreJugador[posicion] = jugador;
	}

	//Sobrecarga
	public Torre(int niveles)
	{
		
		int pisos;
		pisos = niveles;

		List<int> TorreJugador = new List<int>(pisos);

		int posicion = rd.Next(0,pisos);

		TorreJugador[posicion] = jugador;
	}
}
