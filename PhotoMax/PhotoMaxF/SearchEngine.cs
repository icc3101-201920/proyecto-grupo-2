using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PhotoMaxF
{
    public static class SearchEngine
    {
        public static IEnumerable<ImageFile> SearchByIso(int iso,string verificador,List<ImageFile> biblioteca)
        {   if(biblioteca.Count() == 0)
            {
                Console.WriteLine("There is no images on the library");
                return null;
            }
            else
            {   if(verificador == ">=")
                {
                    IEnumerable<ImageFile> Query = from image in biblioteca
                                                   where image.Iso >= iso
                                                   select image;
                    return Query;
                }
                else if (verificador == "<=")
                {
                    IEnumerable<ImageFile> Query = from image in biblioteca
                                                   where image.Iso <= iso
                                                   select image;
                    return Query;
                }

                else if (verificador == "=")
                {
                    IEnumerable<ImageFile> Query = from image in biblioteca
                                                   where image.Iso == iso
                                                   select image;
                    return Query;
                }

            }

            return null;

        }
    }
}
    