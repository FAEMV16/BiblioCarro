using System;
using System.Threading;

namespace BiblioCarro
{
    public abstract class Carro
    {
        #region Atributos
        private string marca;
        private int modelo;
        private float precio;
        private byte pasajeros;


        public string Marca
        { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public float Precio { get => precio; set => precio = value; }
        public byte Pasajeros { get => pasajeros; set => pasajeros = value; }
        #endregion

        #region Constructor
        public Carro()
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Pasajeros = Pasajeros;
        }
        #endregion

        #region Metodos
        public void Saludar()
        {
            Console.WriteLine("Bienvenido a la Agencia FI\n");
        }
        public void Marcas()
        {
            Console.WriteLine("Ingrese la marca del Carro a añadir:");
            Marca = Console.ReadLine();
        }
        public void Modelos()
        {
            Console.WriteLine("Ingrese el modelo del Carro a añadir:");
            Modelo = int.Parse(Console.ReadLine());
        }
       
        public void NumPasajeros()
        {
            Console.WriteLine("Ingrese el numero de pasajeros que admite el Carro:");
            Pasajeros = byte.Parse(Console.ReadLine());
        }
        public void Precios()
        {
            Console.WriteLine("Ingrese el precio del Carro a añadir:");
            Precio = float.Parse(Console.ReadLine());
        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine("\nCarro añadido con exito\nMarca: {0}\nModelo: {1}\nNúmero de Pasajeros: {2}\nPrecio: ${3}\n", Marca, Modelo, Pasajeros, Precio);
            Console.ReadLine();
        }

        public void LimpiarDisplay()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
        #endregion
    }
}
