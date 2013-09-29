using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockMonitor.Utils;

namespace StockMonitorTest
{
    [TestClass]
    public class SoundUtilsTest
    {
        [TestMethod]
        public void PlaySoundTest()
        {
            SoundUtil.StartPlaySound("/sound/dog.wav");
        }
    }
}
