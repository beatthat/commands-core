Commands have an Execute method that may contain arbitrarily complex behaviour. Commands are generally wired to execute in response to a Notification (see beatthat/notifications)

#USAGE

TODO: explain how to register commands using attributes (in Services setup)

```c#
[RegisterCommand]
public class LoadTopicCmd : NotificationCommandBase<string>
{
    /// this Command base class executes when a particular notification-type is sent
	public override string notificationType
    {
        get { return TopicNotifications.LOAD_REQUESTED; }
    }

	public override void Execute (string id)
	{
        // maybe load this topic async then send notifications
    }
}
```
