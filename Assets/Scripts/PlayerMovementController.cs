using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    Transform _camera;
    Rigidbody _rb;

    public float Sensevity;
    public float StepSpeed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _camera = Camera.main.transform;
    }

    void Update()
    {
        float stepHorizontal = Input.GetAxis("Horizontal");
        float stepVertical = Input.GetAxis("Vertical");

        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");

        float currentSpeed = StepSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
            _rb.AddForce(Vector3.up * 300);

        if (Input.GetKey(KeyCode.LeftShift))
            currentSpeed = StepSpeed * 2;
        else
            currentSpeed = StepSpeed;

        if (GameController.Instance.State == GameState.Playing)
        {
            transform.Translate(new Vector3(stepHorizontal, 0, stepVertical) * currentSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * rotateHorizontal * Sensevity);

            _camera.Rotate(Vector3.left * rotateVertical * Sensevity);
            //_rb.MovePosition(transform.forward * currentSpeed * stepVertical);
        }
        if(_rb.velocity.x != 0)
            _rb.velocity = Vector3.zero;

        
    }
}