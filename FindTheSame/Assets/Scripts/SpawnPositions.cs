using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositions : MonoBehaviour
{
	[SerializeField] private RectTransform _backLeft;
	[SerializeField] private Transform _backRight;

	public Vector3 TakeRndSpawnLeftPos(Vector2 templateSize)
	{
		float width = _backLeft.sizeDelta.x;
		float height = _backLeft.sizeDelta.y;

		float rndWidth = Random.Range(-width, width);
		float rndHeight = Random.Range(-height, height);

		float x = _backLeft.position.x + rndHeight - templateSize.x;
		float y = _backLeft.position.y + rndHeight - templateSize.y;

		return

	}
}
