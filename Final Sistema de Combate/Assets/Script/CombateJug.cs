using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CombateJug : MonoBehaviour
{
    public TextMeshProUGUI huevo;
    // Start is called before the first frame update
    [SerializeField] public float vida;
    
    public void TomarDañoJ (float daño)
    {
        vida -= daño;
        if(vida <= 0)
        {
            Destroy(gameObject);

        }
        huevo.text = "Vida: " + vida;
    }
}
