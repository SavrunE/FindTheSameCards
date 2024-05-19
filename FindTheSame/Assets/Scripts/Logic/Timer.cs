using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _currentTime = 0f;
    public float time = 60f;
    [SerializeField] private TextMeshProUGUI timerUI;

    public Action OnStopTime;

    void Update()
    {
        if (time > _currentTime)
        {
			time -= Time.deltaTime;
		}
        else
        {
			OnStopTime?.Invoke();
		}

        timerUI.text = ((int)time).ToString();
	}
}
