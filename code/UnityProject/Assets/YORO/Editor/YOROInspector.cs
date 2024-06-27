using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(YORO))]
public class YOROInspector : Editor {
    private YORO _yoro;

    SerializedProperty Mode;
    SerializedProperty ReprojectionScale;
    SerializedProperty Patcher;

    void OnEnable() {
        if (target == null) return;
        _yoro = (YORO)target;
        _yoro.YOROPerformanceShader = Shader.Find("Hidden/YOROPerformance");
        _yoro.YOROQualityShader = Shader.Find("Hidden/YOROQuality");
        var guid = AssetDatabase.FindAssets("YORO t:ComputeShader").
            Single(guid => AssetDatabase.GUIDToAssetPath(guid).Contains("YORO.compute"));
        _yoro.YOROComputeShader = AssetDatabase.LoadAssetAtPath<ComputeShader>(AssetDatabase.GUIDToAssetPath(guid));

        Mode = serializedObject.FindProperty("Mode");
        ReprojectionScale = serializedObject.FindProperty("ReprojectionScale");
        Patcher = serializedObject.FindProperty("Patcher");
    }

    public override void OnInspectorGUI() {
        int prevMode = Mode.intValue;
        EditorGUILayout.PropertyField(Mode, new GUIContent("Mode"));
        if (Mode.intValue != prevMode) _yoro.Mode = (YOROMode)Mode.intValue;

        if (_yoro.Mode == YOROMode.Performance) {
            int prevScale = ReprojectionScale.intValue;
            EditorGUILayout.PropertyField(ReprojectionScale, new GUIContent("Reprojection Scale"));
            if (ReprojectionScale.intValue != prevScale) _yoro.ReprojectionScale = (YOROScale)ReprojectionScale.intValue;

            int prevPatcher = Patcher.intValue;
            EditorGUILayout.PropertyField(Patcher, new GUIContent("Patcher"));
            if (Patcher.intValue != prevPatcher) _yoro.Patcher = (YOROPerformancePatcher)Patcher.intValue;
        }
    }
}
