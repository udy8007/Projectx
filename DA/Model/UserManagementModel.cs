using DA.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA.Model
{
    public class UserDBModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonConverter(typeof(DateConverter))]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
    }
}
