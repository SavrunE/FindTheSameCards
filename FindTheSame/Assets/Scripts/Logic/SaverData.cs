using UnityEngine;

namespace YG
{
    public class SaverData : Singleton<SaverData>
    {
        [SerializeField] private int _cardCount;
		[SerializeField] private float _timeToScene;

		private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
        private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

        //private void Awake()
        //{
        //    if (YandexGame.SDKEnabled)
        //        GetLoad();
        //}

        public void SaveByWin()
        {
            YandexGame.savesData.SaveByWin();
			YandexGame.SaveProgress();
        }

		public void SaveByLost()
		{
			YandexGame.savesData.SaveByLost();
			YandexGame.SaveProgress();
		}

		public void Load() => YandexGame.LoadProgress();

        private void GetLoad()
        {
            _cardCount = YandexGame.savesData.cardCount;
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
    }
}