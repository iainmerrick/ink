using System.IO;
using System.Text;

namespace Ink
{
	public static class SimpleCompiler
	{
		public static Runtime.Story Compile(string path, ErrorHandler errorHandler)
		{
			var text = File.ReadAllText(path, Encoding.UTF8);
			var name = Path.GetFileName(path);

			string oldDir = Directory.GetCurrentDirectory();
			try
			{
				var dir = Path.GetDirectoryName(path);
				Directory.SetCurrentDirectory(dir);
				return Compile(text, name, errorHandler);
			}
			finally
			{
				Directory.SetCurrentDirectory(oldDir);
			}
		}

		public static Runtime.Story Compile(string text, string name, ErrorHandler errorHandler)
		{
			var parser = new InkParser(text, name, errorHandler);
			var result = parser.Parse();
			var story = result.ExportRuntime(errorHandler);
			return story;
		}
	}
}
