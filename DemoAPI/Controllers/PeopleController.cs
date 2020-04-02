using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// this is where I give you all the information about my peeps.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        /// <summary>
        /// Get all people
        /// </summary>
        public PeopleController()
        {
            people.Add(new Person { Id = 1, FirstName = "Tim", LastName = "Corey", EmailAddress = "Tim.Corey@gmail.com", Address = "tim address city" });
            people.Add(new Person { Id = 2, FirstName = "Sue", LastName = "Storm",  EmailAddress = "Sue.Storm@gmail.com", Address = "Sue address city" });
            people.Add(new Person { Id = 3, FirstName = "Bilbo", LastName = "Baggins",  EmailAddress = "Bilbo.Baggins@gmail.com", Address = "Bilbo address city" });
        }
        /// <summary>
        /// Get a list of the fisrt name of users
        /// </summary>
        /// <param name="userId">The unique idewntifier for this person</param>
        /// <param name="age">We want to know how old they are.</param>
        /// <returns>A list of first names...duh</returns>
        [Route("api/People/GetFirstNames/{userId:Int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        /// <summary>
        /// Get list of all people
        /// </summary>
        /// <returns></returns>
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }
        /// <summary>
        /// To get person by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }
        /// <summary>
        ///  To set person in the DB
        /// </summary>
        /// <param name="person"></param>
        // POST: api/People
        public void Post(Person person)
        {
            people.Add(person);
        }
        /// <summary>
        /// To delete a person by Id
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
