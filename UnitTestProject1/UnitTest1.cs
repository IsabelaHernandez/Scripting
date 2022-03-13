using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Crear_Torre()
        {
            //Crear una torre con n niveles. Las torres siempre deben tener al menos un nivel
        }

        [TestMethod]
        public void Crear_Personaje()
        {
            //Crear un personaje con un valor inicial. Dicho valor siempre debe ser mayor a 0.
        }

        [TestMethod]
        public void Personaje_Asignado_Torre()
        {
            //El personaje del jugador est� asignado a un nivel de la torre del jugador.
        }

        [TestMethod]
        public void Enfretar_Personajes_Mayor_puntaje()
        {
            // ��� Jugador vs Enemigo: Gana el personaje con mayor puntaje. Si hay igualdad, el jugador siempre pierde.

        }

        [TestMethod]
        public void Enfrentar_Personajes_Obstaculo_Torre_Propia()
        {
            // ��� Jugador vs Obst�culo en torre propia: Siempre gana el jugador
        }

        [TestMethod]
        public void Enfrentar_Personajes_Personaje_Ganador()
        {
            //��� Al resolverse una pelea, el personaje ganador a�adir� a su valor el del personaje derrotado.
        }

        [TestMethod]
        public void Enfrentar_2Personajes_Torres()
        {
            // Al vencer, la torre del jugador debe incrementar un nivel, y la del enemigo decrementar en un nivel..
        }

        [TestMethod]
        public void Enfrentar_2Personajes_Vencer_Enemigo()
        {
            //El enemigo es el �ltimo personaje del �ltimo nivel de la torre. Al vencer al enemigo, el nivel del enemigo se a�ade a la torre del jugador y la torre enemiga desaparece
        }

        [TestMethod]
        public void Enfrentar_2Personajes_Enemigo()
        {
            // El enemigo debe tener un valor mayor al del jugador, y al ser derrotado, el jugador pierde una vida.
        }

        [TestMethod]
        public void Simular_Combate()
        {
            // Simular un combate. El jugador derrota 2 torres. Al vencer la �ltima, el juego debe indicar que el jugador complet� el nivel."
        }
    }
}