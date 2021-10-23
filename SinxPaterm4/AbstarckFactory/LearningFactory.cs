using System;
using System.Collections.Generic;
using System.Text;
using SinxPaterm4.AbstarckFactory.Employe;

namespace SinxPaterm4.AbstarckFactory
{
    class LearningFactory:AbstarctFactory
    {
        public override AbstarctIntern CreateIntern()
        {
            return new LearnIntern();
        }

        public override AbstarctEmploy CreateEmploye()
        {
           return new LearnEmploye();
        }

        public override AbstarctVice CreateVice()
        {
            return new LearnVice();
        }

        public override AbstractBoss CreateBoss()
        {
            return new LearnBoss();
        }
    }
}
