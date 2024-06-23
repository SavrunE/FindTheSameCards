using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private PauseMenuView _pauseMenu;
    private bool _isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isPaused == false)
            {
                _isPaused = true;
				_pauseMenu.gameObject.SetActive(true);
				_pauseMenu.OpenMenu();
				Debug.Log("Pause");
			}
            else
			{
                Continue();
			}
        }
        if (_isPaused && Input.GetKeyDown(KeyCode.Mouse0))
        {
			Continue();
		}
    }

    private void Continue()
    {
		_isPaused = false;
		_pauseMenu.CloseMenu();
		Debug.Log("Play");
		_pauseMenu.gameObject.SetActive(false);
	}
}
