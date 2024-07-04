using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AspNetTopics.Controllers
{
    [ApiController]
    [Route("[controller]/api/")]
    public class ConfigController : ControllerBase
    {
        private readonly IConfiguration _config;
        // private readonly IOptions<AttachmentOptions> _attachmentOptions; // this interface is injected using AddSingelton which is Create one instance in all requests
        private readonly IOptionsSnapshot<AttachmentOptions> _attachmentOptions; // this interfcae is injected using AddScoped which is Create new instance at every request.
        public ConfigController(IConfiguration config, IOptionsSnapshot<AttachmentOptions> attachmentOptions)
        {
            this._config = config;
            this._attachmentOptions = attachmentOptions;
            //var value = attachmentOptions.Value;
        }

        [HttpGet]
        [Route("ConfigInfo")]
        public ActionResult GetConfig()
        {
            Thread.Sleep(10000);
            var config = new
            {
                Allowhosts = _config["AllowedHosts"],
                ConnectionString = _config["ConnectionStrings:DefaultConnection"],
                DefaultLogLevel = _config["Logging:LogLevel:Default"],
                TestKey = _config["TestKey"],
                SigningKey = _config["SigningKey"],
                AttachmentOptions = _attachmentOptions.Value
            };

            return Ok(config);
        }
    }
}