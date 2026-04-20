using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private GOEventChannel goEventChannel;

    private void OnEnable()
    {
        goEventChannel.eventChannel.AddListener(MoveEventHandler);
    }

    private void OnDisable()
    {
        goEventChannel.eventChannel.RemoveListener(MoveEventHandler);
    }

    void MoveEventHandler(GameObject parGO)
    {
        transform.SetParent(parGO.transform);
    }

}
