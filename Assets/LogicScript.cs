using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public float playerScore=0;
    
    public Text scoreText;
    public GameObject GameOverObject;
    [ContextMenu("IncreaseScore")]
    public void AddScore(){
        playerScore+=1;
        scoreText.text=playerScore.ToString();
    }
    public void retryGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        GameOverObject.SetActive(true);
    }
    public void mainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
