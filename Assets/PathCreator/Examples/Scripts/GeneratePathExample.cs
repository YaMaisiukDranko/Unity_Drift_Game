using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace PathCreation.Examples {
    // Example of creating a path at runtime from a set of points.

    [RequireComponent(typeof(PathCreator))]
    public class GeneratePathExample : MonoBehaviour {
        public Scrollbar scrollbar;

        public bool closedLoop = true;

        public int WaypointsCount;
        public float MinDistance;
        public float MaxDistance;

        private Transform[] waypoints;

        private RoadMeshCreator _roadMeshCreator;
        private void Start()
        {
            scrollbar.onValueChanged.AddListener((float val) => ChangeValue(val));
            _roadMeshCreator = GetComponent<RoadMeshCreator>();
            GenerateNewPath();
        }

        private IEnumerator GenerateNewPath_Coroutine()
        {
            yield return null;
            if (null != waypoints)
            {
                foreach (var point in waypoints)
                {
                    Destroy(point.gameObject);
                }
            }

            waypoints = new Transform[WaypointsCount];
            var step = 720 / WaypointsCount;
            for (int i = 0; i < WaypointsCount; i++)
            {
                var randomDistance = Random.Range(MinDistance, MaxDistance);
                Quaternion newRotation = Quaternion.Euler(i * step, 0, 0);
                var randPosition = new Vector3(newRotation.x * randomDistance, 0, newRotation.w * randomDistance);

                Transform trans = new GameObject().transform;
                trans.position = randPosition;
                waypoints[i] = trans;
            }

            BezierPath bezierPath = new BezierPath(waypoints, closedLoop, PathSpace.xz);
            GetComponent<PathCreator>().bezierPath = bezierPath;
            _roadMeshCreator.TriggerUpdate();
        }

        //Used by button
        public void GenerateNewPath()
        {
            StartCoroutine(GenerateNewPath_Coroutine());
        }

        public void ChangeValue(float newValue)
        {    
            WaypointsCount = (int)(20 + newValue * 30);
            GenerateNewPath();
        }
    }
}