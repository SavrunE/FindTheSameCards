using UnityEngine;

public class CardSpawner : MonoBehaviour
{
	[SerializeField] private Card _cardTemplate;
	[SerializeField] private SpriteHolder _spriteHolder;
	[SerializeField] private SpawnPositions _spawnPositions;
	[SerializeField] private CardsView _cardsView;

	public void StartSpawn(int cardCount)
	{
		Spawn(cardCount);
		CardSystem.instance.SetCardCount(cardCount);
	}

	private void Spawn(int cardCount)
	{
		for (int i = 0; i < cardCount; i++)
		{
			Card cardL = Instantiate(_cardTemplate, _cardsView.transform);
			Card cardR = Instantiate(_cardTemplate, _cardsView.transform);

			int id = _spriteHolder.GetRndSpriteID();
			Sprite sprite = _spriteHolder.GetSprite(id);

			cardL.Init(id, sprite, true);
			cardR.Init(id, sprite, false);

			Vector3 posL = _spawnPositions.TakeLeftPos(cardL.backXY());
			Vector3 posR = _spawnPositions.TakeRightPos(cardR.backXY());

			cardL.GetComponent<RectTransform>().localPosition = posL;
			cardR.GetComponent<RectTransform>().localPosition = posR;
		}
	}
}
