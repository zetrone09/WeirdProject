using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIManager : MonoBehaviour
{
    int sceneBuildIndex = 1;
    public void NewGame()
    {
        SceneManager.LoadSceneAsync(sceneBuildIndex);
    }
    public void LoadGame()
    {
        SceneManager.LoadSceneAsync(sceneBuildIndex + 1);
    }
}
