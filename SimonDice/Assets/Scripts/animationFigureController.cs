using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using CameraFading;


public class animationFigureController : MonoBehaviour
{
    Animator animator, animator2, animator3;
    AudioSource sniffSource;
    public AudioClip sniffAudio;
    EventTrigger characterEvent, characterEvent2, characterEvent3;
    public GameObject[] figures;
    public TextMesh levelText, winLoseText;
    Animator[] animators = new Animator[3];
    bool execute = false;
    int level = 1;
    int[] order = new int[10];
    int indiceOrder = 0;
    int lastOne = 0;
    int lastLevel = 11;

    public delegate void changeSprite();
    public static event changeSprite lose;

    // Start is called before the first frame update
    void Start()
    {
        sniffSource = GetComponent<AudioSource>();
        sniffSource.clip = sniffAudio;
        animator = figures[0].GetComponent<Animator>();
        characterEvent = figures[0].GetComponent<EventTrigger>();
        animator2 = figures[1].GetComponent<Animator>();
        characterEvent2 = figures[1].GetComponent<EventTrigger>();
        animator3 = figures[2].GetComponent<Animator>();
        characterEvent3 = figures[2].GetComponent<EventTrigger>();
        
        animators[0] = animator;
        animators[1] = animator2;
        animators[2] = animator3;
        //execute = true;
        
        characterEvent.triggers.Add(SetEvent(0,animator));
        characterEvent2.triggers.Add(SetEvent(1,animator2));
        characterEvent3.triggers.Add(SetEvent(2,animator3)); 

        play.start += startGame;
        play.finish += finishGame;
    }

    void startGame(){
        levelText.text ="Level: " + level.ToString();
        winLoseText.text = "";
        execute = true;
    }

    void finishGame(){
        level = 1;
        indiceOrder = 0;
        execute = false;
        levelText.text ="";
    }

    EventTrigger.Entry SetEvent( int figura,Animator animator){
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data) => { 
            if(order[indiceOrder] == figura && (indiceOrder == (level-1))){
                indiceOrder =0;
                animator.SetBool("IdleSnuff",true);
                sniffSource.Play(0);
                execute = true;
                winLoseText.text = "That was correct, Next level...";
                //animator.SetBool("IdleSnuff",false);
                level++;
            } else  if (order[indiceOrder] == figura){
             animator.SetBool("IdleSnuff",true);
             sniffSource.Play(0);
             indiceOrder++;
            } else{
                levelText.text ="Level: " + level.ToString();
                winLoseText.text = "You lose";
                lose();
                CameraFade.Out(() =>
                {
                    winLoseText.text = "";
                    levelText.text ="";
                    CameraFade.In(2f);
                }, 2f);
            }
         });
        return entry;
    }

     IEnumerator sleepLoop() {
          float waitTime = 2;
            execute = false;
            levelText.text ="Level: " + level.ToString();
            yield return new WaitForSeconds(3);
            winLoseText.text = "Start level";

            if (level == lastLevel)
            {
                winLoseText.text = "You pass all the levels";
                lose();
            }else {
                for (int i = 0; i < level; i++){
                    Random r = new Random();
                    int rInt = Random.Range(0, 3); 
                    Debug.Log("Execution figure number: " +rInt);
                    order[i] = rInt;
                    animators[rInt].SetBool("IdleSnuff",true);
                    sniffSource.Play(0);
                    yield return new WaitForSeconds(waitTime);
                    winLoseText.text = "";
                }
            }
     }
    // Update is called once per frame
    void Update()
    {
        if (execute)
        {
           StartCoroutine("sleepLoop");
        }
    }
}
