using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preLoadScene : MonoBehaviour
{
	[SerializeField] private int _id = 0;

	private void Awake()
	{
		if (CardSystem.systemInitialized == false)
		{
			SceneManager.LoadScene(_id);
		}
		else
		{
			Destroy(gameObject);
		}
	}
}
