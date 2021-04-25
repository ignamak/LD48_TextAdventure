using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotification : MonoBehaviour
{
    public GameObject SystemMessages;

    RectTransform rectTransform;

    Vector3 hidePosition;
    Vector3 showPosition;

    bool movingNotification;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        hidePosition = new Vector3(12f, -2.5f, 90);
        showPosition = new Vector3(6.339028358459473f, -2.5f, 90);
    }

    // Update is called once per frame
    void Update()
    {
        //-----------------------------------------------------------DEBUG----------ESTO HABRA QUE QUITARLO
        if (Input.GetKeyDown(KeyCode.H) && !movingNotification)
        {
            movingNotification = true;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            movingNotification = false;
        }
        //-----------------------------------------------------------------------


        switch (movingNotification)
        {
            case true:
                rectTransform.position = Vector3.MoveTowards(rectTransform.position, showPosition , 0.05f);
                break;
            case false:
                rectTransform.position = Vector3.MoveTowards(rectTransform.position, hidePosition, 0.1f);
                break;
        }
    }

    public void MoveNotification(bool inOut) 
    {
        movingNotification = inOut;      
    }

    public void OnNotificationClick() 
    {
        MoveNotification(false);

        DesktopManager desktopManager = GameObject.FindObjectOfType<DesktopManager>();
        desktopManager.CloseCurrentPanel();
        desktopManager.OpenPanel(SystemMessages);
    }
}
