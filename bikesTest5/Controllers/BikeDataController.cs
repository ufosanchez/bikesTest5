using bikesTest5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace bikesTest5.Controllers
{
    public class BikeDataController : ApiController
    {
        //utilizing the database connection
        private ApplicationDbContext db = new ApplicationDbContext();

        //GET: api/BikeData/List
        //output a list of Airlines in the system
        [HttpGet]
        public string List()
        {
            DateTime NewarkDate = DateTime.Parse("2/6/2024 10:00:00 AM");
            DateTime New_DelhiDate = DateTime.Parse("2/6/2024 12:18:00 PM");

            string time_zone1 = "Eastern Standard Time";
            string time_zone2 = "Mountain Standard Time";

            //TimeZoneInfo NewarkZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            //TimeZoneInfo New_DelhiZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

            //DateTime date1 = TimeZoneInfo.ConvertTime(DateTime.Now, Newark);
            //DateTime date2 = TimeZoneInfo.ConvertTime(DateTime.Now, New_Delhi);

            //DateTime NewarkDate_Parse = TimeZoneInfo.ConvertTime(NewarkDate, NewarkZone);
            //DateTime New_DelhiDate_Parse = TimeZoneInfo.ConvertTime(New_DelhiDate, New_DelhiZone);

            ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();

            foreach (TimeZoneInfo timeZone in timeZones)
            {
                Debug.WriteLine(timeZone.Id);

            }

            return "a";



        }
    }
}
