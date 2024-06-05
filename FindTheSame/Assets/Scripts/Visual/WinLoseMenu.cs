using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseMenu : MonoBehaviour
{
	[SerializeField] private EndsMemS _endsMemS;
	[SerializeField] private List<Image> _images;

	private void Start()
	{
		PlaceWinSprites();

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
		List<int> numbers = new List<int>();
		List<int> result = new List<int>();

		for (int i = 0; i < generalCount; i++)
		{
			numbers.Add(i);
		}

		for (int x = 0; x < returnCount; x++)
		{
			int rnd = Random.Range(0, generalCount);
			numbers.Remove(rnd);
			result.Add(rnd);
		}

		return result;
	}
}
