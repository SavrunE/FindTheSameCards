using System;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
	[SerializeField] private Card _cardTemplate;
	[SerializeField] private int _count;
	[SerializeField] private SpriteHolder _spriteHolder;
	[SerializeField] private SpawnPositions _spawnPositions;

	internal void TakeCard()
	{
		throw new NotImplementedException();
	}

	private void Start()
	{
		Spawn();
	}

	private void Spawn()
	{
		for (int i = 0; i < _count; i++)
		{
			Card cardL = Instantiate(_cardTemplate, this.transform);
			Card cardR = Instantiate(_cardTemplate, this.transform);

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
