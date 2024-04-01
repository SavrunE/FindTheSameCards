using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	[HideInInspector] public int id;
	[HideInInspector] public bool canClick = true;

	[SerializeField] private Image _image;
	[SerializeField] private RectTransform _backRect;
	[SerializeField] private Button _button;

	public Vector2 backXY() => _backRect.sizeDelta;


	public void Clicked()
	{
		Debug.Log("Cliscked " + id);
	}

	public void UnClicked()
	{
		Debug.Log("UnCliscked " + id);
	}

	public void Delete()
	{
		Destroy(this.gameObject);
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(Click);
	}

	public void Click()
	{
		if (canClick)
		{
			canClick = false;
			CardSystem.instance.TakeCard(this);
		}
	}
	public void Init(int id, Sprite sprite)
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
