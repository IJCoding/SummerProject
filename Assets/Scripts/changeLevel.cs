using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Needed to change scenes

public class changeLevel : MonoBehaviour
{
    [SerializeField]
    string levelName;

    public void ChangeLevel()
    {
        //Load scene of the given name
        SceneManager.LoadScene(levelName);
    }
}
