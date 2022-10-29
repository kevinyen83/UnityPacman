using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class SceneControl : MonoBehaviour
    {
    //No return = void, Return = int, float
        public void ChangeScene(string SceneName)
        {
            SceneManager.LoadScene(SceneName);
        }
    }


