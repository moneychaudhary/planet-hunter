using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{  
    public Text goalText;
    List<string> planetNames = new List<string>{
    "MERCURY",
    "VENUS",
    "EARTH",
    "MARS",
    "JUPITER",
    "SATURN",
    "URANUS",
    "NEPTUNE"
    };
    string currentGoal;
    // Start is called before the first frame update
    void Start()
    {
        SetGoal();
    }

    // Update is called once per frame
    void Update()
    { 
      goalText.text = currentGoal;
    }
     
    void SetGoal()
    {
     int randomIndex = Random.Range(0, planetNames.Count);
     currentGoal = planetNames[randomIndex];
     planetNames.RemoveAt(randomIndex);
    }

    void Shot(string alphabet) {
      Debug.Log(alphabet);
    }
}
