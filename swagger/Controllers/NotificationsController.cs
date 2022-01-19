using eProtokollCore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace swagger.Controllers
{
    public class NotificationsController : ApiController
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        [Route(nameof(GetNotifications))]
        public async Task<IActionResult> GetNotifications()
        {
            if (Request != null)
            {
                var _auth = Request.Headers["Authorization"];
                auth_token = _auth.ToString().Substring(7, _auth.ToString().Length - 7);
            }
            return Ok(await _notificationService.GetUnReadNotifications(auth_token));
        }
    }
}
