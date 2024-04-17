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
        sr = GetComponent<SpriteRenderer>();

        ChooseBagForSelection[] levels = Resources.LoadAll<ChooseBagForSelection>("");
        bagSprites = new Sprite[levels[0].bagSprites.Length];
        for (int i = 0; i < levels[0].bagSprites.Length; i++)
        {
            bagSprites[i] = levels[0].bagSprites[i];
        }
        currLvl = levels[0];
        changeBag();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) && canChange){
            
            neededSprite = ggLeft;
            neededAnim = animLeftTruck;
            score += currLvl.conditionsLeft[currBagIndex];
            StartCoroutine(waiter());
            scoreText.text = score.ToString();
            return;
        }
        if(Input.GetKey(KeyCode.D) && canChange){
            
            neededSprite = ggRight;
            neededAnim = animRightTruck;
            score += currLvl.conditionsRight[currBagIndex];
            StartCoroutine(waiter());
            scoreText.text = score.ToString();
            return;
        }
    }

    IEnumerator waiter()
    {
        neededAnim.SetBool("bagDropped", true);
        bags[0].enabled = false;
        canChange = false;
        sr.sprite = neededSprite;
        yield return new WaitForSeconds(duration);
        sr.sprite = ggForward;
        canChange = true;
        bags[0].enabled = true;
        neededAnim.SetBool("bagDropped", false);
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
