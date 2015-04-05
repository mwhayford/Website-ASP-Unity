using HayfordTechnologies.Integration;
using HayfordTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using HayfordTechnologies.Integration.DTO;
namespace HayfordTechnologies.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        // GET: Application
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitApplication(ApplicationModel applicationModel)
        {
            var application = AutoMapper.Mapper.Map<Application>(applicationModel);
            _applicationService.SubmitApplication(application);
            return View();
        }
    }
}