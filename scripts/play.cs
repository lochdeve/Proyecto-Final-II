using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class play : MonoBehaviour
{
    public GameObject button, camera, wall;
    
    public SpriteRenderer spriteRenderer;
    
    public Sprite finishSprite, playSprite, dissappearSprite;
    
    EventTrigger buttonEvent;

    int spriteStatus = 0;

    public delegate void actionGame();
    public static event actionGame start, finish;

    // Start is called before the first frame update
    void Start()
    {
        buttonEvent = button.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) =>
        {
            if (spriteStatus == 0)
            {
                spriteRenderer.sprite = finishSprite;
                start();
                spriteStatus = 1;
            }
            else if (spriteStatus == 1)
            {
                spriteRenderer.sprite = playSprite;
                finish();
                spriteStatus = 0;
            }
        });
        buttonEvent.triggers.Add(entry);
        animationFigureController.lose += lose;
    }

    void lose()
    {
        spriteRenderer.sprite = playSprite;
        spriteStatus = 0;
        finish();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distanciaJugador = Vector3.Distance(camera.transform.position, wall.transform.localPosition);
        if (distanciaJugador > 9)
        {
            spriteRenderer.sprite = dissappearSprite;
            finish();
            spriteStatus = 2;
        }
        else if (spriteStatus == 2)
        {
            spriteStatus = 0;
            spriteRenderer.sprite = playSprite;
        }
    }
}
