﻿using UnityEngine;

namespace ScriptableTween.Behaviours
{
	public class GameObjectTweenerBehaviour : BaseTweenerBehaviour<GameObject>
	{
		protected override GameObject Target
		{
			get
			{
				if (!target)
				{
					return gameObject;
				}

				return target;
			}
		}
	}
}