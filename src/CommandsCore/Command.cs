

namespace BeatThat.App
{
	public interface Command : Command<object> {}

	public interface Command<ArgType>
	{
		void Execute(ArgType n);
	}
}
