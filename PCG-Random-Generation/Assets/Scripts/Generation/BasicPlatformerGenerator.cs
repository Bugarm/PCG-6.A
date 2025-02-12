using BasicPlatformer.Settings;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace BasicPlatformer.Generator
{

    public enum TopTileType
    {
        NormalGrass,
        LeftCornerGrass,
        RightCornerGrass,
        Water
    }

    [ExecuteAlways]
    public class BasicPlatformerGenerator : MonoBehaviour
    {
        [Title("Tilemap Generator Settings")]
        [SerializeField]
        private BasicPlatformerSettings settings;

        [SerializeField]
        [Required] private Tilemap groundTilemap;

        private void OnValidate()
        {
            if(groundTilemap == null)
            {
                groundTilemap = GetComponent<Tilemap>();
            }
        }

        [Button("Generate Terrain")]
        public void GenerateTerrain()
        {
            ResetTerrain();

            // PCG Algorithm

            // 1. Randomize Terrain
            int[] height = GenerateHeight();

            // 2. Determine Corner Placement

            // 3. Render the Terrain



        }

        private int[] GenerateHeight()
        {
            int[] heights = new int[settings.Width];

            System.Random rng = new System.Random(settings.Seed);
            int minSurface = settings.MinSurfaceHieght;
            int maxSurface = settings.MaxSurfaceHieght;
            int maxHeightVar = settings.MaxHeightVariation;
            int minSectionWidth = settings.MinSectionWidth;

            int currentHeight = rng.Next(minSurface, maxSurface + 1);

            int i = 0;

            while(i < settings.Width)
            {
                // TODO: Generate the heights
            }

            return heights;
        }

        [Button("Reset Terrain")]
        public void ResetTerrain()
        {
            if(groundTilemap == null )
            {
                Debug.Log("TileMap reference Missing");
                return;
            }
            groundTilemap.ClearAllTiles();

        }

        void Start()
        {
            
        }

        void Update()
        {
            
        }
    }
}