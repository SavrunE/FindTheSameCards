using System;
using System.Collections;
using UnityEngine;
using YG;

public class CardSystem : Singleton<CardSystem>
{
	[SerializeField] private Timer _timer;
	[SerializeField] private WinLoseMenu _winLoseMenu;
	[SerializeField] private SaverData _saverData;
	private Card _lastCard = null;
	private int _cardCount;

	public Action IsTakeRightCards;

	private void OnEnable()
	{
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
		_winLoseMenu.ShowWinMenu();
		_saverData.SaveByWin();
		StartCoroutine(RestartLevel());
		Debug.Log("Win");
	}

	public void Lose()
	{
		_winLoseMenu.ShowLoseMenu();
		_saverData.SaveByLost();
		StartCoroutine(RestartLevel());
		Debug.Log("Lose");
	}

	private IEnumerator RestartLevel()
	{
		float wTime = 3f;
		while (wTime >= 0f)
		{
			wTime -= Time.deltaTime;
			yield return null;	
		}

		LoadScene ls = new LoadScene();
		ls.LoadDefaultScene();
	}
}
