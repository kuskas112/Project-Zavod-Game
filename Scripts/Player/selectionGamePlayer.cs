using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectionGamePlayer : MonoBehaviour
{
    private SpriteRenderer sr;
    private bool canChange = true;
    private Animator neededAnim;
    public float duration = 0.4f;
    public Animator animLeftTruck;
    public Animator animRightTruck;
    public SpriteRenderer[] bags;
    private Sprite[] bagSprites;
    public Sprite ggRight;
    public Sprite ggLeft;
    public Sprite ggForward;
    private Sprite neededSprite;
    private int currBagIndex;
    private ChooseBagForSelection currLvl;
    public TMP_Text scoreText;
    private int score = 0;
    void Start()
    {
        LevelManager.currentLevel = 0;
        PlayerPrefs.SetInt("CurrentLevel", 0);
        //only first lvl for now

        sr = GetComponent<SpriteRenderer>();

        ChooseBagForSelection[] levels = Resources.LoadAll<ChooseBagForSelection>("");
        bagSprites = new Sprite[levels[LevelManager.currentLevel].bagSprites.Length];
        for (int i = 0; i < levels[LevelManager.currentLevel].bagSprites.Length; i++)
        {
            bagSprites[i] = levels[LevelManager.currentLevel].bagSprites[i];
        }
        currLvl = levels[LevelManager.currentLevel];
        changeBag();
    }

    void Update()
    {
        if(Timer.timeStopped){return;}
        if(Input.GetKey(KeyCode.A) && canChange){
            
            neededSprite = ggLeft;
            neededAnim = animLeftTruck;

            int gainScore = currLvl.conditionsLeft[currBagIndex];
            DigitManager.SetDigits(gainScore);
            if(gainScore > 0){
                neededAnim.SetBool("SuccessThrow", true);
            }
            else{
                neededAnim.SetBool("SuccessThrow", false);
            }

            score += gainScore;
            StartCoroutine(waiter());
            scoreText.text = score.ToString();
            return;
        }
        if(Input.GetKey(KeyCode.D) && canChange){
            
            neededSprite = ggRight;
            neededAnim = animRightTruck;
            int gainScore = currLvl.conditionsRight[currBagIndex];
            DigitManager.SetDigits(gainScore);
            if(gainScore > 0){
                neededAnim.SetBool("SuccessThrow", true);
            }
            else{
                neededAnim.SetBool("SuccessThrow", false);
            }

            score += gainScore;
            StartCoroutine(waiter());
            scoreText.text = score.ToString();
            return;
        }
    }

    IEnumerator waiter()
    {
        neededAnim.Play("BagDrop");
        bags[0].enabled = false;
        canChange = false;
        sr.sprite = neededSprite;
        yield return new WaitForSeconds(duration);
        sr.sprite = ggForward;
        canChange = true;
        bags[0].enabled = true;
        changeBag();
    }

    void changeBag(){
        System.Random rnd = new System.Random();
        int rndIndex = rnd.Next(0, bagSprites.Length);
        currBagIndex = rndIndex;
        foreach(SpriteRenderer srr in bags){
            srr.sprite = bagSprites[rndIndex];
        }
    }
}
