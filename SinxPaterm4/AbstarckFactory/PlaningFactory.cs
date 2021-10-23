using System;
using System.Collections.Generic;
using System.Text;
using SinxPaterm4.AbstarckFactory.Employe;

namespace SinxPaterm4.AbstarckFactory
{
    class PlaningFactory:AbstarctFactory
    {
        public override AbstarctIntern CreateIntern()
        {
            return new PlaningIntern();
        }

        public override AbstarctEmploy CreateEmploye()
        {
           return new PlaningEmploye();
        }

        public override AbstarctVice CreateVice()
        {
            return new PlaningVice();
        }

        public override AbstractBoss CreateBoss()
        {
            return new PlaningBoss();
        }
    }
}
