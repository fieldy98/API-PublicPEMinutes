using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APi_PublicPeMinutes.Dtos;
using APi_PublicPeMinutes.EF;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using System.Web.Http.Cors;

namespace APi_PublicPeMinutes.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        PEMinutesEntities db = new PEMinutesEntities();
        
        // GET api/values
        public IEnumerable<MinutesDto> Get()
        {

            return db.SchoolNames.ToList().Select(Mapper.Map<SchoolName, MinutesDto>);
        }

        // GET api/values/5
        public IEnumerable<Teachers> Get(string school)
        {
            var NotTheseTeachers = db.SchoolTeachersWithADLogins.Where(x => x.COURSE_TITLE.Contains("PS") || x.COURSE_TITLE.Contains("Kindergarten"));
            return db.SchoolTeachersWithADLogins.Where(x=>x.Organization_Name == school).Except(NotTheseTeachers).DistinctBy(x=>x.BADGE_NUM).OrderBy(x=>x.TeacherLastName).ToList().Select(x => new Teachers()
            {
                TeacherName = x.TeacherLastName + ", " + x.TeacherFirstName,
                BadgeNumber = x.BADGE_NUM

            });
        }

        public IEnumerable<Minute> Get(int BadgeNumber)
        {
            var SixtyDaysAgo = DateTime.Now.AddDays(-60);

            return db.EnteredPeMinutes.Where(x => x.BadgeNumber == BadgeNumber && x.Timestamp >= SixtyDaysAgo).OrderByDescending(x => x.Timestamp).ToList().Select(x => new Minute()
            {
                Minutes = x.Minutes,
                InstructionTime = x.InstructionTime.Value.ToShortDateString()
                
            });
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
