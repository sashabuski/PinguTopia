using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RcPopup : MonoBehaviour
{
    public Canvas canvas;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = canvas.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            print(hit.collider);
            
            if (hit.collider != null )
            {   
                print("okfosar((((-----------------------------");
                Debug.Log( hit.collider.name );
                   
                    if (hit.collider.gameObject.GetComponent<RcPopup>())
                    {
                        animator.SetBool("testbool", true);            
                    }
            }     
            Vector3 mousePosition = Input.mousePosition;
            print(mousePosition);
        }
    }

    public void YesButt(){
        animator.SetBool("testbool", true);
    }

    public void NoButt()
    {
       animator.SetBool("testbool", false);
    }
}
