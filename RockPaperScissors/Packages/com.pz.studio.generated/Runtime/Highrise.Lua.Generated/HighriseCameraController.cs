/*

    Copyright (c) 2024 Pocketz World. All rights reserved.

    This is a generated file, do not edit!

    Generated by com.pz.studio
*/

#if UNITY_EDITOR

using System;
using System.Linq;
using UnityEngine;
using Highrise.Client;
using Highrise.Studio;
using Highrise.Lua;

namespace Highrise.Lua.Generated
{
    [AddComponentMenu("Lua/HighriseCameraController")]
    [LuaRegisterType(0xe5789da912603c9b, typeof(LuaBehaviour))]
    public class HighriseCameraController : LuaBehaviourThunk
    {
        private const string s_scriptGUID = "75be91cb877f649beb48734ee09ff3bc";
        public override string ScriptGUID => s_scriptGUID;

        [Header("Movement Restrictions")]
        [SerializeField] public System.Boolean m_canPan = true;
        [SerializeField] public System.Boolean m_canRotate = true;
        [SerializeField] public System.Boolean m_canZoom = true;
        [SerializeField] public System.Double m_touchRotationDampener = 0.4;
        [Tooltip("The pivot point that the target will be rotating around and the input plane will spawn at.")]
        [SerializeField] public UnityEngine.Vector3 m_pivot = new Vector3(0f, 0f, 0f);
        [Header("Zoom Settings")]
        [SerializeField] public System.Double m_zoomMin = 10;
        [SerializeField] public System.Double m_zoomMax = 50;
        [Header("Rotation Settings")]
        [SerializeField] public System.Double m_yawOffsetMax = 10;
        [SerializeField] public System.Double m_yawOffsetMin = -10;

        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
                CreateSerializedProperty(_script.GetPropertyAt(0), m_canPan),
                CreateSerializedProperty(_script.GetPropertyAt(1), m_canRotate),
                CreateSerializedProperty(_script.GetPropertyAt(2), m_canZoom),
                CreateSerializedProperty(_script.GetPropertyAt(3), m_touchRotationDampener),
                CreateSerializedProperty(_script.GetPropertyAt(4), m_pivot),
                CreateSerializedProperty(_script.GetPropertyAt(5), m_zoomMin),
                CreateSerializedProperty(_script.GetPropertyAt(6), m_zoomMax),
                CreateSerializedProperty(_script.GetPropertyAt(7), m_yawOffsetMax),
                CreateSerializedProperty(_script.GetPropertyAt(8), m_yawOffsetMin),
            };
        }
    }
}

#endif
