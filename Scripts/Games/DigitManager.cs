using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitManager : MonoBehaviour
{
    // Start is called before the first frame update\
    private static SpriteRenderer firstDigit;
    private static SpriteRenderer secondDigit;
    private static Animator anim;

    public SpriteRenderer firstDigitNotStatic;
    public SpriteRenderer secondDigitNotStatic;
    public Animator animNotStatic;

    private static Digit[] digits;
    void Start()
    {
        digits = Resources.LoadAll<Digit>("");
        firstDigit = firstDigitNotStatic;
        secondDigit = secondDigitNotStatic;
        anim = animNotStatic;
    }

    public static void SetDigits(int digs){
        if(digs < 0){
            return;
        }
        int first = digs / 10;
        int second = digs % 10;
        Digit d1 = digits[first];
        Digit d2 = digits[second];
        //can be random digits someday
        firstDigit.sprite = d1.sprites[0];
        secondDigit.sprite = d2.sprites[0];
        anim.Play("DigitAnim");
    }


}
