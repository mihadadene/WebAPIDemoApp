﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represent ouen spcecifque person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// The user's  first name.
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// Couldn't you guess
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
    }
}