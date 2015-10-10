using System.Web.Http;

namespace LaMetric_Slack_Integration.Controllers
{
    public class SlackController : ApiController
    {
        public void Post([FromBody]Core.Slack.Models.IncomingData model)
        {
            var lametric = new Core.LaMetric.Application();
            lametric.SendMessage(model.text);
        }
    }
}
