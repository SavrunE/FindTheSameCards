using UnityEngine;
using UnityEngine.UI;

public class PauseMenuView : MonoBehaviour
{
    [SerializeField] private Image[] _images;
    [SerializeField] private EndsMemS _mems;

    public void OpenMenu()
    {
		UsePause(true);
		var s = _mems.TakeRndSprites(_images.Length);
        for (int i = 0; i < _images.Length; i++)
        {
            _images[i].sprite = s[i];
		}
	}

    public void CloseMenu()
    {
		UsePause(false);
	}

	private void UsePause(bool value)
	{
		if (value)
		{
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = 1f;
		}
	}
}
