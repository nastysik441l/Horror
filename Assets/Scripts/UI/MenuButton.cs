
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
 public void LoadScene(int sceneNumber)
 {
    SceneManager.LoadScene(sceneNumber);
 }


 public void ExitGame()
 {
   Application.Quit();
   
 }
}
