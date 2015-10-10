using System.Web.Http;

namespace LaMetric_Slack_Integration.Controllers
{
    public class SlackController : ApiController
    {
#if DEBUG
        public string Get()
        {
            return "Hey there, have Slack send messages to the URL in your address bar!";
        }
#endif

        public void Post([FromBody]Core.Slack.Models.IncomingData model)
        {
            var lametric = new Core.LaMetric.Application();
            lametric.SendMessage(model.text);
        }
    }
}
