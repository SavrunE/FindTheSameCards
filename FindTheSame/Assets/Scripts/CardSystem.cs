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
				card.Delete();
				_lastCard.Delete();
				_lastCard = null;
				Blocks.instance.Reset();
				Debug.Log("Take Points");
			}
			else
			{
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
