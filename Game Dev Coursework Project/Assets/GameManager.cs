using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Cursor.visible = true;
        completeLevelUI.SetActive(true);
    }
}