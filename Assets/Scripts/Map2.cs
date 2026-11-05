using UnityEngine;

public class map2 : MonoBehaviour
{
    [SerializeField] private float normalSpeed = 2.0f;
    [SerializeField] private float boostSpeed = 2.0f;
    //[SerializeField] private float rotationSpeed = 60.0f;
    public KeyCode boostKey = KeyCode.LeftShift;
    public Rigidbody2D myRigid;

    void Update()
    {
        // Use boostSpeed if holding the boost key, otherwise use normalSpeed
        float currentSpeed = Input.GetKey(boostKey) ? boostSpeed : normalSpeed;

        transform.Translate(Vector3.down * currentSpeed * Time.deltaTime, Space.World);
        //transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}

