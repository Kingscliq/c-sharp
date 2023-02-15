using System;
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

		public static string TrimText(string text = "This is a trimmed text of the hallowed empire states nan of awada land as u to through", int maxLength = 50)
		{
			if (text.Length < maxLength)
				return text;

			//var Trimmed = text.Substring(0, maxLength);
			//          return Trimmed + "...";

			//      }

			var newTextArr = text.Split(" ");
			int totalCharCount = 0;
			var summarizedText = new List<string>();

			foreach (string word in newTextArr)
			{
				summarizedText.Add(word);
				totalCharCount += word.Length + 1;

				if (totalCharCount < maxLength)
					break;

			}


			return String.Join(" ", summarizedText);
	
		}

	}
}

