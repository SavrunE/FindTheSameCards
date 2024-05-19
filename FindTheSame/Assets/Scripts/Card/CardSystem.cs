using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardSystem : Singleton<CardSystem>
{
	private Card _lastCard = null;
	public Action IsTakeRightCards; 
	
	public static bool systemInitialized { get; private set; } = false;

	private void OnEnable()
	{
		systemInitialized = true;
	}

	public void TakeCard(Card card)
    {
		if (_lastCard != null)
		{
			if (_lastCard.id == card.id)
			{
				card.Delete();
				_lastCard.Delete();
				_lastCard = null;
				Blocks.instance.Reset(1f);
				IsTakeRightCards?.Invoke();
			}
			else
			{
				Blocks.instance.Reset(1f);
				_lastCard.UnClicked();
				card.UnClicked();
				_lastCard = null;
			}
		}
		else
		{
			_lastCard = card;
			//_lastCard.Clicked();
		}
	}
}
