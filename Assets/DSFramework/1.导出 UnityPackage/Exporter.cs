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
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{
    public class Exporter
    {
        //获取文件名
        public static string GeneratePackageName()
        {
            return "DSFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }

#if UNITY_EDITOR
        [MenuItem("DSFramework/1.导出 UnityPackage %e", false, 1)]
        private static void MenuClicked()
        {
            EditorUtil.ExportPackage("Assets/DSFramework", GeneratePackageName() + ".unitypackage");
            EditorUtil.OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }
#endif
    }
}
