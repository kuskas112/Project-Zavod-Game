using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ChooseBagForSelection", menuName = "ChooseBagForSelection", order = 0)]
public class ChooseBagForSelection : ScriptableObject 
{
    [SerializeField]
    public Sprite[] bagSprites;
    [SerializeField]
    public int[] conditionsLeft;
    [SerializeField]
    public int[] conditionsRight;
    
    
}
