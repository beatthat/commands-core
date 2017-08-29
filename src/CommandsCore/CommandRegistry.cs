
namespace BeatThat.App
{
	public delegate Command<Notification> CommandFactory();

	public interface CommandRegistry 
	{
		
		void Add<T>(string type) where T : Command<Notification>;

		Binding Add(string type, CommandFactory factory);

		void UnregisterAllCommands();

		void UnregisterCommand(string type);

	}
}
