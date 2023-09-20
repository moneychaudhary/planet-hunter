using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{	
    public float speed = 10f;
    public GoalScript goalScript;
    // Start is called before the first frame update
    void Awake() {
        goalScript = GameObject.Find("Goal").GetComponent<GoalScript>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.tag == "Alphabet") 
      {
        Destroy(gameObject);
        goalScript.Shot(collision.gameObject.transform.name[0]);
      }
    }
}
