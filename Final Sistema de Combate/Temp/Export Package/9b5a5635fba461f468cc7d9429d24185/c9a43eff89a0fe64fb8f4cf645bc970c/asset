using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    //Variables
    public float velocidad;
    private Rigidbody2D rigidBody;
    private bool mirandoDerecha = true; //Para que el personaje gire
    private Animator animator;
    public float salto;
    private BoxCollider2D boxCollider;
    public LayerMask suelocap; //Capa para que el boxcollider solo salte cuando toca el suelo
    

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }
   
    void Update()
    {
        ProcesarMovimiento(); //LLama la funcion
        ProcesarSalto();
    }

    bool EstaSuelo()
    {
        //Bounds es para los limites del colisionador
        //EL raycast es como un laser, que sirve para para tener informacion o saber cuando un objeto colisiona con el, todo esto para saber cuando el personaje toca el suelo y no salte infinitas veces
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.2f, suelocap );
        return raycastHit.collider != null;
    }

    void ProcesarSalto()
    {
        //Salto con barra de espacio
        if(Input.GetKeyDown(KeyCode.Space) && EstaSuelo())
        {
            rigidBody.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
        }
    }

    void ProcesarMovimiento()
    {
        //puro movimiento 
        float inputMovimiento = Input.GetAxis("Horizontal");
        

        rigidBody.velocity = new Vector2(inputMovimiento * velocidad, rigidBody.velocity.y);

        GestionarOrientacion(inputMovimiento);

        if(inputMovimiento != 0f) //Para saber cuando el personaje esta quieto o moviendose y ejecutar la animacion
        {
            animator.SetBool("EstaCorriendo", true);
        }
        else
        {
            animator.SetBool("EstaCorriendo", false);
        }
    }

    void GestionarOrientacion(float inputMovimiento)
    {
        //El personaje gira segun la direccion que deseamos
        if ((mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
