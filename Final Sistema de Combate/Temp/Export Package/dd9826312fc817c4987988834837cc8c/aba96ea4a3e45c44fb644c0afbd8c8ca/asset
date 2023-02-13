using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;

    private Animator animator;
    public Rigidbody2D rb2d;
    public Transform jugador;
    public float velocidadEnemigo = 1f;
    public Transform plater;

    private bool mirandoderecha = true;

    [Header("ataque")]
    [SerializeField] private Transform controladorAtaq;
    [SerializeField] private float radioAt;
    [SerializeField] private float dañoAt;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        if(vida <= 0)
        {
            Muerte();
        }
    }
    private void Muerte()
    {
        animator.SetTrigger("Muerte");
        Destroy(gameObject);
    }
    public void MirarJugador()
    {
        if((jugador.position.x> transform.position.x && !mirandoderecha) || (jugador.position.x < transform.position.x && mirandoderecha))
        {
            mirandoderecha = !mirandoderecha;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        }
    }

    private void Update()
    {
        float distanciajug = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("distanciajug", distanciajug);
    }
    void Updatee()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(plater.position.x, transform.position.y), velocidadEnemigo * Time.deltaTime);
    }

    private void Ataque()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorAtaq.position, radioAt);

        foreach(Collider2D collision in objetos)
        {
            if (collision.CompareTag("player"))
            {
                collision.GetComponent<CombateJug>().TomarDañoJ(dañoAt);
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorAtaq.position, radioAt);
    }
}
