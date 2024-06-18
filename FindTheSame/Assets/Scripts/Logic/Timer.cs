using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _currentTime = 0f;
    private bool _isActiveTimer = true;
    private float _time = 60f;
    [SerializeField] private TextMeshProUGUI timerUI;

    public Action OnStopTime;

	public void SetTime(float time)
	{
		_time = time;
	}

	public void ActivateTimer(float time)
	{
		this._time = time;
		_isActiveTimer = true;
	}

    void Update()
    {
        if (_isActiveTimer)
        {
			if (_time > _currentTime)
			{
				_time -= Time.deltaTime;
			}
			else
			{
				OnStopTime?.Invoke();
				_isActiveTimer = false;
			}

			timerUI.text = ((int)_time).ToString();
		}
	}
}
