using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace BasicPlatformer.Settings
{
    [System.Serializable]
    public class BasicPlatformerSettings
    {
        //---------Fixed Constraints--------------------//
        [FoldoutGroup("Fixed Constrains")]
        [Tooltip("Seed for the rng")]
        [SerializeField]
        private int seed = 0;

        [FoldoutGroup("Fixed Constrains")]
        [Tooltip("Width of generation level in tiles")]
        [SerializeField]
        private int width = 50;

        [FoldoutGroup("Fixed Constrains")]
        [Tooltip("Number of dirt layers below the top tile")]
        [SerializeField]
        private int dirtDepth = 5;

        [FoldoutGroup("Fixed Constrains")]
        [Tooltip("Fill the sky background from the terrain up to the highest grass tile.")]
        [SerializeField]
        private int skyBackgroundFillExtra = 20;

        //---------Randomized Constraints---------------//
        [FoldoutGroup("Randomized Constrains")]
        [Tooltip("Minimum surface height (y pos) for the top tiles")]
        [SerializeField]
        private int minSurfaceHieght = 5;

        [FoldoutGroup("Randomized Constrainss")]
        [Tooltip("Maximum surface height (y pos) for the top tiles")]
        [SerializeField]
        private int maxSurfaceHieght = 10;

        [FoldoutGroup("Randomized Constrains")]
        [Tooltip("Minimum width (in cols) of each section")]
        [SerializeField]
        private int minSectionWidth = 3;

        [FoldoutGroup("Randomized Constrains")]
        [Tooltip("Maximum height variation between sections")]
        [SerializeField]
        private int maxHeightVariation = 2;

        [FoldoutGroup("Randomized Constrains")]
        [Tooltip("When cheching for an adjacent call. The maximum vartical difference allowed to collider the neigbour as filled")]
        [SerializeField]
        private int adjecentToTolerance = 1;

        [FoldoutGroup("Randomized Constrains")]
        [Tooltip("Probability that a water section spawns in each eligible black of 50 cells")]
        [SerializeField]
        private float waterSpawnChange = 0.4f;

        //--------------------------Tile References---------------------
        [FoldoutGroup("Tile References")]
        [Required]
        [Tooltip("Tile used for grass top")]
        [SerializeField]
        private TileBase grassTile;

        [FoldoutGroup("Tile References")]
        [Required]
        [Tooltip("Tile used for dirt beneath the grass")]
        [SerializeField]
        private TileBase dirtTile;

        [FoldoutGroup("Tile References")]
        [Required]
        [Tooltip("Tile used for grass top left corner")]
        [SerializeField]
        private TileBase grassLeftTile;

        [FoldoutGroup("Tile References")]
        [Required]
        [Tooltip("Tile used for grass top right corner")]
        [SerializeField]
        private TileBase grassRightTile;

        [FoldoutGroup("Tile References")]
        [Required]
        [Tooltip("Tile used for water")]
        [SerializeField]
        private TileBase waterTile;

        [FoldoutGroup("Tile References")]
        [Required]
        [Tooltip("Tile used for the sky background")]
        [SerializeField]
        private TileBase skyTile;

        public int Seed { get => seed; set => seed = value; }
        public int Width { get => width; set => width = value; }
        public int DirtDepth { get => dirtDepth; set => dirtDepth = value; }
        public int SkyBackgroundFillExtra { get => skyBackgroundFillExtra; set => skyBackgroundFillExtra = value; }
        public int MinSurfaceHieght { get => minSurfaceHieght; set => minSurfaceHieght = value; }
        public int MaxSurfaceHieght { get => maxSurfaceHieght; set => maxSurfaceHieght = value; }
        public int MinSectionWidth { get => minSectionWidth; set => minSectionWidth = value; }
        public int MaxHeightVariation { get => maxHeightVariation; set => maxHeightVariation = value; }
        public int AdjecentToTolerance { get => adjecentToTolerance; set => adjecentToTolerance = value; }
        public float WaterSpawnChange { get => waterSpawnChange; set => waterSpawnChange = value; }
        public TileBase GrassTile { get => grassTile; set => grassTile = value; }
        public TileBase DirtTile { get => dirtTile; set => dirtTile = value; }
        public TileBase GrassLeftTile { get => grassLeftTile; set => grassLeftTile = value; }
        public TileBase GrassRightTile { get => grassRightTile; set => grassRightTile = value; }
        public TileBase WaterTile { get => waterTile; set => waterTile = value; }
        public TileBase SkyTile { get => skyTile; set => skyTile = value; }
    }

}