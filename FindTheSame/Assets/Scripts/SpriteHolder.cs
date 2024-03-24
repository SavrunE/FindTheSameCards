using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHolder : MonoBehaviour
{
	[SerializeField] private Sprite[] _sprites;
	
	public int GetRndSpriteID()
	{
		return Random.Range(0, _sprites.Length);
	}

	public Sprite GetSprite(int id)
	{
		return _sprites[id];
	}
}
