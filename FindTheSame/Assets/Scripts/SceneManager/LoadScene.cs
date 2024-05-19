using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private int _id = 1;

    private void Start()
    {
        SceneManager.LoadScene(_id);
    }
}
