using UnityEngine;

namespace YG
{
    public class SaverData : Singleton<SaverData>
    {
        private int _cardCount;
		private int _points;
		private float _timeToScene;

		private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
        private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

        public void SaveByWin(int points)
        {
            YandexGame.savesData.SaveByWin(points);
			YandexGame.SaveProgress();
        }

		public void SaveByLost(int points)
		{
			YandexGame.savesData.SaveByLost(points);
			YandexGame.SaveProgress();
		}

		public void Load() => YandexGame.LoadProgress();

        private void GetLoad()
        {
            _cardCount = YandexGame.savesData.cardCount;
			_points = YandexGame.savesData.points;
			_timeToScene = YandexGame.savesData.timeToScene;
        }

        public int GetLoadCards()
        {
            return YandexGame.savesData.cardCount;
		}

        public float GetLoadTimer()
        {
            return YandexGame.savesData.timeToScene;
		}

		public int GetLoadPoints()
		{
			return YandexGame.savesData.points;
		}
	}
}