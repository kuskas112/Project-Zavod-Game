using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundGraph : MonoBehaviour
{
    public float percentage = 10f;
    public Image img = null;
    private bool isSpacePressed = false;
    private float pointerPos;

    void Start()
    {
        if(img == null){
            img = gameObject.GetComponent<Image>();
        }
        img.fillAmount = percentage/100;
        Quaternion rotationZ = Quaternion.AngleAxis(Random.Range(0, 361), new Vector3(0,0,1));
        transform.rotation = rotationZ;
    }
    private void Update() {
        if(Input.GetKey("space") && isSpacePressed == false){
            pointerPos = RoundGame.rotation;
            isSpacePressed = true;
            
            float winRange = 360*(percentage/100);
            float greenBarPos = transform.rotation.eulerAngles.z;
            if(pointerPos<0){pointerPos += 360;}
            if(pointerPos <= greenBarPos && pointerPos >= (greenBarPos-winRange)){
                Debug.Log("WIN");
            }
            else{
                Debug.Log("LOSE");
            }

        }
    }
}
