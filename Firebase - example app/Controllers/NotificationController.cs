using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Firebase___example_app.Controllers;

[Route("[controller]/[action]")]
public class NotificationController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Send()
    {
        var httpClient = new HttpClient();

        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer AAAASPIl8jQ:APA91bFkvEdxT_vjI3W3VYku4Q_xoUHuCZD-tPfNZUxYG5KFMhlJPh0iMbDPUWej4EdmtK_VsNyYBYMjU9EgI4v86bZGG6RJfm57g6AVQXf7-cp10_gT0xiaIcv3bofYvLk-zkDlwLNi");

        var notif = new
        {
            to = "fFlzr0GXSHiqdQZNT5mYSt:APA91bFapQKfv-22xXbMXNxWPuoct_pECrGLGdB5imKQmC5VVFkjj10H9S8AdFWG1Bioh6V0g5eIvSz7Nd6IqFpWY1ZGuP2ALKhAW-a43j6kVGd8w8rX21T9y2gmtz27vi5SoXGLg13X",
            content_available = true,
            priority = "high",
            notification = new
            {
                title = "salam",
                body = "sagol",
                sound = "default"
            }
        };

        var json = JsonSerializer.Serialize(notif);

        var data = new StringContent(json,Encoding.UTF8,"application/json");

        await httpClient.PostAsync(new Uri("https://fcm.googleapis.com/fcm/send"), data);

        return Ok();
    }

}
