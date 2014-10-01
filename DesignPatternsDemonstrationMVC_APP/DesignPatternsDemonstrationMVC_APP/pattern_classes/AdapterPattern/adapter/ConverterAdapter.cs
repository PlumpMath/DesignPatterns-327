using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.AdapterPattern.adaptee;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.AdapterPattern.adapter
{
    public class ConverterAdapter <T>
    {
        private ArrayCollAdaptee<T> _arrayCollection;
        private List<T> _ListCollection = new List<T>();

        public ConverterAdapter(ArrayCollAdaptee<T> arrayCollectionAdaptee)
        {
            _arrayCollection = arrayCollectionAdaptee;
        }

        public List<T> Convert() 
        {
            
            for (int i = 0; i < _arrayCollection.arrayCollection.Length; i++) 
            {
                _ListCollection.Add(_arrayCollection.arrayCollection[i]);
            }

            return _ListCollection;
        }
    }
}