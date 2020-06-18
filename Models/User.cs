
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    namespace WeddingPlanner.Models
    {
        public class User
        {
            [Key]
            public int UserId { get; set; }
            
            [Required (ErrorMessage = "First Name is required")]
            [MinLength(2)]
            [Display(Name = "First Name:")]
            public string FirstName { get; set; }

            [Required (ErrorMessage = "Last Name is required")]
            [MinLength(2)]
            [Display(Name = "Last Name:")]
            public string LastName { get; set; }

            [EmailAddress]
            [Required (ErrorMessage = "Email is required")]
            [Display(Name = "Email:")]
            public string Email { get; set; }

            [DataType(DataType.Password)]
            // [Required (ErrorMessage = "Password is required")]
            // [MinLength (ErrorMessage = "Password must be 8 characters long")]
            [Display(Name = "Password:")]
            [StrongPW]
            public string Password { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            [NotMapped]
            [Compare("Password")]
            [Display(Name = "Confirm Password:")]
            [DataType(DataType.Password)]
            public string Confirm {get;set;}

            public decimal Balance {get;set;} = 0;

            public List<Wedding> PlannedWeddings {get;set;}

            public List<Association> AttendingWeddings {get;set;}
        }
    }