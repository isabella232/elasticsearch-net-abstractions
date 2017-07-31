using System;

namespace Elastic.ProcessManagement
{
	public class StartupException : Exception
	{
		public StartupException(string message) : base(message) { }

		public StartupException(string message, string helpText) : base(message)
		{
			this.HelpText = helpText;
		}

		public string HelpText { get; private set; }
	}
}