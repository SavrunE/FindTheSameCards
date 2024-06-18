using UnityEngine;
using YG;

public class GameStarter : MonoBehaviour
{
	[SerializeField] private CardSpawner _cardSpawner;
	[SerializeField] private Timer _timer;

	private void Start()
	{
		SaverData sv = SaverData.instance;
		sv.Load();
		int cardCount = sv.GetLoadCards();
		float timeToScene = sv.GetLoadTimer();
		_cardSpawner.StartSpawn(cardCount);
		_timer.SetTime(timeToScene);
	}
}
