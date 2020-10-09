using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_Ctrl : MonoBehaviour
{
    public void LoadScene(string nameScene)
    {
        //method LoadScene by using the name of the scene
        SceneManager.LoadScene(nameScene);
    }
}