using UnityEngine;

public class PhaseOffset : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float cycleOffset;

    public bool mirror;

    private void Awake()
    {
        var animator = GetComponent<Animator>();
        animator.SetFloat("CycleOffset", cycleOffset);
        animator.SetBool("Mirror", mirror);
    }
}
