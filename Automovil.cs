using System;
using System.Threading;

namespace BiblioCarro
{
    public class Automovil : Carro
    {
        private string placas;
        public string Placas
        {
            get => placas;
            set
            {
                if (placas == null)
                {
                    placas = "Placas en Trámite";
                }
                else
                {
                    placas = value;
                }
            }
        }
        public void Placa()
        {
            Console.WriteLine("Ingrese las placas del Carro a añadir:");
            Placas = Console.ReadLine();
        }
        public override void MostrarDatos()
        {
            Console.WriteLine("\nCarro añadido con exito\nMarca: {0}\nModelo: {1}\nPlacas: {2}\nNúmero de Pasajeros: {3}\nPrecio: ${4}\n ", Marca, Modelo, Placas, Pasajeros, Precio);
            Console.ReadLine();
        }
        public Automovil()
        {
            Saludar();
            Marcas();
            LimpiarDisplay();
            Modelos();
            LimpiarDisplay();
            Placa();
            LimpiarDisplay();
            NumPasajeros();
            LimpiarDisplay();
            Precios();
            LimpiarDisplay();
            MostrarDatos();

        }

    }
}
