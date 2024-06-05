using UnityEngine;

public class EndsMemS : MonoBehaviour
{
    [SerializeField] private Sprite[] _winSprites;
    [SerializeField] private Sprite[] _loseSprites;

    public Sprite TakeWinSprite(int index)
    {
        return _winSprites[index];
    }

    public Sprite TakeLoseSprite(int index)
    {
        return _loseSprites[index];
	}

    public int TakeWinLenth()
    {
        return _winSprites.Length;
    }

    public int TakeLostLenth()
    {
		return _loseSprites.Length;
    }
}
