using HastyResume.Models;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user = UpdatePersonal(user,newinfo);
            await _userManager.UpdateAsync(user);
            user = UpdateEducation(user,newinfo);
            user = UpdateSkills(user, newinfo);
            await _userManager.UpdateAsync(user);
            user = UpdateSocial(user, newinfo);
            await _userManager.UpdateAsync(user);
            user = UpdateWork(user, newinfo);
            await _userManager.UpdateAsync(user);
            user.ResumeCreated = true;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index","Account");
        }














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
        public async Task<IActionResult> Personal(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user = UpdatePersonal(user, newinfo);
            await _userManager.UpdateAsync(user);
            return View("Social");
        }


        public IActionResult Social()
        {
            return View("Social");
        }

        [HttpPost]
        public async Task<IActionResult> Social(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user = UpdateSocial(user, newinfo);
            await _userManager.UpdateAsync(user);
            return View("Education");
        }

        public IActionResult Education()
        {
            return View("Education");
        }

        [HttpPost]
        public async Task<IActionResult> Education(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user = UpdateEducation(user, newinfo);
            await _userManager.UpdateAsync(user);
            return View("Work");
        }


        public IActionResult Work()
        {
            return View("Work");
        }

        [HttpPost]
        public async Task<IActionResult> Work(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user = UpdateWork(user, newinfo);
            await _userManager.UpdateAsync(user);
            return View("Skills");
        }

        public IActionResult Skills()
        {
            return View("Skills");
        }

        [HttpPost]
        public async Task<IActionResult> Skills(ApplicationUser newinfo)
        {
            var user = await GetCurrentUserAsync();
            user = UpdateSkills(user, newinfo);
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





        private ApplicationUser UpdatePersonal(ApplicationUser finaluser, ApplicationUser newinfo)
        {

            finaluser.FirstName = newinfo.FirstName;
            finaluser.LastName = newinfo.LastName;
            finaluser.ContactEmail = newinfo.ContactEmail;
            finaluser.CareerField = newinfo.CareerField;

            return finaluser;

        }

        private ApplicationUser UpdateSocial(ApplicationUser finaluser, ApplicationUser newinfo)
        {
            finaluser.GithubLink = newinfo.GithubLink;
            finaluser.FacebookLink = newinfo.FacebookLink;
            finaluser.LinkedInLink = newinfo.LinkedInLink;

            return finaluser;

        }

        private ApplicationUser UpdateEducation(ApplicationUser finaluser, ApplicationUser newinfo)
        { 

            finaluser.Edu1_Title = newinfo.Edu1_Title;
            finaluser.Edu1_SchoolName = newinfo.Edu1_SchoolName;
            finaluser.Edu1_CompletionDate = newinfo.Edu1_CompletionDate;
            finaluser.Edu1_BodyText = newinfo.Edu1_BodyText;

            finaluser.Edu2_Title = newinfo.Edu2_Title;
            finaluser.Edu2_SchoolName = newinfo.Edu2_SchoolName;
            finaluser.Edu2_CompletionDate = newinfo.Edu2_CompletionDate;
            finaluser.Edu2_BodyText = newinfo.Edu2_BodyText;

            finaluser.Edu3_Title = newinfo.Edu3_Title;
            finaluser.Edu3_SchoolName = newinfo.Edu3_SchoolName;
            finaluser.Edu3_CompletionDate = newinfo.Edu3_CompletionDate;
            finaluser.Edu3_BodyText = newinfo.Edu3_BodyText;

            return finaluser;

        }

        private ApplicationUser UpdateWork(ApplicationUser finaluser, ApplicationUser newinfo)
        {

            finaluser.Wrk1_CompanyName = newinfo.Wrk1_CompanyName;
            finaluser.Wrk1_CompanyPosition = newinfo.Wrk1_CompanyPosition;
            finaluser.Wrk1_StartDate = newinfo.Wrk1_StartDate;
            finaluser.Wrk1_EndDate = newinfo.Wrk1_EndDate;
            finaluser.Wrk1_BodyText = newinfo.Wrk1_BodyText;

            finaluser.Wrk2_CompanyName = newinfo.Wrk2_CompanyName;
            finaluser.Wrk2_CompanyPosition = newinfo.Wrk2_CompanyPosition;
            finaluser.Wrk2_StartDate = newinfo.Wrk2_StartDate;
            finaluser.Wrk2_EndDate = newinfo.Wrk2_EndDate;
            finaluser.Wrk2_BodyText = newinfo.Wrk2_BodyText;

            finaluser.Wrk3_CompanyName = newinfo.Wrk3_CompanyName;
            finaluser.Wrk3_CompanyPosition = newinfo.Wrk3_CompanyPosition;
            finaluser.Wrk3_StartDate = newinfo.Wrk3_StartDate;
            finaluser.Wrk3_EndDate = newinfo.Wrk3_EndDate;
            finaluser.Wrk3_BodyText = newinfo.Wrk3_BodyText;

            return finaluser;


        }

        private ApplicationUser UpdateSkills(ApplicationUser finaluser, ApplicationUser newinfo)
        {

            finaluser.Skill1_ParentSkill = newinfo.Skill1_ParentSkill;
            finaluser.Skill1_ChildSkill1Name = newinfo.Skill1_ChildSkill1Name;
            finaluser.Skill1_ChildSkill1Percent = newinfo.Skill1_ChildSkill1Percent;
            finaluser.Skill1_ChildSkill2Name = newinfo.Skill1_ChildSkill2Name;
            finaluser.Skill1_ChildSkill2Percent = newinfo.Skill1_ChildSkill2Percent;
            finaluser.Skill1_ChildSkill3Name = newinfo.Skill1_ChildSkill3Name;
            finaluser.Skill1_ChildSkill3Percent = newinfo.Skill1_ChildSkill3Percent;

            finaluser.Skill2_ParentSkill = newinfo.Skill2_ParentSkill;
            finaluser.Skill2_ChildSkill1Name = newinfo.Skill2_ChildSkill1Name;
            finaluser.Skill2_ChildSkill1Percent = newinfo.Skill2_ChildSkill1Percent;
            finaluser.Skill2_ChildSkill2Name = newinfo.Skill2_ChildSkill2Name;
            finaluser.Skill2_ChildSkill2Percent = newinfo.Skill2_ChildSkill2Percent;
            finaluser.Skill2_ChildSkill3Name = newinfo.Skill2_ChildSkill3Name;
            finaluser.Skill2_ChildSkill3Percent = newinfo.Skill2_ChildSkill3Percent;

            finaluser.Skill3_ParentSkill = newinfo.Skill3_ParentSkill;
            finaluser.Skill3_ChildSkill1Name = newinfo.Skill3_ChildSkill1Name;
            finaluser.Skill3_ChildSkill1Percent = newinfo.Skill3_ChildSkill1Percent;
            finaluser.Skill3_ChildSkill2Name = newinfo.Skill3_ChildSkill2Name;
            finaluser.Skill3_ChildSkill2Percent = newinfo.Skill3_ChildSkill2Percent;
            finaluser.Skill3_ChildSkill3Name = newinfo.Skill3_ChildSkill3Name;
            finaluser.Skill3_ChildSkill3Percent = newinfo.Skill3_ChildSkill3Percent;

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
