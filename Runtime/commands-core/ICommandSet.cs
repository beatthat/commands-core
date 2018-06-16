using BeatThat.Notifications;

namespace BeatThat.Commands
{
    public interface ICommandSet 
	{

		/// <summary>
		/// Registers the scene commands. Called by Start, but can be force manually
		/// and is safe to call multiple times.
		/// </summary>
		void RegisterCommands();

		/// <summary>
		/// Unregisters the scene commands. Called by Destroy, but can be force manually
		/// and is safe to call multiple times.
		/// </summary>
		void UnregisterCommands();

		/// <summary>
		/// Create a command of the given type and adds it to the set of scene commands.
		/// If commands are already registered, registers the new command. 
		/// If not, the command will be registered on next call to RegisterSceneCommands.
		/// 
		/// By default, sets Command.destroyOnUnbind to true for the new command.
		/// If you don't want this behavoir, just change that property on the returned Command
		/// </summary>
		/// <returns>The self binding.</returns>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		T AddCommand<T>(bool disableAutoRegistration = false) where T : Command<Notification>, RegistersCommand;
	}
}

