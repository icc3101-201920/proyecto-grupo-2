using System;
using System.Drawing;
using System.Linq;
using ExifLib;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

namespace PhotoMax
{
    class Program
    {


        static void Main(string[] args)
        {
            //Chopan
            string path = "C:/Users/Francisco/Desktop/proyecto-grupo-2/PhotoMax-master/PhotoMax-master/PhotoMax/Pintua.jpg";
            // BARRI string path = "/Users/joaquinbarrientos/Desktop/Universidad/6.Sexto Semestre/POO/PhotoMax/PhotoMax/Pintua.jpg";
            string newpath = "C:/Users/Francisco/Desktop/proyecto-grupo-2/PhotoMax-master/PhotoMax-master/PhotoMax/Nuevo.jpg";
            Filters filtros = new Filters();

            Bitmap imagenreal = new Bitmap(path);
            Bitmap imageneditada = new Bitmap(path);

            //filtros.Negative(imageneditada);
            //imageneditada.Save(newpath);
            Console.WriteLine("trabajen");

            Editor edit = new Editor();

            edit.TEXT(imageneditada);

            imageneditada.Save(newpath);
        }

    }
}