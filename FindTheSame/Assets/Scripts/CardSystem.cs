using UnityEngine;

public class CardSystem : Singleton<CardSystem>
{
	private Card _lastCard = null;

    public void TakeCard(Card card)
    {
		if (_lastCard != null)
		{
			if (_lastCard.id == card.id)
			{
				Debug.Log("Delete them");
				card.Delete();
				_lastCard.Delete();
				_lastCard = null;
				Debug.Log("Take Points");
			}
			else
			{
				_lastCard.UnClicked();
				_lastCard = null;
			}
		}
		else
		{
			_lastCard = card;
			_lastCard.Clicked();
		}
	}
}
