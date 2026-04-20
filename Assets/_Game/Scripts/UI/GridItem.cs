using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class GridItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GOEventChannel goEventChannel;
    [SerializeField]
    private GOEventChannel gridItemBroadcastChannel;

    private void Start()
    {
        if (goEventChannel != null && goEventChannel.eventChannel != null)
        {
            goEventChannel.eventChannel.Invoke(gameObject);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.childCount > 0)
        {
            return;
        }

        goEventChannel.eventChannel.Invoke(gameObject);
        Debug.Log("GridItem: Sibling index of GridItem: " + transform.GetSiblingIndex().ToString());
    }
}
