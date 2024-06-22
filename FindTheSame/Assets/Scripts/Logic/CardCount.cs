using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardCount : MonoBehaviour
{
	private int _currentCount;
	[SerializeField] private TextMeshProUGUI cardsCountUI;


	private void OnEnable()
	{
		CardSystem.instance.IsChangeCardsCount += SetCount;
	}

	private void OnDisable()
	{
		CardSystem.instance.IsChangeCardsCount -= SetCount;
	}

	public void SetCount(int count)
	{
		_currentCount = count;
		UpdateCardsView();
	}

	private void UpdateCardsView()
	{
		cardsCountUI.text = _currentCount.ToString();
	}
}
