using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseMenu : MonoBehaviour
{
	[SerializeField] private EndsMemS _endsMemS;
	[SerializeField] private List<Image> _images;

	public void ShowLoseMenu()
	{
		this.gameObject.SetActive(true);
		PlaceLoseSprites();
	}

	public void ShowWinMenu()
	{
		this.gameObject.SetActive(true);
		PlaceWinSprites();
	}

	public void PlaceLoseSprites()
	{
		List<int> numbers = FindNumbers(_images.Count, _endsMemS.TakeLostLenth());

		for (int i = 0; i < numbers.Count; i++)
		{
			_images[i].sprite = _endsMemS.TakeLoseSprite(numbers[i]);
		}
	}

	public void PlaceWinSprites()
	{
		List<int> numbers = FindNumbers(_images.Count, _endsMemS.TakeWinLenth());

		for (int i = 0; i < numbers.Count; i++)
		{
			_images[i].sprite = _endsMemS.TakeWinSprite(numbers[i]);
		}
	}

	private List<int> FindNumbers(int returnCount, int generalCount)
	{
		if (returnCount >= generalCount)
		{
			throw new NotImplementedException();
		}
		List<int> numbers = new List<int>();
		List<int> result = new List<int>();

		for (int i = 0; i < generalCount; i++)
		{
			numbers.Add(i);
		}

		for (int x = 0; x < returnCount; x++)
		{
			int rnd = UnityEngine.Random.Range(0, generalCount);

			if (HaveSameNumbers(rnd, result))
			{
				x--;
			}
			else
			{
				result.Add(rnd);
			}
		}

		return result;
	}

	private bool HaveSameNumbers(int number, List<int> numbers)
	{
		foreach (var item in numbers)
		{
			if (number == item)
			{
				return true;
			}
		}
		return false;
	}
}
