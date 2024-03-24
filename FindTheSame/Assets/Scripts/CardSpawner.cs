using UnityEngine;

public class CardSpawner : MonoBehaviour
{
	[SerializeField] private Card _cardTemplate;
	[SerializeField] private int _count;
	[SerializeField] private SpriteHolder _spriteHolder;

	private void Start()
	{
		for (int i = 0; i < _count; i++)
		{
			Card card1 = Instantiate(_cardTemplate, this.transform);
			Card card2 = Instantiate(_cardTemplate, this.transform);
			int rnd = _spriteHolder.GetRndSpriteID();
			_spriteHolder.GetSprite(rnd);
		}
	}
}