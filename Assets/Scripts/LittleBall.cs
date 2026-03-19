using System;
using TMPro;
using Unity.Cinemachine;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class LittleBall : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float jumpForce = 8f;
    [SerializeField] private float movementForce = 50f;
    
    [Header("checkers")]
    [SerializeField] private LayerMask whatIsInteractable;
    
    [Header("Sfx")]
    [SerializeField] private AudioClip JumpSound;
    
    private TMP_Text scoreText;
    private Rigidbody rb;
    private Vector3 movementDirection;
    
    private int Score = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
        Application.targetFrameRate = 60;
        
    }

    private void OnEnable()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        float hInput =  Input.GetAxis("Horizontal");
        float vInput =  Input.GetAxis("Vertical");
        movementDirection = new Vector3(hInput, 0, vInput).normalized;
        Interact();
        Jump();
        
        
    }

    private void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //if (Physics.Raycast(transform.localPosition, Vector3.forward, out RaycastHit hit, transform.localScale.z + offsetaycast, whatIsInteractable ))
            {
            //    Debug.Log(hit.collider.name);
            }
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, Vector3.down, transform.localScale.y + 0.1f))
            {
                //AudioManager.Instance.PlaySfx(JumpSound);
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }

    //Para ejecutar fisicas cuyo cálculo sea acumulable en el tiempo
    private void FixedUpdate() //cada 0.02 segundos
    {
        rb.AddForce(movementDirection * movementForce, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag<Coin>() != null)
        if (other.gameObject.TryGetComponent(out Coin CoinScript))
        {
            //Coin thisCoin = other.gameObject.GetComponent<Coin>();
            Score += CoinScript.CoinScore;
            UIManager.Instance.ScoreText.SetText($"Score: " + Score);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DestructableObject"))
            {
                Destroy(collision.gameObject);
            }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position + 0.15f * Vector3.forward, 0.05f);
    }
    
}
