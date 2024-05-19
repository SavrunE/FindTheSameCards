using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
	private int _currentPoints = 0;
	[SerializeField] private int _pintsAccrual;
	[SerializeField] private TextMeshProUGUI _pointsUI;

	private void OnEnable()
	{
		UpdatePointsView();
		if (CardSystem.instance != null)
		{
			CardSystem.instance.IsTakeRightCards += AddPoints;
		}
	}

	private void OnDisable()
	{
		if (CardSystem.instance != null)
		{
			CardSystem.instance.IsTakeRightCards -= AddPoints;
		}
	}

	private void AddPoints()
	{
		_currentPoints += _pintsAccrual;
		UpdatePointsView();
	}

	private void UpdatePointsView()
	{
		_pointsUI.text = _currentPoints.ToString();
	}
}
