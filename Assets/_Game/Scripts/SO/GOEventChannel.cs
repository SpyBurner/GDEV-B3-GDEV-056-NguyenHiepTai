using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "GOEventChannel", menuName = "Scriptable Objects/GOEventChannel")]
public class GOEventChannel : ScriptableObject
{
    public UnityEvent<GameObject> eventChannel;
}
