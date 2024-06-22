using System.Collections.Generic;
using UnityEngine;

public class EndsMemS : MonoBehaviour
{
	[SerializeField] private Sprite[] _winSprites;
	[SerializeField] private Sprite[] _loseSprites;

	public Sprite TakeWinSprite(int index)
	{
		return _winSprites[index];
	}

	public Sprite TakeLoseSprite(int index)
	{
		return _loseSprites[index];
	}

	public int TakeWinLenth()
	{
		return _winSprites.Length;
	}

	public int TakeLostLenth()
	{
		return _loseSprites.Length;
	}

	public Sprite[] TakeRndSprites(int count)
	{
		Sprite[] s = new Sprite[count];
		List<Sprite> list = new List<Sprite>();
		foreach (var item in _winSprites)
		{
			list.Add(item);
		}
		foreach (var item in _loseSprites)
		{
			list.Add(item);
		}
		for (int i = 0; i < s.Length; i++)
		{
			s[i] = list[Random.Range(0, list.Count)];
		}
		return s;
	}
}
