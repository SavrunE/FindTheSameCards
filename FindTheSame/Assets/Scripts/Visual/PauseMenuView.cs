using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuView : MonoBehaviour
{
    [SerializeField] private Image[] _images;
    [SerializeField] private EndsMemS _mems;

    private void Start()
    {
        OpenMenu();

	}

    public void OpenMenu()
    {
        var s = _mems.TakeRndSprites(_images.Length);
        for (int i = 0; i < _images.Length; i++)
        {
            _images[i].sprite = s[i];

		}
	}

    public void CloseMenu()
    {

    }
}
