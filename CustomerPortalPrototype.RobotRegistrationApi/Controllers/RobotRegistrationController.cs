using System.Collections.Generic;
using CustomerPortalPrototype.Domain.RobotRegistration;
using Microsoft.AspNetCore.Mvc;

namespace CustomerPortalPrototype.RobotRegistrationApi.Controllers
{
    [Route("api/robot-registration")]
    public class RobotRegistrationController : Controller
    {
        private readonly RobotRegistrationRepository _robotRegistrationRepository;

        public RobotRegistrationController(RobotRegistrationRepository robotRegistrationRepository)
        {
            _robotRegistrationRepository = robotRegistrationRepository;
        }

        public IActionResult Index()
        {
            return Json(_robotRegistrationRepository.All());
        }
    }
}