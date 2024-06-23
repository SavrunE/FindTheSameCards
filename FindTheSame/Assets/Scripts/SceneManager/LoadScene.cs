using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private const int _baseSceneId = 1;

    private void Start()
    {
        SceneManager.LoadScene(_baseSceneId);
    }

    public void LoadDefaultScene()
    {
		SceneManager.LoadScene(_baseSceneId);
	}
}
