using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesktopManager : MonoBehaviour
{

    GameObject openPanel;

    private void Start()
    {
        openPanel = null;
    }
    public void OpenPanel(GameObject targetPanel)
    {
        if (openPanel)
        {
            openPanel.SetActive(false);
        }
        targetPanel.SetActive(true);
        openPanel = targetPanel;
    }
    public void CloseCurrentPanel()
    {
        openPanel.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
