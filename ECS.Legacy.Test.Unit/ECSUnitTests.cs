using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class ECSUnitTests
    {
        private ECS _uutEcs;
        private int threshold;
        private ITempSensor _tempsensor;
        private IHeater _heater;
        

        [SetUp]
        public void Setup()
        {
            _uutEcs = new ECS(threshold,_tempsensor,_heater);
        }

    }
}
