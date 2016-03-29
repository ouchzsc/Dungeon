using UnityEngine;
using System.Collections;

namespace Assets.Program
{

    public class SceneManager : MonoBehaviour
    {
        GameObject Map;
        GameObject Hero;

        // Use this for initialization
        void Start()
        {
            InitMap();
            InitHero();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void InitMap()
        {
            Map = Instantiate(Resources.Load("Map")) as GameObject;
            Map.transform.position=new Vector3(-constants.mapW/2,-constants.mapH/2-1);
        }

        void InitHero()
        {
            Hero = Instantiate(Resources.Load("Hero")) as GameObject;
        }
    }
}