using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "IntEventChannelSO", menuName = "Scriptable Objects/IntEventChannelSO")]
public class IntEventChannelSO : ScriptableObject
{
    public UnityEvent<int> eventChannel;
}
