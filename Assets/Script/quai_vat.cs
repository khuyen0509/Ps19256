using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quai_vat : MonoBehaviour
{
    bool gioi_han_trai;
    bool gioi_han_phai;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gioi_han_trai)
        {
            transform.Translate(Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-Time.deltaTime, 0, 0);
        }

        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gioi_han_trai")
        {
            gioi_han_trai = true;
        }

        if (collision.gameObject.tag == "gioi_han_phai")
        {
            gioi_han_trai = false;
        }

    }
}
