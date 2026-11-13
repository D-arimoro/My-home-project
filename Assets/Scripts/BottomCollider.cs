using UnityEngine;

//Created bottom barrier
public class BottomCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject, 1f);     //Destroyes asteroids when they touch the "bottom collider after 1 second"
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
