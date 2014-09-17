using UnityEngine;
using System;
using System.Collections;

namespace Fungus
{
	[CommandInfo("Camera", 
	             "Set Background", 
	             "Draws a fullscreen background texture using a Background UI object.")]
	public class SetBackground : Command 
	{
		public Background background;

		public Sprite backgroundImage;

		public override void OnEnter()
		{
			if (background != null)
			{
				background.SetBackgroundImage(backgroundImage);
			}

			Continue();
		}

		public override string GetSummary()
		{
			if (backgroundImage == null)
			{
				return "<None>";
			}

			return backgroundImage.name;
		}

		public override Color GetButtonColor()
		{
			return new Color32(216, 228, 170, 255);
		}
	}

}