using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if (_target.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, _target.position.y, -10);
        }
    }
}
