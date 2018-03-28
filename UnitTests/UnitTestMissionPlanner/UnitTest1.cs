using MissionPlanner.GCSViews;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;

namespace UnitTestMissionPlanner
{
    [TestFixture]
    public class UnitTest1
    {
        private Dictionary<string, object> coordenadasEvoa;

        [SetUp]
        public void SetUp()
        {
            coordenadasEvoa = new Dictionary<string, object>
            {
                { "HOMELATITUDE", "-23.418494" },
                { "HOMELONGITUDE" , "51.9269653" },
                { "HOMEALTITUDE", 120 }
            };
        }

        [Test]
        public void Deve_alterar_home_point()
        {
            var flightPlannerGeted = (FlightPlanner)Assembly.GetExecutingAssembly().CreateInstance("MissionPlanner.GCSViews.FlightPlanner");

            Assert.AreEqual(flightPlannerGeted.TXT_homealt.Text, "100"); 
        }
    }
}