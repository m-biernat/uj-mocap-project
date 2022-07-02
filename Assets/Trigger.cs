using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent onTriggerEnter, onTriggerExit; 

    private void OnTriggerEnter(Collider other)
        => onTriggerEnter?.Invoke();

    private void OnTriggerExit(Collider other)
        => onTriggerExit?.Invoke();
}
