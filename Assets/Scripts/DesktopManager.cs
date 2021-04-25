using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesktopManager : MonoBehaviour
{
    public int delayToRestart = 2;

    GameObject openPanel;

    private void Start()
    {
        openPanel = null;
    }
    public void OpenPanel(GameObject targetPanel)
    {
        AudioManager.instance.Play("openPanelSound");

        if (openPanel)
        {
            openPanel.SetActive(false);
        }
        targetPanel.SetActive(true);
        openPanel = targetPanel;
    }
    public void CloseCurrentPanel()
    {

        if (openPanel)
        {
            AudioManager.instance.Play("closePanelSound");

            if (openPanel != null && openPanel.activeInHierarchy)
            {

                openPanel.SetActive(false);
            }
        }
    }
    public void RestartGame()
    {
        StartCoroutine(LoadGameAgain());
    }
    IEnumerator LoadGameAgain()
    {
        AudioManager.instance.Play("restartSound");

        yield return new WaitForSeconds(delayToRestart);

        SceneManager.LoadScene(0);
    }
}
