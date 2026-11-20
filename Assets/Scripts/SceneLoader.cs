using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadGameScene()
   {

      SceneManager.LoadScene("GameScene");

   }
   public void LoadCreditsScene()
   {

      SceneManager.LoadScene("CreditsScene");

   }
   public void LoadMenuScene()
   {

      SceneManager.LoadScene("MenuScene");

   }

   public void Quit()
   {
        
      Application.Quit();
        
   }
}
