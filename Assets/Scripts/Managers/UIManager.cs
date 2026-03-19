using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //1. existe sólo una unica instancia de esta clase.
    //2. es accesible desde cualquier desde cualquier punto del programa (script)

    //Un campo automaticamente encapsulado y esta serializado (se ve en Unity)
    [field: SerializeField] public TMP_Text keyText { get; private set; }

    //Instance: Trono
    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            
            //aquel que reclama el trono no se destruye entre escenas.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
           SceneManager.LoadScene("Ejemplo"); 
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
