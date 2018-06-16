namespace BeatThat.Commands
{
    public interface Command : Command<object> {}

	/// <summary>
	/// A <c>Command</c> encapsulates a single executable behaviour
	/// </summary>
	public interface Command<ArgType>
	{
		void Execute(ArgType n);
	}
}

