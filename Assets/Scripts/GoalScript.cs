using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{  
    public Text goalText;
    public Text remainingText;
    List<string> planetNames = new List<string>{
    "EARTH",
    "MARS",
//    "JUPITER",
//    "SATURN",
//    "URANUS",
//    "NEPTUNE",
//    "MERCURY",
//    "VENUS",
    };
    string currentGoal;
    string remainingGoal;
    string[] killedAlphabets;
    Dictionary<char, int> goalWordCount = new Dictionary<char, int>();
    // Start is called before the first frame update
    void Start()
    {
        SetGoal();
    }

    // Update is called once per frame
    void Update()
    { 
      goalText.text = currentGoal;
      remainingText.text = remainingGoal;
    }
     
    void SetGoal()
    {
         if (planetNames.Count == 0) {
            // Game Finished
         }
         int randomIndex = Random.Range(0, planetNames.Count);
         currentGoal = planetNames[randomIndex];
         remainingGoal = currentGoal;
         planetNames.RemoveAt(randomIndex);
         foreach (char letter in currentGoal){
            if (goalWordCount.ContainsKey(letter)){
                goalWordCount[letter]++;
            } else {
                goalWordCount[letter] = 1;
            }
         }
    }

    public void Shot(char alphabet) {
      Debug.Log(alphabet);
      if (goalWordCount.ContainsKey(alphabet)) {
         if (goalWordCount[alphabet] == 1) {
            goalWordCount.Remove(alphabet);
         }
         else {
            goalWordCount[alphabet]--;
         }
         int indexOfChar = remainingGoal.IndexOf(alphabet);
         if (indexOfChar >= 0)
         {
           remainingGoal = remainingGoal.Substring(0, indexOfChar) + "  " + remainingGoal.Substring(indexOfChar + 1);
         }
         if (goalWordCount.Count == 0) {
            SetGoal();
         }
      }
    }
}
