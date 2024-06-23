using UnityEngine;
using YG;

public class GameStarter : MonoBehaviour
{
	[SerializeField] private CardSpawner _cardSpawner;
	[SerializeField] private Timer _timer;
	[SerializeField] private Points _points;

	private void Start()
	{
		SaverData sv = SaverData.instance;
		sv.Load();
		int cardCount = sv.GetLoadCards();
		int points = sv.GetLoadPoints();
		float timeToScene = sv.GetLoadTimer();
		_cardSpawner.StartSpawn(cardCount);
		_points.SetPoints(points);
		_timer.SetTime(timeToScene);
	}
}
