using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DesktopManager : MonoBehaviour
{

    GameObject openPanel;
    ButtonState currentButton; //ref to the script

    private void Start()
    {
        openPanel = null;
        currentButton = null;
    }
    public void OpenPanel(ButtonState b)
    {
        //if (currentButton)
        //{
        //    //openPanel.SetActive(false);
        //    currentButton.associatedPanel.SetActive(false);
        //    currentButton.ActiveButton();
        //}
        CloseCurrentPanel();
        b.associatedPanel.SetActive(true);
        b.SelectButton();
        //openPanel = button.associatedPanel;
        currentButton = b;
    }
    public void CloseCurrentPanel()
    {
        //if (openPanel != null && openPanel.activeInHierarchy)
        //{
        //    openPanel.SetActive(false);
        //}
        if (currentButton)
        {
            currentButton.associatedPanel.SetActive(false);
            currentButton.ActiveButton();
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
