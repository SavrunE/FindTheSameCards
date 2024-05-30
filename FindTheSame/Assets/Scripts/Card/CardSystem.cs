using System;
using UnityEngine;

public class CardSystem : Singleton<CardSystem>
{
	[SerializeField] private Timer _timer;
	private Card _lastCard = null;
	private int _cardCount;

	public Action IsTakeRightCards;

	public static bool systemInitialized { get; private set; } = false;

	private void OnEnable()
	{
		systemInitialized = true;
		_timer.OnStopTime += Lose;
	}

	public void SetCardCount(int count)
	{
		_cardCount = count;
	}

	public void TakeCard(Card card)
	{
		if (_lastCard != null)
		{
			if (_lastCard.id == card.id)
			{
				TakeRightCard(card);
			}
			else
			{
				TakeWrongCard(card);
			}
		}
		else
		{
			TakeFirstCard(card);
		}
	}

	private void TakeRightCard(Card card)
	{
		card.Delete();
		_lastCard.Delete();
		_lastCard = null;
		Blocks.instance.Reset(1f);
		IsTakeRightCards?.Invoke();
		_cardCount--;
		if (_cardCount == 0)
		{
			Win();
		}
	}

	private void TakeWrongCard(Card card)
	{
		Blocks.instance.Reset(1f);
		_lastCard.UnClicked();
		card.UnClicked();
		_lastCard = null;
	}

	private void TakeFirstCard(Card card)
	{
		_lastCard = card;
	}

	public void Win()
	{
		Debug.Log("Win");
	}

	public void Lose()
	{
		Debug.Log("Lose");
	}
}
