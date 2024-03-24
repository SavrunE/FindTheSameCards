using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	[HideInInspector] public int id;
	[SerializeField] private Image _image;
	[SerializeField] private RectTransform _backRect;

	public Vector2 backXY() => _backRect.sizeDelta;

	private void Init(int id, Sprite sprite)
	{
		SetId(id);
		SetSprite(sprite);
	}

	public void SetId(int id)
	{
		this.id = id;
	}

	public void SetSprite(Sprite sprite)
	{
		_image.sprite = sprite;
	}

	public int CheckId()
	{
		return id;
	}
}
