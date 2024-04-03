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
				Blocks.instance.Reset(1f);
				Debug.Log("Take Points");
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
