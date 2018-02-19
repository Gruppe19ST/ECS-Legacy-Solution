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
        private int _threshold;
        

        [SetUp]
        public void Setup()
        {
            _threshold = 20;
            _uutEcs = new ECS(_threshold, new StubTempSensor(), new StubHeater());
        }

        [Test]
        public void GetCurTemp_SetToReturn0_Returns0()
        {
            Assert.AreEqual(_uutEcs.GetCurTemp(),0);
        }

        [Test]
        public void GetThreshold_ThresholdSetTo20_Returns20()
        {
            _uutEcs.SetThreshold(20);
            Assert.AreEqual(_uutEcs.GetThreshold(), 20);
        }
        //[Test]
        //public void Regulate_TempOverThreshold_HeaterOff()
        //{
           
        //}

    }

    internal class StubTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 25;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

    internal class StubHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

}
