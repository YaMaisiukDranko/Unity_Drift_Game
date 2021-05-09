using PathCreation;
using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Car;
    public PathCreator PathCreator;
    public void StartGame()
    {
        Car.transform.position = PathCreator.bezierPath.GetPoint(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
