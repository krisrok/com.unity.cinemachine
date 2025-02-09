using UnityEditor;
using UnityEngine;

namespace Cinemachine.Editor
{
    [CustomEditor(typeof(CinemachineHardLookAt))]
    [CanEditMultipleObjects]
    internal sealed class CinemachineHardLookAtEditor : BaseEditor<CinemachineHardLookAt>
    {
        public override void OnInspectorGUI()
        {
            BeginInspector();
            bool needWarning = false;
            for (int i = 0; !needWarning && i < targets.Length; ++i)
                needWarning = (targets[i] as CinemachineHardLookAt).LookAtTarget == null;
            if (needWarning)
                EditorGUILayout.HelpBox(
                    "Hard Look At requires a Tracking target.  Change Rotation Control to None if you don't want a Tracking or LookAt target.", 
                    MessageType.Warning);
            EditorGUI.BeginChangeCheck();
            GUI.enabled = false;
            EditorGUILayout.LabelField(" ", "No additional settings", EditorStyles.miniLabel);
            GUI.enabled = true;
            DrawRemainingPropertiesInInspector();
        }
    }
}
