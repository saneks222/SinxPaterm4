using System;
using System.Collections.Generic;
using System.Text;
using SinxPaterm4.AbstarckFactory.Employe;
namespace SinxPaterm4.AbstarckFactory
{
    class InternacionalFactory:AbstarctFactory
    {
        public override AbstarctIntern CreateIntern()
        {
            return new InternacionalIntern();
        }

        public override AbstarctEmploy CreateEmploye()
        {
            return new InternacionalEmploye();
        }

        public override AbstarctVice CreateVice()
        {
            return new InternacionalVice();
        }

        public override AbstractBoss CreateBoss()
        {
            return new InternacionalBoss();
        }
    }
}
