using UnityEngine;

[RequireComponent(typeof(Animator))]
    
public class RootMotion : MonoBehaviour {
    
    [SerializeField]
    private float _yRotation;

    private Quaternion _rotation;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>(); 
        var rot = Vector3.zero;
        rot.y = _yRotation;
        transform.Rotate(rot);
        _rotation = Quaternion.Euler(-rot);
    }

    void OnAnimatorMove()
    {          
            if (_animator)
                transform.position += _rotation
                                    * transform.forward
                                    * _animator.GetFloat("ForwardSpeed")
                                    * _animator.speed
                                    * transform.localScale.magnitude
                                    * Time.deltaTime;
    }
}