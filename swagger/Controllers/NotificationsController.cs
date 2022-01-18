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
            return Ok(await _notificationService.GetUnReadNotifications());
        }
    }
}
