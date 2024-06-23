using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
	private int _currentPoints = 0;
	[SerializeField] private int _pintsAccrual;
	[SerializeField] private TextMeshProUGUI _pointsUI;
	[SerializeField] private CardSystem _cardSystem;

	private void OnEnable()
	{
		_cardSystem.IsTakeRightCards += AddPoints;
	}

	private void OnDisable()
	{
		_cardSystem.IsTakeRightCards -= AddPoints;
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

	public int TakePoints()
	{
		return _currentPoints;
	}

	public void SetPoints(int points)
	{
		_currentPoints = points;
		UpdatePointsView();
	}
}
