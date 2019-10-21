// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):            	CustomShortCut.cs
// 作者(Author):                  	Dimitri Wang
// 创建时间(CreateTime):       		2019/10/09 17:08:20
// 邮箱(Emial):						1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{
    public class CustomShortCut : MonoBehaviour
    {

#if UNITY_EDITOR
        [MenuItem("DSFramework/7.自定义快捷键 %e")]
        private static void MenuClicked()
        {
            PreviousFunction.ExportPackage("Assets/DSFramework", PreviousFunction.GeneratePackageName() + ".unitypackage");
            PreviousFunction.OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }
#endif

    }
}
