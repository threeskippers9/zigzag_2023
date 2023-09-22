using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject diamondPrefab;
    [SerializeField] [Range(10, 25)] int maxNumberPlatforms = 25;
    [SerializeField][Range(0f, 1f)] float spawnRate = .3f;


    Vector3 nextSpawnPosition = new Vector3(4f, .375f, 4f);
    private int numberPlatforms;

 

    // Update is called once per frame
    void Update()
    {
        if(numberPlatforms < maxNumberPlatforms)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        int num = Random.Range(0, 2);
        if (num == 0)
        {
            nextSpawnPosition += new Vector3(0f, 0f, 2f);
        }
        else
        {
            nextSpawnPosition += new Vector3(2f, 0f, 0f);
        }
        numberPlatforms++;
        GameObject go = Instantiate(platformPrefab);
        go.transform.position = nextSpawnPosition;

        // check to see if we need to spawn a diamond
        if(Random.Range(0f,1f) < spawnRate)
        {
            print("hello");
            GameObject diamond = Instantiate(diamondPrefab);
            diamond.transform.parent = go.transform;
            diamond.transform.localPosition = new Vector3(0f, .65f, 0f);
        }
    }

    public void DecreaseNumberPlatforms() 
    {
        numberPlatforms--;
    }
}

