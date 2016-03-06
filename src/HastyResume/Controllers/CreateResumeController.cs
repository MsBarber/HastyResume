using HastyResume.Models;
using HastyResume.ViewModels.Resume;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using System;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HastyResume.Controllers
{
    [Authorize]
    public class CreateResumeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public CreateResumeController(SignInManager<ApplicationUser> signin, UserManager<ApplicationUser> user)
        {
            _userManager = user;
            _signInManager = signin;
        }




        public async Task<IActionResult> Create()
        {
            var user = await GetCurrentUserAsync();
            if (user.ResumeCreated)
            {
                return RedirectToAction("Index", "Account");
            }
            return View(user);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdatePersonal(user,newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user = UpdateEducation(user,newinfo);
        //    user = UpdateSkills(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user = UpdateSocial(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user = UpdateWork(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user.ResumeCreated = true;
        //    await _userManager.UpdateAsync(user);
        //    return RedirectToAction("Index","Account");
        //}














        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            return View(user);
        }

        public IActionResult Personal()
        {
            return View("Personal");
        }

        [HttpPost]
        public async Task<IActionResult> Personal(PersonalViewModel pvm )
        {
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                user = UpdatePersonal(user, pvm);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Social");
            }
            return View(pvm);
        }


        public IActionResult Social()
        {
            return View("Social");
        }

        [HttpPost]
        public async Task<IActionResult> Social(SocialViewModel svm)
        {
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                user = UpdateSocial(user, svm);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Education");
            }
            return View(svm);
        }

        public IActionResult Education()
        {
            return View("Education");
        }

        [HttpPost]
        public async Task<IActionResult> Education(EducationViewModel evm)
        {
            var user = await GetCurrentUserAsync();
            
                user = UpdateEducation(user, evm);
               await _userManager.UpdateAsync(user);
                return RedirectToAction("Work");
            
            //return View(evm);
        }


        public IActionResult Work()
        {
            return View("Work");
        }

        [HttpPost]
        public async Task<IActionResult> Work(WorkViewModel wvm)
        {
            var user = await GetCurrentUserAsync();
                user = UpdateWork(user, wvm);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Skills");
            
        }

        public IActionResult Skills()
        {
            return View("Skills");
        }

        [HttpPost]
        public async Task<IActionResult> Skills(SkillsViewModel svm)
        {
            var user = await GetCurrentUserAsync();
            
                user = UpdateSkills(user, svm);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Account");

        }

        [HttpPost]
        public async Task<IActionResult> SecretLink(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user.SecretLink = GenSecretLink(user);
            await _userManager.UpdateAsync(user);
            return View("Index");
        }





        private ApplicationUser UpdatePersonal(ApplicationUser finaluser, PersonalViewModel pvm)
        {

            finaluser.FirstName = pvm.FirstName;
            finaluser.LastName = pvm.LastName;
            finaluser.ContactEmail = pvm.ContactEmail;
            finaluser.CareerField = pvm.CareerField;

            return finaluser;

        }

        private ApplicationUser UpdateSocial(ApplicationUser finaluser, SocialViewModel svm)
        {
            finaluser.GithubLink = svm.GithubLink;
            finaluser.FacebookLink = svm.FacebookLink;
            finaluser.LinkedInLink = svm.LinkedInLink;

            return finaluser;

        }

        private ApplicationUser UpdateEducation(ApplicationUser finaluser, EducationViewModel evm)
        { 

            finaluser.Edu1_Title = evm.Edu1_Title;
            finaluser.Edu1_SchoolName = evm.Edu1_SchoolName;
            finaluser.Edu1_CompletionDate = evm.Edu1_CompletionDate;
            finaluser.Edu1_BodyText = evm.Edu1_BodyText;

            finaluser.Edu2_Title = evm.Edu2_Title;
            finaluser.Edu2_SchoolName = evm.Edu2_SchoolName;
            finaluser.Edu2_CompletionDate = evm.Edu2_CompletionDate;
            finaluser.Edu2_BodyText = evm.Edu2_BodyText;

            finaluser.Edu3_Title = evm.Edu3_Title;
            finaluser.Edu3_SchoolName = evm.Edu3_SchoolName;
            finaluser.Edu3_CompletionDate = evm.Edu3_CompletionDate;
            finaluser.Edu3_BodyText = evm.Edu3_BodyText;

            return finaluser;

        }

        private ApplicationUser UpdateWork(ApplicationUser finaluser, WorkViewModel wvm)
        {

            finaluser.Wrk1_CompanyName = wvm.Wrk1_CompanyName;
            finaluser.Wrk1_CompanyPosition = wvm.Wrk1_CompanyPosition;
            finaluser.Wrk1_StartDate = wvm.Wrk1_StartDate;
            finaluser.Wrk1_EndDate = wvm.Wrk1_EndDate;
            finaluser.Wrk1_BodyText = wvm.Wrk1_BodyText;

            finaluser.Wrk2_CompanyName = wvm.Wrk2_CompanyName;
            finaluser.Wrk2_CompanyPosition = wvm.Wrk2_CompanyPosition;
            finaluser.Wrk2_StartDate = wvm.Wrk2_StartDate;
            finaluser.Wrk2_EndDate = wvm.Wrk2_EndDate;
            finaluser.Wrk2_BodyText = wvm.Wrk2_BodyText;

            finaluser.Wrk3_CompanyName = wvm.Wrk3_CompanyName;
            finaluser.Wrk3_CompanyPosition = wvm.Wrk3_CompanyPosition;
            finaluser.Wrk3_StartDate = wvm.Wrk3_StartDate;
            finaluser.Wrk3_EndDate = wvm.Wrk3_EndDate;
            finaluser.Wrk3_BodyText = wvm.Wrk3_BodyText;

            return finaluser;


        }

        private ApplicationUser UpdateSkills(ApplicationUser finaluser, SkillsViewModel svm)
        {

            finaluser.Skill1_ParentSkill = svm.Skill1_ParentSkill;
            finaluser.Skill1_ChildSkill1Name = svm.Skill1_ChildSkill1Name;
            finaluser.Skill1_ChildSkill1Percent = svm.Skill1_ChildSkill1Percent;
            finaluser.Skill1_ChildSkill2Name = svm.Skill1_ChildSkill2Name;
            finaluser.Skill1_ChildSkill2Percent = svm.Skill1_ChildSkill2Percent;
            finaluser.Skill1_ChildSkill3Name = svm.Skill1_ChildSkill3Name;
            finaluser.Skill1_ChildSkill3Percent = svm.Skill1_ChildSkill3Percent;

            finaluser.Skill2_ParentSkill = svm.Skill2_ParentSkill;
            finaluser.Skill2_ChildSkill1Name = svm.Skill2_ChildSkill1Name;
            finaluser.Skill2_ChildSkill1Percent = svm.Skill2_ChildSkill1Percent;
            finaluser.Skill2_ChildSkill2Name = svm.Skill2_ChildSkill2Name;
            finaluser.Skill2_ChildSkill2Percent = svm.Skill2_ChildSkill2Percent;
            finaluser.Skill2_ChildSkill3Name = svm.Skill2_ChildSkill3Name;
            finaluser.Skill2_ChildSkill3Percent = svm.Skill2_ChildSkill3Percent;

            finaluser.Skill3_ParentSkill = svm.Skill3_ParentSkill;
            finaluser.Skill3_ChildSkill1Name = svm.Skill3_ChildSkill1Name;
            finaluser.Skill3_ChildSkill1Percent = svm.Skill3_ChildSkill1Percent;
            finaluser.Skill3_ChildSkill2Name = svm.Skill3_ChildSkill2Name;
            finaluser.Skill3_ChildSkill2Percent = svm.Skill3_ChildSkill2Percent;
            finaluser.Skill3_ChildSkill3Name = svm.Skill3_ChildSkill3Name;
            finaluser.Skill3_ChildSkill3Percent = svm.Skill3_ChildSkill3Percent;

            return finaluser;

        }


        private string GenSecretLink(ApplicationUser user)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(user.FirstName);
            byte[] src = Convert.FromBase64String(user.LastName);
            byte[] dst = new byte[src.Length + bytes.Length];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray).Replace('/', 'x');
        }


        private async Task<ApplicationUser> GetCurrentUserAsync()
         {
            return await _userManager.FindByIdAsync(HttpContext.User.GetUserId());
         }
    }
}
