using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivar : MonoBehaviour
{
    private float timer = 5f;

    private BoxCollider BC;

    private MeshRenderer mR;
    private bool enEjecucion;
    
    //Con un timer hacer que este gameObject se active y se desactive cada 1.5 segundos
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
    }

    private void Awake()
    {
        //SetActive
        //Cada 1.3 segundo el meshrenderer y el boxcollider cambian su estado
        //si uno esta activaso, el otro desactivado
        // mR = this.gameObject.GetComponent<MeshRenderer>();
        // BC = this.gameObject.GetComponent<BoxCollider>();
        //
        // BC.enabled = false;
        
        //StartCoroutine(Semaforo());
        // StartCoroutine(SwitchState());
    }

    // Update is called once per frame
    // void Update()
    // {
    //     timer += Time.deltaTime;
    //     if (timer >= 1.5f)
    //     {
    //         //activeSelf: Comprueva el estado de activacion
    //         //SetActive: Activa el estado de activacion
    //         mR.enabled = !mR.enabled;
    //         BC.enabled = !BC.enabled;
    //     //this.gameObject.SetActive(!gameObject.activeSelf);
    //     timer = 5f;
    //     }
        //if (Input.GetKeyDown(KeyCode.E) && !enEjecucion)
        //{
        //    StartCoroutine(Semaforo());
        //    Debug.Log("La corrutina termino");
        //}
    //     StartCoroutine(SwitchState());
    // }
    //
    //
    // private IEnumerator SwitchState()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(5f);
    //         mR.enabled = !mR.enabled;}
    // }

    //Corrutina:
    //private IEnumerator Semaforo()
    //{
    //    //enEjecucion = true;
    //    Debug.Log("Verde");
    //    yield return new WaitForSeconds(2f);
    //    Debug.Log("Amarillo");
    //    yield return new WaitForSeconds(1.5f);
    //    Debug.Log("Rojo");
    //    yield return new WaitForSeconds(1f);
    //    //enEjecucion = false;
    //}
}

