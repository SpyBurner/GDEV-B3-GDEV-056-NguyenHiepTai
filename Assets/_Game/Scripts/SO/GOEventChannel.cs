using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "GOEventChannel", menuName = "Scriptable Objects/GOEventChannel")]
public class GOEventChannel : ScriptableObject
{
    public UnityEvent<GameObject> eventChannel = new UnityEvent<GameObject>();

    private void OnEnable()
    {
        if (eventChannel == null)
        {
            eventChannel = new UnityEvent<GameObject>();
        }
    }
}
