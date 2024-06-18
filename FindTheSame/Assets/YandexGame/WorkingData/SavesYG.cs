
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Ваши сохранения
        public int cardCount = 10;
        public float timeToScene = 30f;
        // ...

        public void SaveByWin()
        {
            cardCount++;
            timeToScene++;
		}

        public void SaveByLost()
        {
			cardCount--;
			timeToScene--;
		}
    }
}
