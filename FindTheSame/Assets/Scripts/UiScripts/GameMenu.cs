using UnityEngine;

public class GameMenu : MonoBehaviour
{
	[SerializeField] private GameObject _pauseMenu;
	[SerializeField] private GameObject _loseMenu;

	private bool _isMenuOpen;

	private void Start()
	{
		_pauseMenu.SetActive(false);
		_loseMenu.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && _isMenuOpen == false)
		{
			ChangePauseMenu();
		}
	}

	public void ChangePauseMenu()
	{
		if (_pauseMenu.activeSelf == false)
		{
			ShowPauseMenu(true);
		}
		else
		{
			ShowPauseMenu(false);
		}
	}

	public void ShowPauseMenu(bool value)
	{
		if (value)
		{
			OpenMenu(_pauseMenu);
		}
		else
		{
			CloseMenu(_pauseMenu);
		}
	}

	public void ShowLoseMenu(bool value)
	{
		if (value)
		{
			
			OpenMenu(_loseMenu);
		}
		else
		{
			CloseMenu(_loseMenu);
		}
	}

	private void OpenMenu(GameObject menu)
	{
		_isMenuOpen = true;
		menu.SetActive(true);
		UsePause(true);
	}

	private void CloseMenu(GameObject menu)
	{
		_isMenuOpen = false;
		menu.SetActive(false);
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
