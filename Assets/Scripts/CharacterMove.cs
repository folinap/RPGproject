using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour
{
    [Header("Character Movement Stats")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    private Animator _animator;

    [Header("Gravity Handling")]
    private float _currentAttractionCharacter = 0;
    [SerializeField] private float _gravityForce = 20;

    [Header("Character components")]
    private CharacterController _characterController;

    private float _speed;
    private Vector3 _oldPosition;



    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        GravityHandling();
    }


    public void MoveCharacter(Vector3 moveDirection)
    {
        _speed = Vector3.Distance( moveDirection, new Vector3(0,0,0)) * 1.5f;
        Debug.Log(_speed);   
        _oldPosition = moveDirection;
        moveDirection = moveDirection * _moveSpeed;
        moveDirection.y = _currentAttractionCharacter;
        _characterController.Move(moveDirection * Time.deltaTime);
        _animator.SetFloat("Speed", _speed);
        
    }

    public void RotateCharacter(Vector3 moveDirection)
    {
        if(_characterController.isGrounded)
        {
            if(Vector3.Angle(transform.forward,moveDirection)> 0 )
            {
                Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection, _rotateSpeed, 0);
                transform.rotation = Quaternion.LookRotation(newDirection);
            }
        }
    }

    private void GravityHandling()
    {
        if(!_characterController.isGrounded)
        {
            _currentAttractionCharacter -= _gravityForce * Time.deltaTime;  
        }
        else
        {
            _currentAttractionCharacter = 0;
        }
    }
}
