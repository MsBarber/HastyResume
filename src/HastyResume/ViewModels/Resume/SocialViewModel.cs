using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastyResume.ViewModels.Resume
{
    public class SocialViewModel
    {
        public string GithubLink { get; set; }
        public string LinkedInLink { get; set; }
        public string FacebookLink { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

    }
}
