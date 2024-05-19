using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUiController : MonoBehaviour
{
	public static GameUiController instance;

	[SerializeField] private GameMenu _gameMenu;

	[SerializeField] private Text _health;
    [SerializeField] private Text _points;

	private int _healthCount;
	private int _pointsCount;

	public Action<int> onHealthChange;
    public Action<int> onPointsChange;

	private void Awake()
	{
		if (instance != null)
		{
			Debug.Log("tried to double GameUiController instance");
			return;
		}
		instance = this;
	}

	public void SetHealth(int value)
	{
		_healthCount = value;
		ChangeHealth();
	}

	public void SetPoints(int value)
	{
		_pointsCount = value;
		ChangePoinsts();
	}

	public void AddHealth(int value)
	{
		_healthCount += value;
		ChangeHealth();
		if (_healthCount <= 0)
		{
			_gameMenu.ShowLoseMenu(true);
		}
	}

	public void AddPoints(int value)
    {
		_pointsCount += value;
		ChangePoinsts();
	}

	private void ChangeHealth()
	{
		_health.text = _healthCount.ToString();
		onHealthChange?.Invoke(_healthCount);
	}

	private void ChangePoinsts()
	{
		_points.text = _pointsCount.ToString();
		onPointsChange?.Invoke(_pointsCount);
	}
}
