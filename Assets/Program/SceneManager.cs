using UnityEngine;
using System.Collections;

namespace Assets.Program
{

    public class SceneManager : MonoBehaviour
    {
        GameObject Map;
        GameObject Hero;
        GameObject Canvas;
        // Use this for initialization
        void Start()
        {
            InitMap();
            InitHero();
            InitCanvas();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void InitMap()
        {
            Map = Instantiate(Resources.Load("Map")) as GameObject;
            Map.transform.position=new Vector3(-constants.mapW/2,-constants.mapH/2-1);
            Map.name = "Map";
        }

        void InitHero()
        {
            Hero = Instantiate(Resources.Load("Hero")) as GameObject;
            Hero.name = "Hero";
            Hero.GetComponent<AI.AIModule>().ID = constants.heroID;
        }

        void InitCanvas()
        {
            Canvas = Instantiate(Resources.Load("Canvas")) as GameObject;
            Canvas.name = "Canvas";
        }
    }
}