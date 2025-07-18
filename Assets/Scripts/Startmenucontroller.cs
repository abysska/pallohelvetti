using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startmenucontroller : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("minigame");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit(); 


    }
  

}
