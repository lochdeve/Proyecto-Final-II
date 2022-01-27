using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class startButton : MonoBehaviour
{
    EventTrigger characterEvent;
    // Start is called before the first frame update
    void Start()
    {

        characterEvent = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) =>
        {
            SceneManager.LoadScene("Game");
        });
        characterEvent.triggers.Add(entry);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
    }
}