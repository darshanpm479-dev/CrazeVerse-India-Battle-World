using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CrazeVerseOneClickBuilder
{
    private const string RootFolder = "Assets/CrazeVerse";
    private const string ScenesFolder = "Assets/CrazeVerse/Scenes";
    private const string MaterialsFolder = "Assets/CrazeVerse/Materials";
    private const string ScenePath = "Assets/CrazeVerse/Scenes/TrainingGroundScene.unity";

    [MenuItem("CrazeVerse/Build Full Training Ground Scene")]
    public static void BuildFullTrainingGroundScene()
    {
        CreateFolders();

        Scene scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        scene.name = "TrainingGroundScene";

        Material groundMat = CreateMaterial("MAT_Ground_Dark", new Color(0.18f, 0.20f, 0.22f));
        Material moveMat = CreateMaterial("MAT_MovementZone_Blue", new Color(0.10f, 0.45f, 1.00f));
        Material aimMat = CreateMaterial("MAT_AimZone_Orange", new Color(1.00f, 0.45f, 0.05f));
        Material scanMat = CreateMaterial("MAT_ScannerZone_Purple", new Color(0.55f, 0.25f, 1.00f));
        Material safeMat = CreateMaterial("MAT_SafeZone_Green", new Color(0.10f, 0.85f, 0.35f));
        Material playerMat = CreateMaterial("MAT_Player_Gold", new Color(1.00f, 0.75f, 0.15f));
        Material markerMat = CreateMaterial("MAT_Label_White", new Color(0.92f, 0.92f, 0.92f));

        GameObject systems = CreateEmpty("Systems");
        GameObject trainingSetup = CreateEmpty("TrainingSetup");
        GameObject playerPreview = CreateEmpty("PlayerPreview");
        GameObject combatPreview = CreateEmpty("CombatPreview");
        GameObject cameraRig = CreateEmpty("CameraRig");
        GameObject spawnPoints = CreateEmpty("SpawnPoints");
        GameObject environment = CreateEmpty("EnvironmentBlockout");

        CreatePlane("Ground_Placeholder", environment.transform, Vector3.zero, new Vector3(5f, 1f, 5f), groundMat);

        CreateZone("MovementZone_Placeholder", environment.transform, new Vector3(-8f, 0.05f, 0f), moveMat);
        CreateZone("AimZone_Placeholder", environment.transform, new Vector3(0f, 0.05f, 0f), aimMat);
        CreateZone("ScannerZone_Placeholder", environment.transform, new Vector3(8f, 0.05f, 0f), scanMat);
        CreateZone("SafeZone_Placeholder", environment.transform, new Vector3(0f, 0.05f, 8f), safeMat);

        CreatePlayerPlaceholder(playerPreview.transform, playerMat);
        CreateSpawnPoint(spawnPoints.transform);
        CreateCamera(cameraRig.transform);
        CreateLight();
        CreateLabelObjects(trainingSetup.transform, markerMat);

        EditorSceneManager.SaveScene(scene, ScenePath);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log("CrazeVerse TrainingGroundScene created successfully at: " + ScenePath);
    }

    private static void CreateFolders()
    {
        CreateFolderIfMissing("Assets", "CrazeVerse");
        CreateFolderIfMissing(RootFolder, "Scenes");
        CreateFolderIfMissing(RootFolder, "Materials");
        CreateFolderIfMissing(RootFolder, "Prefabs");
        CreateFolderIfMissing(RootFolder, "Scripts");
        CreateFolderIfMissing(RootFolder, "Docs");
    }

    private static void CreateFolderIfMissing(string parent, string child)
    {
        string fullPath = parent + "/" + child;
        if (!AssetDatabase.IsValidFolder(fullPath))
        {
            AssetDatabase.CreateFolder(parent, child);
        }
    }

    private static GameObject CreateEmpty(string name)
    {
        GameObject obj = new GameObject(name);
        obj.transform.position = Vector3.zero;
        return obj;
    }

    private static Material CreateMaterial(string materialName, Color color)
    {
        string path = MaterialsFolder + "/" + materialName + ".mat";

        Material existing = AssetDatabase.LoadAssetAtPath<Material>(path);
        if (existing != null)
        {
            existing.color = color;
            EditorUtility.SetDirty(existing);
            return existing;
        }

        Shader shader = Shader.Find("Universal Render Pipeline/Lit");
        if (shader == null)
        {
            shader = Shader.Find("Standard");
        }

        Material mat = new Material(shader);
        mat.name = materialName;
        mat.color = color;

        AssetDatabase.CreateAsset(mat, path);
        return mat;
    }

    private static void CreatePlane(string name, Transform parent, Vector3 position, Vector3 scale, Material material)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Plane);
        obj.name = name;
        obj.transform.SetParent(parent);
        obj.transform.position = position;
        obj.transform.rotation = Quaternion.identity;
        obj.transform.localScale = scale;
        ApplyMaterial(obj, material);
    }

    private static void CreateZone(string name, Transform parent, Vector3 position, Material material)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = name;
        obj.transform.SetParent(parent);
        obj.transform.position = position;
        obj.transform.rotation = Quaternion.identity;
        obj.transform.localScale = new Vector3(4f, 0.1f, 4f);
        ApplyMaterial(obj, material);
    }

    private static void CreatePlayerPlaceholder(Transform parent, Material material)
    {
        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        player.name = "Player_Placeholder";
        player.transform.SetParent(parent);
        player.transform.position = new Vector3(0f, 1f, -6f);
        player.transform.localScale = new Vector3(1f, 1f, 1f);
        ApplyMaterial(player, material);

        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        head.name = "Player_Head_Placeholder";
        head.transform.SetParent(player.transform);
        head.transform.localPosition = new Vector3(0f, 1.1f, 0f);
        head.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
        ApplyMaterial(head, material);
    }

    private static void CreateSpawnPoint(Transform parent)
    {
        GameObject spawn = new GameObject("PlayerSpawnPoint_01");
        spawn.transform.SetParent(parent);
        spawn.transform.position = new Vector3(0f, 0f, -6f);
    }

    private static void CreateCamera(Transform parent)
    {
        GameObject cameraObj = new GameObject("Main Camera");
        cameraObj.transform.SetParent(parent);
        cameraObj.transform.position = new Vector3(0f, 7f, -14f);
        cameraObj.transform.rotation = Quaternion.Euler(28f, 0f, 0f);

        Camera camera = cameraObj.AddComponent<Camera>();
        cameraObj.tag = "MainCamera";
        camera.clearFlags = CameraClearFlags.Skybox;
        camera.fieldOfView = 60f;
    }

    private static void CreateLight()
    {
        GameObject lightObj = new GameObject("Directional Light");
        lightObj.transform.rotation = Quaternion.Euler(50f, -30f, 0f);

        Light light = lightObj.AddComponent<Light>();
        light.type = LightType.Directional;
        light.intensity = 1.25f;
    }

    private static void CreateLabelObjects(Transform parent, Material material)
    {
        CreateMarker(parent, "Training_Label_Movement", new Vector3(-8f, 0.5f, 2.7f), material);
        CreateMarker(parent, "Training_Label_Aim", new Vector3(0f, 0.5f, 2.7f), material);
        CreateMarker(parent, "Training_Label_Scanner", new Vector3(8f, 0.5f, 2.7f), material);
        CreateMarker(parent, "Training_Label_SafeZone", new Vector3(0f, 0.5f, 10.7f), material);
    }

    private static void CreateMarker(Transform parent, string name, Vector3 position, Material material)
    {
        GameObject marker = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        marker.name = name;
        marker.transform.SetParent(parent);
        marker.transform.position = position;
        marker.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
        ApplyMaterial(marker, material);
    }

    private static void ApplyMaterial(GameObject obj, Material material)
    {
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.sharedMaterial = material;
        }
    }
}
