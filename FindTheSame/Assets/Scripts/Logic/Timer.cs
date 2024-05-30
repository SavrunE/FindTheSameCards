using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _currentTime = 0f;
    private bool _isActiveTimer = true;
    public float time = 60f;
    [SerializeField] private TextMeshProUGUI timerUI;

    public Action OnStopTime;

	public void ActivateTimer(float time)
	{
		this.time = time;
		_isActiveTimer = true;
	}

    void Update()
    {
        if (_isActiveTimer)
        {
			if (time > _currentTime)
			{
				time -= Time.deltaTime;
			}
			else
			{
				OnStopTime?.Invoke();
				_isActiveTimer = false;
			}

			timerUI.text = ((int)time).ToString();
		}
	}
}
