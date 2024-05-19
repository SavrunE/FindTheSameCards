using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Blocks : Singleton<Blocks>
{
	[SerializeField] private Image _left;
	[SerializeField] private Image _right;

	private bool _isStartedCoroutine = false;

	public void ChangeView(bool isLeft, Sprite sprite)
	{
		if (_isStartedCoroutine)
		{
			HardReset();
		}

		if (isLeft)
		{
			if (_left.sprite == null)
			{
				_left.sprite = sprite;
			}
			else
			{
				_right.sprite = sprite;
			}
		}
		else
		{
			if (_right.sprite == null)
			{
				_right.sprite = sprite;
			}
			else
			{
				_left.sprite = sprite;
			}
		}
	}

	public void Reset(float time)
	{
		StartCoroutine(ResetForTime(time));
	}

	private void HardReset()
	{
		StopAllCoroutines();
		ResetSprites();
	}

	private IEnumerator ResetForTime(float time)
	{
		_isStartedCoroutine = true;
		float currentTime = 0f;
		while (currentTime < time)
		{
			currentTime += Time.deltaTime;
			yield return null;
		}

		ResetSprites();
	}

	private void ResetSprites()
	{
		_left.sprite = null;
		_right.sprite = null;
		_isStartedCoroutine = false;
	}
}
