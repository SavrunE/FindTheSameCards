using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	[HideInInspector] public int id;
	private bool _canClick = true;

	[SerializeField] private Image _image;
	[SerializeField] private RectTransform _backRect;
	[SerializeField] private Button _button;

	private Color _baseColor;
	[SerializeField] private Color _clickedColor;

	private bool _isLeftBlock;

	public Vector2 backXY() => _backRect.sizeDelta;

	private void Awake()
	{
		_baseColor = _button.targetGraphic.color;
	}

	public void Clicked()
	{
		_canClick = false;
		Debug.Log("Clicked " + id);
		_button.targetGraphic.color = _clickedColor;
		Blocks.instance.ChangeView(_isLeftBlock, _image.sprite);
	}

	public void UnClicked()
	{
		Unblock();
		Debug.Log("UnClicked " + id);
		_button.targetGraphic.color = _baseColor;
	}

	public void Delete()
	{
		Destroy(this.gameObject);
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(Click);
	}

	private void Unblock()
	{
		_canClick = true;
	}

	public void Click()
	{
		if (_canClick)
		{
			Clicked();
			CardSystem.instance.TakeCard(this);
		}
	}

	public void Init(int id, Sprite sprite, bool isLeftBlock)
	{
		SetId(id);
		SetSprite(sprite);
		_isLeftBlock = isLeftBlock;
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
