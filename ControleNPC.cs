using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleNPC : MonoBehaviour
{
    private Vector3 target;
    private float speed = 10.0F;

    // Start is called before the first frame update
    void Start()
    {
        novaDirecao();    
    }

    void novaDirecao(){
        target = new Vector3(Random.Range(-100,100), 0, Random.Range(-100,100));
        transform.rotation = Quaternion.LookRotation(target);
    }

    // Update is called once per frame
    void Update()
    {
      float step = speed * Time.deltaTime;
      transform.position = Vector3.MoveTowards(transform.position, target, step);  
      if (transform.position == target) {
        novaDirecao();
      }
    }

    void OnCollisionEnter(Collision collision) {
        novaDirecao();
    }
}
