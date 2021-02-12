using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropOn : MonoBehaviour, IDropHandler
{
    private Drag fipDragComponent;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ON DROP");
        if (eventData.pointerDrag != null) {
            fipDragComponent = eventData.pointerDrag.GetComponent<Drag>();
            if (fipDragComponent.fipScaleReference) { //TODO: add condition to trigger action
}
            else {
                fipDragComponent.resetPosition();
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
