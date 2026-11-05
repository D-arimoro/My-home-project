using Unity.VisualScripting;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    [SerializeField] public float normalSpeed = 4.0f;
    [SerializeField] public float boostSpeed = 8.0f;
    public float accelerate = 5f;
    public float decelerate = 4f;
    [SerializeField] public float rotationSpeed = 0.5f;
    public KeyCode boostKey = KeyCode.LeftShift;
    public Rigidbody2D myRigid;
    private float currentSpeed;
    private ParticleSystem myPart;

    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        myPart = GetComponent<ParticleSystem>();
        currentSpeed = normalSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (myPart != null)
        {
            myPart.Play();
        }

        //spaceship collision
        if (collision.gameObject.name == "Spaceship")
        {
            screenShake shake = Camera.main.GetComponent<screenShake>();
            if (shake != null)
            {
                shake.StartCoroutine(shake.Shaking());  //shakes screen on collisoin
            }

            Destroy(gameObject, 0.2f);  //Destroys collided asteroid in 0.2seconds
        }



        //Asteroid collisions
        if (collision.gameObject.CompareTag("Asteroid"))  //Added "Asteroid" tag to asteroid prefabs in inspector
        {
            Destroy(gameObject, 0.2f);    //Destroys collided asteroid in 0.2seconds

        }
    }

        private void OnCollisionExit2D(Collision2D collision)
        {
         if (myPart != null)
             {
            myPart.Stop();
            }

    }
        void Update()
    {
        bool isBoosting = Input.GetKey(boostKey);
        float targetSpeed = isBoosting ? boostSpeed : normalSpeed;
        float speedChange = isBoosting ? accelerate : decelerate;

        currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, speedChange * Time.deltaTime);

        this.transform.Translate(Vector3.down * currentSpeed * Time.deltaTime, Space.World);
        this.transform.Rotate(new Vector3(0, 0, rotationSpeed));
    }
}
