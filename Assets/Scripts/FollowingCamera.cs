using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [Header("Object For Following")]
    [SerializeField] private GameObject _mainCharacter;

    [Header("Camera Properties")]
    [SerializeField] private float _returnSpeed;
    [SerializeField] private float _height;
    [SerializeField] private float _rearDistance;

    private Vector3 currentVector;

    void Start()
    {
        transform.position = new Vector3(_mainCharacter.transform.position.x, _mainCharacter.transform.position.y + _height, _mainCharacter.transform.position.z - _rearDistance);
        transform.rotation = Quaternion.LookRotation(_mainCharacter.transform.position - transform.position);
    }

    void Update()
    {
        CameraMove();
    }

    void CameraMove()
    {
        currentVector = new Vector3(_mainCharacter.transform.position.x, _mainCharacter.transform.position.y + _height, _mainCharacter.transform.position.z - _rearDistance);
        transform.position = Vector3.Lerp(transform.position, currentVector, _returnSpeed * Time.deltaTime);
    }
}
