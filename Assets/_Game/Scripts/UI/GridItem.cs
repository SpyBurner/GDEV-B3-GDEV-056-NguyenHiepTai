using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class GridItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GOEventChannel goEventChannel;

    public void OnPointerClick(PointerEventData eventData)
    {
        goEventChannel.eventChannel.Invoke(gameObject);
        Debug.Log("GridItem: Sibling index of GridItem: " + transform.GetSiblingIndex().ToString());
    }
}
