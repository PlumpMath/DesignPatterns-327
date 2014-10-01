using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AdapterPattern.adaptee
{
        public class ArrayCollAdaptee<T>
        {
            public T[] arrayCollection = new T[0];

            public ArrayCollAdaptee(T[] collection)
            {
                arrayCollection = collection;
            }


            public ArrayCollAdaptee()
            {
                
            }
            public void AddItemtoCollection(T item)
            {
                Array.Resize(ref this.arrayCollection, arrayCollection.Length + 1);

                arrayCollection[arrayCollection.Length - 1] = item;
                

                
            }

        }
}