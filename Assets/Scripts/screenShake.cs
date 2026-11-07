using System.Collections;
using UnityEngine;

public class screenShake : MonoBehaviour
{
    //public bool start = false;
    public float duration = 1f; //preset shake duration
    public AnimationCurve curve;

    public IEnumerator Shaking() //method
    {
        Vector3 startPosition = transform.position; //camera start position
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength; // moves the camera axis in random positions.
            yield return null;
        }

        transform.position = startPosition; // returns to camera start position.
    }
}