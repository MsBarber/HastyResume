using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastyResume.ViewModels.Resume
{
    public class WorkViewModel
    {

        public string Wrk1_CompanyName { get; set; }
        public string Wrk1_CompanyPosition { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Wrk1_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Wrk1_EndDate { get; set; }
        //[Required(ErrorMessage = "Please talk about your experience with this company.")]
        [StringLength(maximumLength: 256)]
        public string Wrk1_BodyText { get; set; }

        public string Wrk2_CompanyName { get; set; }
        public string Wrk2_CompanyPosition { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Wrk2_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Wrk2_EndDate { get; set; }
       // [Required(ErrorMessage = "Please talk about your experience with this company.")]
        [StringLength(maximumLength: 256)]
        public string Wrk2_BodyText { get; set; }

        public string Wrk3_CompanyName { get; set; }
        public string Wrk3_CompanyPosition { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Wrk3_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Wrk3_EndDate { get; set; }
       // [Required(ErrorMessage = "Please talk about your experience with this company.")]
        [StringLength(maximumLength: 256)]
        public string Wrk3_BodyText { get; set; }
    }
}
