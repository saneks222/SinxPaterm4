using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPaterm4.AbstarckFactory
{
  abstract  class AbstarctFactory
    {
        public abstract AbstarctIntern CreateIntern();
        public abstract AbstarctEmploy CreateEmploye();
        public abstract AbstarctVice CreateVice();
        public abstract AbstractBoss CreateBoss();
    }
}
