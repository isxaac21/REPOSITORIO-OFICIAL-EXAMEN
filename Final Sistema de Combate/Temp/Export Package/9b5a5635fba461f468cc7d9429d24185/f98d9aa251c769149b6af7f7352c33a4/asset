using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    [SerializeField] private Transform Golpe;
    [SerializeField] private float radio;
    [SerializeField] private float dañoGolpe;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GolpeC();
        }
    }
    private void GolpeC()
    {
        animator.SetTrigger("Golpe");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(Golpe.position, radio);
    foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(dañoGolpe);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(Golpe.position, radio);
    }

    // Start is called before the first frame update
   
  

    // Update is called once per frame
   
}
