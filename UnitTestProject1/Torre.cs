using System;

public class Torre
{
	public Torre()
	{
		Random rd = new Random();
 
        int pisos = rd.Next(0,11);

		List<int> TorreJugador = new List<int>(pisos);

		for (int i = 0; i < pisos; i ++){

			jugador.Jugador = TorreJugador[i];
		}

	}
}
