using UnityEngine;

public class SpawnPositions : MonoBehaviour
{
	[SerializeField] private RectTransform _backLeft;
	[SerializeField] private RectTransform _backRight;

	public Vector3 TakeLeftPos(Vector2 templateSize)
	{
		return TakeRndPos(templateSize, _backLeft);
	}

	public Vector3 TakeRightPos(Vector2 templateSize)
	{
		return TakeRndPos(templateSize, _backRight);
	}

	public Vector3 TakeRndPos(Vector2 templateSize, RectTransform rect)
	{
		float posX = rect.localPosition.x;
		float posY = rect.localPosition.y;

		float width = rect.sizeDelta.x - templateSize.x;
		float height = rect.sizeDelta.y - templateSize.y;

		float rndWidth = Random.Range(-width, width) / 2f;
		float rndHeight = Random.Range(-height, height) / 2f;

		//float x = posX + rndWidth - templateSize.x;
		//float y = posY + rndHeight - templateSize.y;

		float x = posX + rndWidth;
		float y = posY + rndHeight;

		return new Vector3(x, y, 0f);
	}
}
