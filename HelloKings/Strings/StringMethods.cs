using System;
using System.Text;
namespace HelloKings.Strings
{
	public class StringMethods
	{
		public static void ManipulateString()
		{
			var fullName = "Ajaezo Kingsley ";
			
			var names = fullName.Split(' ');
            Console.WriteLine("Trimmed: '{0}'", fullName.Trim());
            Console.WriteLine("FirstName: {0}", names[0]);
            Console.WriteLine("LastName: {0}", names[1]);

			var newName = fullName.Replace("Kingsley", "Ezenwa");

            Console.WriteLine("New Name: {0}", newName);
        }

		public static string TrimText(string text, int maxLength)
		{
			if (text.Length < maxLength)
				return text;

			var newTextArr = text.Split(' ');
			int totalCharCount = 0;
			var summarizedText = new List<string>();

			foreach (string word in newTextArr)
			{
				summarizedText.Add(word);
				totalCharCount += word.Length + 1;

				if (totalCharCount > maxLength)
					break;

			}

			return String.Join(" ", summarizedText) + "...";
	
		}

		public static void BuildStrings()
		{
			var builder = new StringBuilder();
			builder.Append('-', 10);
			builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
           
            builder.Replace('-', '=');



            Console.WriteLine(builder);
		}

	}
}

