using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class igloo : MonoBehaviour
{
   /*
   Igloo class attached to the igloo object.
    
   A Raycast is implemented in the Update() function
   to check if the igloo object has been tapped.
   (The raycast is projectd from the camera at 
   touch position and forwards (down z), this script detects
   if ray hits igloos collider). 
   
   Upon being detected by the raycast, the igloo functions
   as a button to (trigger animations) open the igloopanel 
   which displays the empires stats. 
   
   @author Sasha Buskin
   
   */

    public Canvas canvas;
    public Animator animator;
   
    void Start()
    {
        
        animator = canvas.GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            print(hit.collider);
            
            if (hit.collider != null ){
                 
                print("okfosar((((-----------------------------");
                Debug.Log( hit.collider.name );
                   
                    if (hit.collider.gameObject.GetComponent<igloo>()){
                    
                        animator.SetBool("OpenIgloo", true);            
                    }
             }  
               
            Vector3 mousePosition = Input.mousePosition;
            print(mousePosition);
        }
        
    }
    public void iglooXButt()
    {
       animator.SetBool("OpenIgloo", false);
    }
}
          
              
            
            




































            
               /*if 
         if (Input.GetMouseButtonDown(0))
         {
             
                 Ray touchposition = Camera.main.ScreenPointToRay(Input.mousePosition);
                 RaycastHit2D hit = Physics2D.GetRayIntersection(touchposition);
                  Debug.DrawRay(Input.mousePosition, transform.forward, Color.red, Mathf.Infinity);
                 if (hit.collider)
                 {
                     Debug.Log(hit.transform.name);
  Debug.DrawRay(Input.mousePosition, transform.forward, Color.red, Mathf.Infinity);
                 }  
                     
                     RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, 0))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Did Hit");
        }
                }     Vector3 point = cam.ScreenToWorldPoint(Input.mousePosition);
                       
                        ray = new Ray(point, transform.forward);
                        print(Physics.Raycast(ray, out hit));
                         */
            
            
            /* if (Input.GetMouseButtonDown(0))
        {
            
            Debug.Log("click");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.DrawRay(mousePos, transform.forward, Color.red, Mathf.Infinity);
            
            print(Physics.Raycast(mousePos, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, 0));
            if (Physics.Raycast(mousePos, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, 0))
        {
            Debug.DrawRay(mousePos, transform.forward, Color.red, Mathf.Infinity);
            Debug.Log("Did Hit");
        }
        }
                         if (Physics.Raycast(ray, out hit) && hit.transform.tag == "igloo"){
            
                       print("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH");
                         }
                         else{
                            print("NNNNNNNNNNNNNN");
                         }*/
                         
                              



