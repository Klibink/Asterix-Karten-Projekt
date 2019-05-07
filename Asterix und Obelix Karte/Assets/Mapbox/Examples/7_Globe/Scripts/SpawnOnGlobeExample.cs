namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.Utilities;
	using Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies;
	using Mapbox.Unity.Map;

	public class SpawnOnGlobeExample : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		[Geocode]
		string[] _locations;

		[SerializeField]
		float _spawnScale = 100f;

		[SerializeField]
		GameObject[] _markerPrefab;

		void Start()
		{
            int i = 0;
			foreach (var locationString in _locations)
			{
				var instance = Instantiate(_markerPrefab[i]);
				var location = Conversions.StringToLatLon(locationString);
				var earthRadius = ((IGlobeTerrainLayer)_map.Terrain).EarthRadius;
				instance.transform.position = Conversions.GeoToWorldGlobePosition(location, earthRadius);
				instance.transform.localScale = Vector3.one * _spawnScale;
				instance.transform.SetParent(transform);
                i++;

                //Debug.Log(i);
			}
		}
	}
}