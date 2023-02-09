using System;
namespace HelloKings.Exercise
{
	public class Third
	{
		public static string checkOrientation(int height, int width)
		{
			if(height > width)
			{
				return "Portrait";
			}
			else if(height == width)
			{
				return "Perfect Square!";
			}
			else
			{
				return "Landscape";
			}

		}
	}
}

