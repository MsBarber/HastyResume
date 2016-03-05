using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastyResume.ViewModels.Resume
{
    public class PersonalViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        [Required]
        public string CareerField { get; set; }

    }
}
