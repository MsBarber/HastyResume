using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace HastyResume.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public bool ResumeCreated { get; set; }

        public string CareerField { get; set; }
        [Required(ErrorMessage = "Everyone has a first name!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Everyone has a first name!")]
        public string LastName { get; set; }
        public string GithubLink { get; set; }
        public string LinkedInLink { get; set; }
        public string FacebookLink { get; set; }

        [Required(ErrorMessage ="Please enter an email for employers to contact you.")]
        [EmailAddress]
        public string ContactEmail { get; set; }


        public string SecretLink { get; set; }
        
        public string Edu1_Title { get; set; }
        public string Edu1_SchoolName {get;set;}
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Edu1_CompletionDate { get; set; }
        [StringLength(maximumLength:256)]
        public string Edu1_BodyText { get; set; }

        public string Edu2_Title { get; set; }
        public string Edu2_SchoolName { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Edu2_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu2_BodyText { get; set; }

        public string Edu3_Title { get; set; }
        public string Edu3_SchoolName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Edu3_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu3_BodyText { get; set; }

        public string Wrk1_CompanyName { get; set; }
        public string Wrk1_CompanyPosition { get; set; }
        [DataType(DataType.Date,ErrorMessage ="Please use mm/dd/yyyy format")]
        public DateTime Wrk1_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Wrk1_EndDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Wrk1_BodyText { get; set; }

        public string Wrk2_CompanyName { get; set; }
        public string Wrk2_CompanyPosition { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Wrk2_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Wrk2_EndDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Wrk2_BodyText { get; set; }

        public string Wrk3_CompanyName { get; set; }
        public string Wrk3_CompanyPosition { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Wrk3_StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Wrk3_EndDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Wrk3_BodyText { get; set; }

        [DataType(DataType.Text)]
        public string Skill1_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkill1Name { get; set; }
        public int Skill1_ChildSkill1Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkill2Name { get; set; }
        public int Skill1_ChildSkill2Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkill3Name { get; set; }
        public int Skill1_ChildSkill3Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkill1Name { get; set; }
        public int Skill2_ChildSkill1Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkill2Name { get; set; }
        public int Skill2_ChildSkill2Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkill3Name { get; set; }
        public int Skill2_ChildSkill3Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkill1Name { get; set; }
        public int Skill3_ChildSkill1Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkill2Name { get; set; }
        public int Skill3_ChildSkill2Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkill3Name { get; set; }
        public int Skill3_ChildSkill3Percent { get; set; }



    }
}