// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):            	PreviousFunction.cs
// 作者(Author):                  	Dimitri Wang
// 创建时间(CreateTime):       		2019/10/14 14:51:45
// 邮箱(Emial):						1067163632@qq.com
// 修改者列表(modifier):
// 模块描述(Module description):
// **********************************************************************
using UnityEngine;
using System;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace DSFramework
{




    public class EditorUtil
    {
#if UNITY_EDITOR

        //打开所在文件夹
        public static void OpenInFolder(string folderPath)
        {
            Application.OpenURL("file:///" + folderPath);
        }

        //MenuItem复用
        public static void CallMenuItem(string itemName)
        {
            EditorApplication.ExecuteMenuItem(itemName);
            Application.OpenURL("file:///" + Path.Combine(Application.dataPath, "../"));
        }

        //导出包
        public static void ExportPackage(string assetPathName, string fileName)
        {
            AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
        }

#if UNITY_EDITOR
        [MenuItem("DSFramework/3.MenuItem复用", false, 3)]
        private static void MenuClicked1()
        {
            EditorUtil.CallMenuItem("DSFramework/2.复制文件到剪切板");
        }
#endif
#endif
    }
}
