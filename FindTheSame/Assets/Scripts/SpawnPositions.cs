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
		float width = rect.sizeDelta.x;
		float height = rect.sizeDelta.y;

		float rndWidth = Random.Range(-width, width);
		float rndHeight = Random.Range(-height, height);

		float x = rect.position.x + rndWidth - templateSize.x;
		float y = rect.position.y + rndHeight - templateSize.y;

		return new Vector3(x, y, 0f);
	}
}
