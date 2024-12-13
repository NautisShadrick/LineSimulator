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
    [CreateAssetMenu(menuName = "Highrise/ScriptableObjects/ItemUITemplate")]
    [LuaRegisterType(0x8277969b6d82d10a, typeof(LuaScriptableObject))]
    public class ItemUITemplate : LuaScriptableObjectThunk
    {
        private const string s_scriptGUID = "475196c2905476841b34b4cc6e015986";
        public override string ScriptGUID => s_scriptGUID;

        [SerializeField] public System.String m_Title = "";
        [SerializeField] public System.String m_Description = "";
        [SerializeField] public System.Double m_Price = 0;
        [SerializeField] public System.String m_IconID = "";
        [SerializeField] public System.String m_ActionID = "";

        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
                CreateSerializedProperty(_script.GetPropertyAt(0), m_Title),
                CreateSerializedProperty(_script.GetPropertyAt(1), m_Description),
                CreateSerializedProperty(_script.GetPropertyAt(2), m_Price),
                CreateSerializedProperty(_script.GetPropertyAt(3), m_IconID),
                CreateSerializedProperty(_script.GetPropertyAt(4), m_ActionID),
            };
        }
    }
}

#endif
