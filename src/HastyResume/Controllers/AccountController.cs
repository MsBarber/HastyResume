using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using HastyResume.Models;
using HastyResume.Services;
using HastyResume.ViewModels.Account;
using System.Text;
using System.Security.Cryptography;

namespace HastyResume.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ISmsSender smsSender,
            ILoggerFactory loggerFactory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }

        //
        // GET: /Account/Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation(1, "User logged in.");
                    return RedirectToLocal(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToAction(nameof(SendCode), new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning(2, "User account locked out.");
                    return View("Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/Register
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, LastName = model.LastName };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
                    // Send an email with this link
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                    //await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
                    //    "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation(3, "User created a new account with password.");
                    return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation(4, "User logged out.");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        //
        // GET: /Account/ExternalLoginCallback
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null)
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
            if (result.Succeeded)
            {
                _logger.LogInformation(5, "User logged in with {Name} provider.", info.LoginProvider);
                return RedirectToLocal(returnUrl);
            }
            if (result.RequiresTwoFactor)
            {
                return RedirectToAction(nameof(SendCode), new { ReturnUrl = returnUrl });
            }
            if (result.IsLockedOut)
            {
                return View("Lockout");
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["LoginProvider"] = info.LoginProvider;
                var email = info.ExternalPrincipal.FindFirstValue(ClaimTypes.Email);
                return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = email });
            }
        }

        //
        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl = null)
        {
            if (User.IsSignedIn())
            {
                return RedirectToAction(nameof(ManageController.Index), "Manage");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation(6, "User created an account using {Name} provider.", info.LoginProvider);
                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewData["ReturnUrl"] = returnUrl;
            return View(model);
        }

        // GET: /Account/ConfirmEmail
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        //
        // GET: /Account/ForgotPassword
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return View("ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
                // Send an email with this link
                //var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                //var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: HttpContext.Request.Scheme);
                //await _emailSender.SendEmailAsync(model.Email, "Reset Password",
                //   "Please reset your password by clicking here: <a href=\"" + callbackUrl + "\">link</a>");
                //return View("ForgotPasswordConfirmation");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ForgotPasswordConfirmation
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        //
        // GET: /Account/ResetPassword
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            return code == null ? View("Error") : View();
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(AccountController.ResetPasswordConfirmation), "Account");
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(AccountController.ResetPasswordConfirmation), "Account");
            }
            AddErrors(result);
            return View();
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //
        // GET: /Account/SendCode
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl = null, bool rememberMe = false)
        {
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            var userFactors = await _userManager.GetValidTwoFactorProvidersAsync(user);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                return View("Error");
            }

            // Generate the token and send it
            var code = await _userManager.GenerateTwoFactorTokenAsync(user, model.SelectedProvider);
            if (string.IsNullOrWhiteSpace(code))
            {
                return View("Error");
            }

            var message = "Your security code is: " + code;
            if (model.SelectedProvider == "Email")
            {
                await _emailSender.SendEmailAsync(await _userManager.GetEmailAsync(user), "Security Code", message);
            }
            else if (model.SelectedProvider == "Phone")
            {
                await _smsSender.SendSmsAsync(await _userManager.GetPhoneNumberAsync(user), message);
            }

            return RedirectToAction(nameof(VerifyCode), new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        //
        // GET: /Account/VerifyCode
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> VerifyCode(string provider, bool rememberMe, string returnUrl = null)
        {
            // Require that the user has already logged in via username/password or external login
            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes.
            // If a user enters incorrect codes for a specified amount of time then the user account
            // will be locked out for a specified amount of time.
            var result = await _signInManager.TwoFactorSignInAsync(model.Provider, model.Code, model.RememberMe, model.RememberBrowser);
            if (result.Succeeded)
            {
                return RedirectToLocal(model.ReturnUrl);
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning(7, "User account locked out.");
                return View("Lockout");
            }
            else
            {
                ModelState.AddModelError("", "Invalid code.");
                return View(model);
            }
        }


        //****************************************************************************
        //****************************************************************************

        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            return View(user);
        }

        //[Route("/Edit/Delete")]
        //public async Task<IActionResult> Delete()
        //{
        //    var user = await GetCurrentUserAsync();

        //    return View(user);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Delete(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdatePersonal(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user = UpdateEducation(user, newinfo);
        //    user = UpdateSkills(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user = UpdateSocial(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user = UpdateWork(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    user.ResumeCreated = false;
        //    await _userManager.UpdateAsync(user);
        //    return RedirectToAction("Index");

        //}

        //[Route("/Edit/Personal")]
        //public IActionResult Personal()
        //{
        //    return View("Personal");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Personal(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdatePersonal(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    return View("Index");
        //}

        //[Route("/Edit/Social")]
        //public IActionResult Social()
        //{
        //    return View("Social");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Social(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdateSocial(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    return View("Index");
        //}

        //[Route("/Edit/Social")]
        //public IActionResult Education()
        //{
        //    return View("Education");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Education(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdateEducation(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    return View("Index");
        //}

        //[Route("/Edit/Work")]
        //public IActionResult Work()
        //{
        //    return View("Work");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Work(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdateWork(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    return View("Index");
        //}
        //[Route("/Edit/Skills")]
        //public IActionResult Skills()
        //{
        //    return View("Skills");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Skills(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user = UpdateSkills(user, newinfo);
        //    await _userManager.UpdateAsync(user);
        //    return View("Index");
        //}

        //[HttpPost]
        //public async Task<IActionResult> SecretLink(ApplicationUser newinfo)
        //{
        //    var user = await GetCurrentUserAsync();
        //    user.SecretLink = GenSecretLink(user);
        //    await _userManager.UpdateAsync(user);
        //    return View("Index");
        //}




        //****************************************************************************
        //****************************************************************************







        #region Helpers

        //private string GenSecretLink(ApplicationUser user)
        //{
        //    byte[] bytes = Encoding.Unicode.GetBytes(user.FirstName);
        //    byte[] src = Convert.FromBase64String(user.LastName);
        //    byte[] dst = new byte[src.Length + bytes.Length];
        //    Buffer.BlockCopy(src, 0, dst, 0,src.Length);
        //    Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
        //    HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
        //    byte[] inArray = algorithm.ComputeHash(dst);

        //    return Convert.ToBase64String(inArray).Replace('/','x');
        //}






        //private ApplicationUser UpdatePersonal(ApplicationUser finaluser, ApplicationUser newinfo)
        //{

        //    finaluser.FirstName = newinfo.FirstName;
        //    finaluser.LastName = newinfo.LastName;
        //    finaluser.ContactEmail = newinfo.ContactEmail;

        //    return finaluser;

        //}

        //private ApplicationUser UpdateSocial(ApplicationUser finaluser, ApplicationUser newinfo)
        //{
        //    finaluser.GithubLink = newinfo.GithubLink;
        //    finaluser.FacebookLink = newinfo.FacebookLink;
        //    finaluser.LinkedInLink = newinfo.LinkedInLink;

        //    return finaluser;

        //}

        //private ApplicationUser UpdateEducation(ApplicationUser finaluser, ApplicationUser newinfo)
        //{

        //    finaluser.Edu1_Title = newinfo.Edu1_Title;
        //    finaluser.Edu1_SchoolName = newinfo.Edu1_SchoolName;
        //    finaluser.Edu1_CompletionDate = newinfo.Edu1_CompletionDate;
        //    finaluser.Edu1_BodyText = newinfo.Edu1_BodyText;

        //    finaluser.Edu2_Title = newinfo.Edu2_Title;
        //    finaluser.Edu2_SchoolName = newinfo.Edu2_SchoolName;
        //    finaluser.Edu2_CompletionDate = newinfo.Edu2_CompletionDate;
        //    finaluser.Edu2_BodyText = newinfo.Edu2_BodyText;

        //    finaluser.Edu3_Title = newinfo.Edu3_Title;
        //    finaluser.Edu3_SchoolName = newinfo.Edu3_SchoolName;
        //    finaluser.Edu3_CompletionDate = newinfo.Edu3_CompletionDate;
        //    finaluser.Edu3_BodyText = newinfo.Edu3_BodyText;

        //    return finaluser;

        //}

        //private ApplicationUser UpdateWork(ApplicationUser finaluser, ApplicationUser newinfo)
        //{

        //    finaluser.Wrk1_CompanyName = newinfo.Wrk1_CompanyName;
        //    finaluser.Wrk1_CompanyPosition = newinfo.Wrk1_CompanyPosition;
        //    finaluser.Wrk1_StartDate = newinfo.Wrk1_StartDate;
        //    finaluser.Wrk1_EndDate = newinfo.Wrk1_EndDate;
        //    finaluser.Wrk1_BodyText = newinfo.Wrk1_BodyText;

        //    finaluser.Wrk2_CompanyName = newinfo.Wrk2_CompanyName;
        //    finaluser.Wrk2_CompanyPosition = newinfo.Wrk2_CompanyPosition;
        //    finaluser.Wrk2_StartDate = newinfo.Wrk2_StartDate;
        //    finaluser.Wrk2_EndDate = newinfo.Wrk2_EndDate;
        //    finaluser.Wrk2_BodyText = newinfo.Wrk2_BodyText;

        //    finaluser.Wrk3_CompanyName = newinfo.Wrk3_CompanyName;
        //    finaluser.Wrk3_CompanyPosition = newinfo.Wrk3_CompanyPosition;
        //    finaluser.Wrk3_StartDate = newinfo.Wrk3_StartDate;
        //    finaluser.Wrk3_EndDate = newinfo.Wrk3_EndDate;
        //    finaluser.Wrk3_BodyText = newinfo.Wrk3_BodyText;

        //    return finaluser;


        //}

        //private ApplicationUser UpdateSkills(ApplicationUser finaluser, ApplicationUser newinfo)
        //{

        //    finaluser.Skill1_ParentSkill = newinfo.Skill1_ParentSkill;
        //    finaluser.Skill1_ChildSkillOneName = newinfo.Skill1_ChildSkillOneName;
        //    finaluser.Skill1_ChildSkillOnePercent = newinfo.Skill1_ChildSkillOnePercent;
        //    finaluser.Skill1_ChildSkillTwoName = newinfo.Skill1_ChildSkillTwoName;
        //    finaluser.Skill1_ChildSkillTwoPercent = newinfo.Skill1_ChildSkillTwoPercent;
        //    finaluser.Skill1_ChildSkillThreeName = newinfo.Skill1_ChildSkillThreeName;
        //    finaluser.Skill1_ChildSkillThreePercent = newinfo.Skill1_ChildSkillThreePercent;

        //    finaluser.Skill2_ParentSkill = newinfo.Skill2_ParentSkill;
        //    finaluser.Skill2_ChildSkillOneName = newinfo.Skill2_ChildSkillOneName;
        //    finaluser.Skill2_ChildSkillOnePercent = newinfo.Skill2_ChildSkillOnePercent;
        //    finaluser.Skill2_ChildSkillTwoName = newinfo.Skill2_ChildSkillTwoName;
        //    finaluser.Skill2_ChildSkillTwoPercent = newinfo.Skill2_ChildSkillTwoPercent;
        //    finaluser.Skill2_ChildSkillThreeName = newinfo.Skill2_ChildSkillThreeName;
        //    finaluser.Skill2_ChildSkillThreePercent = newinfo.Skill2_ChildSkillThreePercent;

        //    finaluser.Skill3_ParentSkill = newinfo.Skill3_ParentSkill;
        //    finaluser.Skill3_ChildSkillOneName = newinfo.Skill3_ChildSkillOneName;
        //    finaluser.Skill3_ChildSkillOnePercent = newinfo.Skill3_ChildSkillOnePercent;
        //    finaluser.Skill3_ChildSkillTwoName = newinfo.Skill3_ChildSkillTwoName;
        //    finaluser.Skill3_ChildSkillTwoPercent = newinfo.Skill3_ChildSkillTwoPercent;
        //    finaluser.Skill3_ChildSkillThreeName = newinfo.Skill3_ChildSkillThreeName;
        //    finaluser.Skill3_ChildSkillThreePercent = newinfo.Skill3_ChildSkillThreePercent;

        //    return finaluser;

        //}



        private async Task<ApplicationUser> GetCurrentUserAsync()
        {
            return await _userManager.FindByIdAsync(HttpContext.User.GetUserId());
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }


        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}
