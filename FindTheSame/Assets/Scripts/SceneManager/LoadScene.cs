using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private int _id = 2;

    private void Start()
    {
        SceneManager.LoadScene(_id);
    }

    public void LoadDefaultScene()
    {
		SceneManager.LoadScene(_id);
	}
}
