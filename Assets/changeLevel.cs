using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Needed to change scenes

public class changeLevel : MonoBehaviour
{
    [SerializeField]
    string levelName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevel()
    {
        //Load scene of the given name
        SceneManager.LoadScene(levelName);
    }
}
