using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Digit", menuName = "Digit", order = 1)]
public class Digit : ScriptableObject 
{
    [SerializeField]
    public int nominal;
    
    [SerializeField]
    public Sprite[] sprites;
    
}
