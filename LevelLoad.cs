using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehavior {

    public void LoadLevel(string level){

        SceneManager.LoadScene(level);
    }
}