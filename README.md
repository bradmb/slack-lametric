# Slack to LaMetric Time Proxy
This application is a proxy between Slack and the LaMetric Time. It allows you to send messages from a Slack channel and have it display on a LaMetric Time device.

#### Requirements:
* A Slack account (https://slack.com)
* A LaMetric Time (https://lametric.com/)
* A LaMetric Developer Account (https://developer.lametric.com)
* Visual Studio 2015 (https://www.visualstudio.com)

#### Slack Configuration
Assuming you're familiar with Slack, setup is fairly straightforward. Essentially all you have to do is create a new **Slash Command** integration, configure it how you'd like, and tell it to send a POST to the URL where you have this application deployed (See *Local Testing Tips* for localhost configuration).

#### LaMetric Configuration
This part is a little bit more involved. As the LaMetric API does not currently allow each installation to have it's own unique id, you basically need a unique LaMetric application for each of your LaMetric Time devices. So, to get this side setup, create a new application and:
* Set the Application Type to **PUSH**
* Give your app a cool looking Slack icon (available in the icon selection)
* Setup the default text to be something simple, such as "READY"
* Save and publish the new application
* Go to your phone and install the application from the LaMetric store onto your device

#### Application Configuration
There's not much you have to do here. In the `Web.config` file in the **Web Application** project, there will be two application settings for `lametric:url` and `lametric:token`. Simply take the *Push URL* and *Access Token* from the LaMetric application you created earlier and put them in here. After that, the application is configured and ready to go!

#### Local Testing Tips
When running this application within a local testing environment using Visual Studio and IIS Express, you'll need to give Slack the ability to send messages to the application, which might be hard if you're behind a firewall. Also, IIS Express doesn't like to talk to the outside world, so you'll need to **run Visual Studio as an Administrator** when testing this locally as well, as I configured this application to listen on all host names when running locally.

To provide Slack access to your local IIS Express instance, I recommend ngrok (https://ngrok.com/), which makes the process extremely simple. All you have to do is download the application and run `ngrok http 51980`.
