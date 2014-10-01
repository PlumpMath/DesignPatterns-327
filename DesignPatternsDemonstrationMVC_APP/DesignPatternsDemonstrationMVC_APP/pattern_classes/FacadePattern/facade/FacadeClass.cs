using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatternsDemonstrationMVC_APP.pattern_classes.FacadePattern.classes;

namespace DesignPatternsDemonstrationMVC_APP.pattern_classes.FacadePattern.facade
{
    public class FacadeClass
    {
        private SystemClass1 _systemClass1;
        private SystemClass2 _systemClass2;
        private SystemClass3 _systemClass3;
        private SystemClass4 _systemClass4;

        public FacadeClass() 
        {
            _systemClass1 = new SystemClass1();
            _systemClass2 = new SystemClass2();
            _systemClass3 = new SystemClass3();
            _systemClass4 = new SystemClass4();
        }

        public void Tasks1() 
        {
            _systemClass1.Todo1();
            _systemClass2.Todo2();
            _systemClass4.Todo2();
        }

        public void Tasks2()
        {
            _systemClass3.Todo1();
            _systemClass4.Todo2();
        }

        public void Tasks3()
        {
            _systemClass1.Todo2();
            _systemClass3.Todo1();
        }

        public void Tasks4()
        {
            _systemClass4.Todo2();
            _systemClass4.Todo1();
        }
    }
}