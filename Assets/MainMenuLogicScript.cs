using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogicScript : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("FlappyBird");
    }
    public void quitGame(){
        Application.Quit();
    }
}
