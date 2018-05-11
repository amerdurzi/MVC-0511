using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVC_CodeAlong_110518_Amer.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage ="you have to have a First Name ")]
        [StringLength(15,MinimumLength =2,ErrorMessage ="A name must be betweeen 2 and 15 letters long ")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "you have to have a Last Name ")]
        [MinLength(2,ErrorMessage ="Thats too short for a last name ")]
        public string LastName { get; set; }

        [Range(10000 , 1000000 , ErrorMessage ="That Can not be legally be your salary ")]
        public int Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }


    }
}