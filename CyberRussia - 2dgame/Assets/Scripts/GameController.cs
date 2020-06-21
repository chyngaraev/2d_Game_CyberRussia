using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BoyController
{


    public class GameController : MonoBehaviour
    {

        private void Awake()
        {
            ExitDoor.OnFinishLevel += ChangeScenes;
        }
        
        public void ChangeScenes()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (currentSceneIndex == 2) { SceneManager.LoadScene(0); }
            if(currentSceneIndex == 1) { SceneManager.LoadScene(2); }

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        private void OnDisable()
        {
            ExitDoor.OnFinishLevel -= ChangeScenes;
        }

    }
}
