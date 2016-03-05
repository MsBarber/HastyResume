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
        [Required(ErrorMessage = "Everyone has a first name!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Everyone has a first name!")]
        public string LastName { get; set; }
        public string GithubLink { get; set; }
        public string LinkedInLink { get; set; }
        public string FacebookLink { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }


        public string SecretLink { get; set; }
        
        public string Edu1_Title { get; set; }
        public string Edu1_SchoolName {get;set;}
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Edu1_CompletionDate { get; set; }
        [StringLength(maximumLength:256)]
        public string Edu1_BodyText { get; set; }

        public string Edu2_Title { get; set; }
        public string Edu2_SchoolName { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Edu2_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu2_BodyText { get; set; }

        public string Edu3_Title { get; set; }
        public string Edu3_SchoolName { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Edu3_CompletionDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Edu3_BodyText { get; set; }

        public string Wrk1_CompanyName { get; set; }
        public string Wrk1_CompanyPosition { get; set; }
        [DataType(DataType.Date,ErrorMessage ="Please use mm/dd/yyyy format")]
        public DateTime Wrk1_StartDate { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Wrk1_EndDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Wrk1_BodyText { get; set; }

        public string Wrk2_CompanyName { get; set; }
        public string Wrk2_CompanyPosition { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Wrk2_StartDate { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Wrk2_EndDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Wrk2_BodyText { get; set; }

        public string Wrk3_CompanyName { get; set; }
        public string Wrk3_CompanyPosition { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Wrk3_StartDate { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please use mm/dd/yyyy format")]
        public DateTime Wrk3_EndDate { get; set; }
        [StringLength(maximumLength: 256)]
        public string Wrk3_BodyText { get; set; }

        [DataType(DataType.Text)]
        public string Skill1_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkillOneName { get; set; }
        public int Skill1_ChildSkillOnePercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkillTwoName { get; set; }
        public int Skill1_ChildSkillTwoPercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkillThreeName { get; set; }
        public int Skill1_ChildSkillThreePercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkillOneName { get; set; }
        public int Skill2_ChildSkillOnePercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkillTwoName { get; set; }
        public int Skill2_ChildSkillTwoPercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkillThreeName { get; set; }
        public int Skill2_ChildSkillThreePercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkillOneName { get; set; }
        public int Skill3_ChildSkillOnePercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkillTwoName { get; set; }
        public int Skill3_ChildSkillTwoPercent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkillThreeName { get; set; }
        public int Skill3_ChildSkillThreePercent { get; set; }



    }
}