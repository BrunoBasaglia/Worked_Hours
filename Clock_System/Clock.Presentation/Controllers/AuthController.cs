using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Presentation.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Clock.Presentation.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPersonAppService _personAppService;

        private readonly IPersonEmployerAppService _personEmployerAppService;

        private readonly IEmployerAppService _employerAppService;
        private readonly IMapper _mapper;

        public AuthController(IMapper mapper, IPersonAppService personAppService, IPersonEmployerAppService personEmployerAppService,
            IEmployerAppService employerAppService, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _personAppService = personAppService;

            _personEmployerAppService = personEmployerAppService;


            _employerAppService = employerAppService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home", new { area = "dashboard" });

            return RedirectToAction("Login", "Auth");
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.Values.SelectMany(e => e.Errors);
                return View();
            }

            //return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            //PARAMS
            //false => IF IT IS PERSISTENT  (REMEMBER THE CREDENTIAL IN THE BROWSER)
            //true => LOCKOUTONFAILURE BLOCK THE LOGIN IN CASE OF MANY TRIES
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Login, loginViewModel.Password, false, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View();
            }

            return RedirectToAction("Index", "Home", new { area = "dashboard" });
        }


        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }


        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegisterViewModel registerViewModel)
        {
            IdentityResult result;

            if (!ModelState.IsValid)
            {
                ModelState.Values.SelectMany(e => e.Errors);
                return View();
            }

            //OBJ USER
            var user = new IdentityUser
            {
                UserName = registerViewModel.Email,
                Email = registerViewModel.Email,
                //EmailConfirmed = registerViewModel.EmailConfirmed,
                EmailConfirmed = true,
            };

            if (registerViewModel.UserType.Equals("Employer"))
            {
                if (registerViewModel.CompanyName == null)
                {
                    ModelState.AddModelError(string.Empty, "Company Name required.");
                    return View();
                }

                var employerViewModel = new EmployerViewModel
                {
                    CompanyName = registerViewModel.CompanyName,
                    Email = registerViewModel.Email,
                    ABN = 0,
                    Address = "Not Informed",
                    Telephone = 0,
                    CityFk = 9999,
                    Suburb = "Not Informed",
                    ZipCode = 0,
                    IsNew = true,
                    PayDay = DateTime.Now.DayOfWeek.ToString(),
                    PaymentFrequency = "Not Informed",
                    PayBy = "Not Informed"
                };

                result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    var role = new IdentityRole();
                    role.Name = "Employer";
                    var roleExist = await _roleManager.RoleExistsAsync(role.Name);
                    if (!roleExist)
                    {
                        await _roleManager.CreateAsync(role);
                    }
                    await _userManager.AddToRoleAsync(user, role.Name);
                }

                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Invalid register attempt.");
                    return View();
                }

                //MAP StudentProfileViewModel TO StudentProfile
                employerViewModel.IdEmployer = user.Id;
                var employer = _mapper.Map<EmployerViewModel, Employer>(employerViewModel);

                //TRY TO CREATE MY PROFILE
                try
                {
                    _employerAppService.Add(employer);
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home", new { area = "dashboard" });
                }
                catch (Exception e)
                {
                    await _userManager.DeleteAsync(user);
                    _employerAppService.Remove(employer);
                    ModelState.AddModelError(string.Empty, "Invalid register attempt.");
                    return View();
                }
            }
            else if (registerViewModel.UserType.Equals("Employee"))
            {
                if (registerViewModel.FirstName == null || registerViewModel.LastName == null)
                {
                    ModelState.AddModelError(string.Empty, "First Name and Last Name required.");
                    return View();
                }
                //OBJ PERSON
                var personViewModel = new PersonViewModel
                {
                    Name = registerViewModel.FirstName,
                    Surname = registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    Telephone = "Not Informed",
                    DOB = DateTime.Now,
                    ABN = 0,
                    Address = "Not Informed",
                    CityFk = 9999,
                    Suburb = "Not Informed",
                    ZipCode = 0,
                    IsNew = true
                };

                //TRY TO CREATE MY USER
                result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    var role = new IdentityRole();
                    role.Name = "Employee";
                    var roleExist = await _roleManager.RoleExistsAsync(role.Name);
                    if (!roleExist)
                    {
                        await _roleManager.CreateAsync(role);
                    }
                    await _userManager.AddToRoleAsync(user, role.Name);
                }

                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Invalid register attempt.");
                    return View();
                }

                //MAP StudentProfileViewModel TO StudentProfile
                personViewModel.IdPerson = user.Id;
                var person = _mapper.Map<PersonViewModel, Person>(personViewModel);

                //TRY TO CREATE MY PROFILE
                try
                {
                    _personAppService.Add(person);
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home", new { area = "dashboard" });
                }
                catch (Exception e)
                {
                    await _userManager.DeleteAsync(user);
                    _personAppService.Remove(person);
                    ModelState.AddModelError(string.Empty, "Invalid register attempt.");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Select a user type.");
                return View();
            }
        }

        [HttpGet("Invite")]
        public IActionResult Invite()
        {
            return View();
        }

        [HttpPost("Invite")]
        public async Task<ActionResult> Invite(RegisterViewModel registerViewModel)
        {
            IdentityResult result;

            //if (!ModelState.IsValid)
            //{
            //    ModelState.Values.SelectMany(e => e.Errors);
            //    return View();
            //}

            //OBJ USER
            var user = new IdentityUser
            {
                UserName = registerViewModel.Email,
                Email = registerViewModel.Email,
                //EmailConfirmed = registerViewModel.EmailConfirmed,
                EmailConfirmed = true,
            };

            if (registerViewModel.FirstName == null || registerViewModel.LastName == null || registerViewModel.Email == null)
            {
                ModelState.AddModelError(string.Empty, "All the fields are required.");
                return View();
            }

            //OBJ PERSON
            var personViewModel = new PersonViewModel
            {
                Name = registerViewModel.FirstName,
                Surname = registerViewModel.LastName,
                Email = registerViewModel.Email,
                Telephone = "Not Informed",
                DOB = DateTime.Now,
                ABN = 0,
                Address = "Not Informed",
                CityFk = 9999,
                Suburb = "Not Informed",
                ZipCode = 0,
                IsNew = true
            };

            //AUTO GENERATE PASSWORD
            registerViewModel.Password = AutoGeneratePassword();

            //TRY TO CREATE MY USER
            result = await _userManager.CreateAsync(user, registerViewModel.Password);
            if (result.Succeeded)
            {
                var role = new IdentityRole();
                role.Name = "Employee";
                var roleExist = await _roleManager.RoleExistsAsync(role.Name);
                if (!roleExist)
                {
                    await _roleManager.CreateAsync(role);
                }
                await _userManager.AddToRoleAsync(user, role.Name);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invitation could not be sent.");
                return View();
            }

            //MAP StudentProfileViewModel TO StudentProfile
            personViewModel.IdPerson = user.Id;
            var person = _mapper.Map<PersonViewModel, Person>(personViewModel);

            //TRY TO CREATE MY PROFILE
            try
            {
                _personAppService.Add(person);
                await _signInManager.SignInAsync(user, false);

                //Vinculate Person to Employer
                var personEmployer = new PersonEmployer
                {
                    IdEmployer = _employerAppService.EmployerByEmail(User.Identity.Name).IdEmployer,
                    IdPerson = person.IdPerson
                };

                _personEmployerAppService.Add(personEmployer);

                //SEND E-MAIL INVITATION
                SendInvitation(registerViewModel, User.Identity.Name);

                //REDIRECT TO THE RIGHT AREA
                return RedirectToAction("Index", "Employees", new { area = "Company" });
            }
            catch (Exception e)
            {
                await _userManager.DeleteAsync(user);
                _personAppService.Remove(person);
                ModelState.AddModelError(string.Empty, "Invalid register attempt.");
                return View();
            }

        }

        private string AutoGeneratePassword()
        {
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "1234567890";
            const string specials = "!@#$%&*?";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (res.Length < 8)
            {
                res.Append(letters[rnd.Next(letters.Length)]);
                res.Append(numbers[rnd.Next(numbers.Length)]);
                res.Append(specials[rnd.Next(specials.Length)]);
            }
            return res.ToString();
        }

        private void SendInvitation(RegisterViewModel newUser, string employerEmail)
        {
            SmtpClient smtp = new SmtpClient("mail.brunobasaglia.com");

            //smtp.EnableSsl = true; // GMail requer SSL
            smtp.Port = 25;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                                                              //smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            smtp.Credentials = new NetworkCredential("postmaster@brunobasaglia.com", "fagron@2019");

            // seu usuário e senha para autenticação
            //smtp.Credentials = new NetworkCredential("bbasaglia@gmail.com", "32566992");

            MailAddress de = new MailAddress(employerEmail);
            MailAddress para = new MailAddress(newUser.Email);
            MailMessage mensagem = new MailMessage(de, para);
            mensagem.IsBodyHtml = true;
            mensagem.Subject = "You have been invited to use !@#$%^&*";
            mensagem.Body = "Bruno Basaglia invited you to use !@#$%^&*. Log in using your e-mail and you password." + newUser.Password;
            try
            {
                smtp.Send(mensagem);
            }
            catch(Exception e)
            {
            }
        }
    }
}
