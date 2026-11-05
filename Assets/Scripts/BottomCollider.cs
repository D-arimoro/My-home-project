using UnityEngine;

//Created bottom barrier
public class BottomCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);     //Destroyes asteroids when they touch the "bottom collider"
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
