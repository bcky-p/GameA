using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     void OnCollisionEnter(Collision coll)
{
foreach(var contact in coll.contacts)
 {
  GameObject collidedObject = contact.otherCollider.gameObject;
  float top = anyValue;
  collidedObject.transform.position.y = top;
  float minX=any,maxX=any;
  collidedObject.transform.position.x = Random.Range(minX,maxX);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
