using UnityEngine;
using UnityEngine.UI;

public class Blocks : Singleton<Blocks>
{
	[SerializeField] private Image _left;
	[SerializeField] private Image _right;

	public void ChangeView(bool isLeft, Sprite sprite)
	{
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

	public void Reset()
	{
		_left.sprite = null;
		_right.sprite = null;
	}
}
