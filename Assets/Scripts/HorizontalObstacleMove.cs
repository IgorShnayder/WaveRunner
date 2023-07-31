using UnityEngine;

public class HorizontalObstacleMove : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    private float _leftBoundary; 
    private float _rightBoundary;
    private bool _isMovingRight = true;
    
    private void Start()
    {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3((float)0.18, 0, distance));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3((float)0.82, 0, distance));
        
        _leftBoundary = leftMost.x;
        _rightBoundary = rightMost.x;
    }
    

    private void Update()
    {
        var moveSpeed = _moveSpeed * Time.deltaTime;

        if (_isMovingRight)
        {
            transform.Translate(Vector3.right * moveSpeed);
        }

        else
        {
            transform.Translate(Vector3.left * moveSpeed);
        }

        if (transform.position.x >= _rightBoundary)
        {
            _isMovingRight = false;
        }

        if (transform.position.x <= _leftBoundary)
        {
            _isMovingRight = true;
        }
    }
}
