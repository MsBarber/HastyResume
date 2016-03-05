using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastyResume.ViewModels.Resume
{
    public class EducationViewModel
    {
        public string Edu1_Title { get; set; }
        public string Edu1_SchoolName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Edu1_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu1_BodyText { get; set; }

        public string Edu2_Title { get; set; }
        public string Edu2_SchoolName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Edu2_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu2_BodyText { get; set; }

        public string Edu3_Title { get; set; }
        public string Edu3_SchoolName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Edu3_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu3_BodyText { get; set; }
    }
}
