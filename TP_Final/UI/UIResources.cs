using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TP_Final.Properties;

namespace TP_Final.UI
{
    public static class UIResources
    {
        private static readonly System.Drawing.Bitmap[] iImagesToRight =  { Properties.Resources.viejo1D, Properties.Resources.viejo2D, Properties.Resources.viejo3D, Properties.Resources.viejo4D, Properties.Resources.viejo5D, Properties.Resources.viejo6D, Properties.Resources.viejo7D, Properties.Resources.viejo8D};
        private static readonly System.Drawing.Bitmap[] iImagesToLeft = { Properties.Resources.viejo1I, Properties.Resources.viejo2I, Properties.Resources.viejo3I, Properties.Resources.viejo4I, Properties.Resources.viejo5I, Properties.Resources.viejo6I, Properties.Resources.viejo7I, Properties.Resources.viejo8I};
        private static readonly string[] iPrhases =
        {
         "No todo lo que es de oro reluce, ni toda la gente errante anda perdida. «J.R.R. Tolkien»",
         "Sólo un hombre que ha sentido la máxima desesperación es capaz de sentir la máxima felicidad. Es necesario haber deseado morir para saber lo bueno que es vivir. «Alejandro Dumas»",
         "Creo que sí, estás loco. Pero te diré un secreto: las mejores personas lo están.  – «Lewis Carroll»",
         "ladran, Sancho, señal que cabalgamos.  «Miguel de Cervantes»",
         "Mientras el corazón lata, mientras la carne palpite, no me explico que un ser dotado de voluntad se deje dominar por la desesperación.  «Julio Verne»",
         "Nada cambiaría mientras el poder siguiera en manos de una minoría privilegiada. «George Orwell»",
         "Si no esperas nada de nadie, nunca estarás decepcionado. «Sylvia Plath»",
         "Es justamente la posibilidad de realizar un sueño lo que hace que la vida sea interesante. «Paulo Coelho»",
         "Son nuestras elecciones las que muestran lo que somos, mucho más que nuestras habilidades. «J.K. Rowling»",
         "Es una locura odiar a todas las rosas porque una te pinchó. Renunciar a todos tus sueños porque uno de ellos no se realizó.«Antoine de Saint-Exupéry»",
         "El sol es débil cuando se eleva primero, y cobra fuerza y coraje a medida que avanza el día. «Charles Dickens»",
         "Luchar hasta el último aliento. «William Shakespeare»",
         "¡Qué maravilloso es que nadie necesite esperar ni un solo momento antes de comenzar a mejorar el mundo!. «Ana Frank»",
         "Nuestras vidas se definen por las oportunidades, incluso las que perdemos.  «Scott Fitzgerald»",
         "El mundo era tan reciente, que muchas cosas carecían de nombre, y para mencionarlas había que señalarlas con el dedo. «Gabriel García Márquez»",
         "Hay que tener cuidado con los libros y lo que hay dentro de ellos, ya que las palabras tienen el poder de cambiarnos. «Cassandra Clare»"
        };
        public enum AmancioOrientarion { ToLeft, ToRight }
        public static System.Drawing.Bitmap GetAmancio(AmancioOrientarion pOrientation) 
        {
            Random rnd = new Random();
            int result = rnd.Next(0,8);
            if (pOrientation == AmancioOrientarion.ToLeft)
            {
                return iImagesToLeft[result];
            }
            else
            {
                return iImagesToRight[result];  
            }            
        }

        public static string GetPhrase()
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 16);
            return iPrhases[result];    
        }
    }
}
