using System;
using UnityEngine;

public class AlphaChanger : Singleton<AlphaChanger>
{
	public float timeToChange = 1f;

	private float _currentAlpha;
	private float _currentTime;

	[SerializeField] private Vector2 _alphaRange = new Vector2(0.6f, 1f);
	[SerializeField] private bool _isChange = false;

	public Action<float> isChangeCurrentAlpha;

	private void Update()
	{
		if (_isChange)
		{
			if (_currentTime < timeToChange)
			{
				_currentTime += Time.deltaTime;
				_currentAlpha = Mathf.Lerp(_alphaRange.y, _alphaRange.x, _currentTime / timeToChange);
				//Debug.Log(_currentAlpha);
			}
			else
			{
				_currentTime = 0f;
				ReverseAlpha();
			}
			isChangeCurrentAlpha?.Invoke(_currentAlpha);
		}
	}

	public float TakeAlpha()
	{
		return _currentAlpha;
	}

	private void ReverseAlpha()
	{
		Vector2 cAlphaRange = _alphaRange;
		_alphaRange = new Vector2(cAlphaRange.y, cAlphaRange.x);
	}

	public void ActivateTimer()
	{
		_isChange = true;
	}

	public void StopTimer()
	{
		_isChange = false;
	}

	public void ResetTimer()
	{
		_currentTime = 0f;
	}
}
