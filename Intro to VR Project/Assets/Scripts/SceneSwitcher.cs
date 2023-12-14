using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }

    public void World1()
    {

        SceneManager.LoadScene(sceneBuildIndex:1);
    }

}