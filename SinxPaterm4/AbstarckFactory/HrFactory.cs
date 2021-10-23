using System;
using System.Collections.Generic;
using System.Text;
using SinxPaterm4.AbstarckFactory.Employe;

namespace SinxPaterm4.AbstarckFactory
{
    class HrFactory:AbstarctFactory
    {
        public override AbstarctIntern CreateIntern()
        {
            return new HrIntern();
        }

        public override AbstarctEmploy CreateEmploye()
        {
            return new HrEmploye();
        }

        public override AbstarctVice CreateVice()
        {
            return new HrVice();
        }

        public override AbstractBoss CreateBoss()
        {
            return new HrBoss();
        }
    }
}
