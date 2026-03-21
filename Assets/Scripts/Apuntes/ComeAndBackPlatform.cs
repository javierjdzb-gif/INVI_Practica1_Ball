using UnityEngine;

public class ComeAndBackPlatform : MonoBehaviour
{
    
    private Rigidbody rb;
    [SerializeField] private Vector3 direction;
    private float timer;
    private int speed = 5;
    private int timerComeAndBackPlatform = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.linearVelocity  = direction * speed; //m/s
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timer += Time.deltaTime;
        if (timer >= timerComeAndBackPlatform)
        {
            direction *= -1;
            rb.linearVelocity = direction * speed;
            timer = 0f;
        }
    }
}
