using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropOn : MonoBehaviour, IDropHandler
{
    private Drag fipDragComponent;
    public int scaledTimes = 0;
    public GameObject heartMessage;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ON DROP");
        if (eventData.pointerDrag != null) {
            fipDragComponent = eventData.pointerDrag.GetComponent<Drag>();
            fipDragComponent.AlreadyAddedToHeart();
            fipDragComponent.resetPosition();
            GetComponent<AudioSource>().Play();

            if(scaledTimes < 5)
            {
                gameObject.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = gameObject.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta + new UnityEngine.Vector2(fipDragComponent.fipScaleReference, fipDragComponent.fipScaleReference); 
                scaledTimes++;
            }

            if (scaledTimes >= 5) {
                heartMessage.SetActive(true);
            }
            
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
