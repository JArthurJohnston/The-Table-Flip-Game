using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableMenuItem : MonoBehaviour, IMenuItem {

    public string levelName;

    public void Activate()
    {
        SceneManager.LoadSceneAsync(levelName);
    }

}
