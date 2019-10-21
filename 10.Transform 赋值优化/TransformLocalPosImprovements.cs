// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             TransformLocalPosImprovements.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/10/19 16:50:38
// 邮箱(Emial):					  1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{
    public class TransformLocalPosImprovements
    {
        #if UNITY_EDITOR
        [MenuItem("DSFramework/10.Transform 赋值优化")]
        #endif
        private static void GenerateUnityPackageName()
        {
            var transform = new GameObject("transform").transform;

            SetLoaclPosX(transform, 5.0f);
            SetLoaclPosY(transform, 5.0f);
            SetLoaclPosZ(transform, 5.0f);
        }

        public static void SetLoaclPosX(Transform transform,float x)
        {
            var localPos = transform.localPosition;
            localPos.x = x;
            transform.localPosition = localPos;
        }

        public static void SetLoaclPosY(Transform transform, float y)
        {
            var localPos = transform.localPosition;
            localPos.y = y;
            transform.localPosition = localPos;
        }

        public static void SetLoaclPosZ(Transform transform, float z)
        {
            var localPos = transform.localPosition;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        public static void SetLoaclPosXY(Transform transform, float x,float y)
        {
            var localPos = transform.localPosition;
            localPos.x = x;
            localPos.y = y;
            transform.localPosition = localPos;
        }

        public static void SetLoaclPosXZ(Transform transform, float x, float z)
        {
            var localPos = transform.localPosition;
            localPos.x = x;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        public static void SetLoaclPosYZ(Transform transform, float y, float z)
        {
            var localPos = transform.localPosition;
            localPos.y = y;
            localPos.z = z;
            transform.localPosition = localPos;
        }
    }
}
