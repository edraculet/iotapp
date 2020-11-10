using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace iotapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        /**
         * Lock device action
         */
        [HttpGet("lock")]
        public string Lock(string token)
        {
            return DeviceState(token, "lock");
        }

        /**
         * Unlock device action
         */
        [HttpGet("unlock")]
        public string Unlock(string token)
        {
            return DeviceState(token, "unlock");
        }

        /**
         * Check device state
         */
        [HttpGet("read")]
        public string CheckState(string token)
        {
            return DeviceState( token, "read");
        }

        /**
         * Get device by token and change state
         */
        private string DeviceState(string token, string state)
        {
            object response;
            DeviceToken dbToken = DeviceToken.GetToken(token);
            if (dbToken != null)
            {
                Device dbDevice = Device.GetDevice(dbToken);
                if (dbDevice != null)
                {
                    var chageState = true;

                    switch (state)
                    {
                        case "lock":
                            dbDevice.Locked = true;
                            break;
                        case "unlock":
                            dbDevice.Locked = false;
                            break;
                        default:
                            chageState = false;
                            break;
                    }
                    if (chageState)
                    {
                        dbDevice = Device.ChangeLock(dbDevice);
                    }

                    response = dbDevice;
                }
                else
                {
                    response = new ResponseError("Device not found!");
                }
            }
            else
            {
                response = new ResponseError("Token not found!");
            }

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            return JsonSerializer.Serialize(response, serializeOptions);
        }

    }
}

