﻿using System.ComponentModel.DataAnnotations;

namespace project_.net.Models
{
        public class Client
        {
            [Key]
            public int Id { get; private set; }


            [Required(ErrorMessage = "Please enter you full name")]
            [Display(Name = "FullName")]
            public string Name { get; set; }

            [Required]
            [RegularExpression(@"/^[a-zA-Z0-9_.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$/gm", ErrorMessage = "E-mail id is not valid")]
            public string email { get; set; }

            [Required(ErrorMessage = "Please enter password")]
            [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
            [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters")]
            public string password { get; set; }
            [DataType(DataType.Password)]
            [Required(ErrorMessage = "Phone Number Required!")]
            [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Entered phone format is not valid.")]
            public string phoneNumber { get; set; }
            public Client(string name, string email, string password, string phoneNumber)
            {
                Name = name;
                this.email = email;
                this.password = password;
                this.phoneNumber = phoneNumber;
            }
        }
    }
