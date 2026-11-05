using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public GameObject prefab;
    public int howMany;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject tmpAsteroid;
        AsteroidMove am;

        for (int i=0; i < howMany; i++)
        {
            tmpAsteroid = Instantiate(prefab,
                                               new Vector3(Random.Range(-7, 7),
                                                           Random.Range(2, 170),
                                                           0),
                                                Quaternion.identity);

            am = tmpAsteroid.GetComponent<AsteroidMove>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
