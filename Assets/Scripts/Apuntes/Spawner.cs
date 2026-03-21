using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject bolitaPrefab;
    [SerializeField] private float timerBetweenSpawns;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LaunchBall();
    }

    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timerBetweenSpawns)
        {
            GameObject copy = Instantiate(bolitaPrefab, transform.position, Quaternion.identity);
            Destroy(copy, 3f);
            timer = 0f;
        }
    }
    private void LaunchBall()
         {
             GameObject copy = Instantiate(bolitaPrefab, transform.position, Quaternion.identity);
             copy.GetComponent<Rigidbody>().AddForce(Vector3.forward * Random.Range(5f, 15f));
             Destroy(copy, 3f);
         }
}
