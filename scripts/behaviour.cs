using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using CameraFading;


public class animationFigureController : MonoBehaviour
{
    public AudioClip roarAudio, hardRoarAudio, winAudio;
    
    public GameObject[] figures;
    
    public TextMesh levelText, winLoseText;
    
    Animator animator, animator2, animator3;
    
    Animator[] animators = new Animator[3];
    
    AudioSource audioSource;
    
    EventTrigger characterEvent, characterEvent2, characterEvent3;
    
    int[] order = new int[10];
    
    int level = 1;
    int indiceOrder = 0;
    int lastOne = 0;
    int lastLevel = 6;
    
    bool execute = false;
    bool loser = false;
    bool playerTurn = false;
    bool exit = false;

    public delegate void changeSprite();
    public static event changeSprite lose;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = roarAudio;
        animator = figures[0].GetComponent<Animator>();
        characterEvent = figures[0].GetComponent<EventTrigger>();
        animator2 = figures[1].GetComponent<Animator>();
        characterEvent2 = figures[1].GetComponent<EventTrigger>();
        animator3 = figures[2].GetComponent<Animator>();
        characterEvent3 = figures[2].GetComponent<EventTrigger>();

        animators[0] = animator;
        animators[1] = animator2;
        animators[2] = animator3;

        characterEvent.triggers.Add(SetEvent(0, animator));
        characterEvent2.triggers.Add(SetEvent(1, animator2));
        characterEvent3.triggers.Add(SetEvent(2, animator3));

        play.start += startGame;
        play.finish += finishGame;
    }

    void startGame()
    {
        levelText.text = "Level: " + level.ToString();
        winLoseText.text = "";
        execute = true;
    }

    void finishGame()
    {
        level = 1;
        indiceOrder = 0;
        execute = false;
        levelText.text = "";
        exit = true;
    }

    EventTrigger.Entry SetEvent(int figura, Animator animator)
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) =>
        {
            if (playerTurn)
            {
                if (order[indiceOrder] == figura && (indiceOrder == (level - 1)))
                {
                    indiceOrder = 0;
                    animator.SetBool("Roar", true);
                    audioSource.Play(0);
                    execute = true;
                    winLoseText.text = "That was correct, Next level...";
                    level++;
                    playerTurn = false;
                }
                else if (order[indiceOrder] == figura)
                {
                    animator.SetBool("Roar", true);
                    audioSource.Play(0);
                    indiceOrder++;
                }
                else
                {
                    levelText.text = "Level: " + level.ToString();
                    winLoseText.text = "You lose";
                    lose();
                    loser = true;
                    CameraFade.Out(() =>
                    {
                        winLoseText.text = "";
                        levelText.text = "";
                        CameraFade.In(2f);
                    }, 2f);
                    playerTurn = false;
                    exit = true;
                }
            }
        });
        return entry;
    }

    IEnumerator sleepLoop()
    {
        float waitTime = 3;
        audioSource.clip = roarAudio;
        execute = false;
        exit = false;
        levelText.text = "Level: " + level.ToString();
        yield return new WaitForSeconds(waitTime);
        winLoseText.text = "Start level";

        if (level == lastLevel)
        {
            winLoseText.text = "You Win";
            audioSource.clip = winAudio;
            audioSource.Play(0);
            lose();
        }
        else
        {
            for (int i = 0; i < level && !exit; i++)
            {
                Random r = new Random();
                int rInt = Random.Range(0, 3);
                Debug.Log("Execution figure number: " + rInt);
                order[i] = rInt;
                animators[rInt].SetBool("Roar", true);
                audioSource.Play(0);
                yield return new WaitForSeconds(2.5f);
                winLoseText.text = "";
            }
            playerTurn = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (execute)
        {
            StartCoroutine("sleepLoop");
        }
        if (loser)
        {
            animators[0].SetBool("Roar", true);
            animators[1].SetBool("Roar", true);
            animators[2].SetBool("Roar", true);
            audioSource.clip = hardRoarAudio;
            audioSource.Play(0);
            loser = false;
        }
    }
}
