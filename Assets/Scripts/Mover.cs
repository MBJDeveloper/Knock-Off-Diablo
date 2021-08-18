using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }

        UpdateAnimation();
    }

    private void MoveToCursor(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hashit = Physics.Raycast(ray, out hit);

        if (hashit == true){
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
        
    }

    private void UpdateAnimation(){
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;

        GetComponent<Animator>().SetFloat("forwardSpeed", speed);
    }
}
