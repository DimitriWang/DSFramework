// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             SpriteTitleChange.cs 
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):           2017/1/7 15:34:45
// 修改者列表(modifier):
// 模块描述(Module description):   创建脚本自动修改文件名、作者、创建时间
// **********************************************************************
using UnityEngine;
using System.Collections;
using System.IO;

public class SpriteTitleChange : UnityEditor.AssetModificationProcessor
{
    private const string AuthorName = "Dimitri Wang";
    private const string AuthorEmail = "1067163632@qq.com";

    private const string DateFormat = "yyyy/MM/dd HH:mm:ss";

    private static void OnWillCreateAsset(string path)
    {

        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs"))
        {
            string allText = File.ReadAllText(path);
            allText = allText.Replace("#AuthorName#", AuthorName);
            allText = allText.Replace("#AuthorEmail#", AuthorEmail);
            allText = allText.Replace("#CreateTime#", System.DateTime.Now.ToString(DateFormat));
            File.WriteAllText(path, allText);
            UnityEditor.AssetDatabase.Refresh();
        }

    }
}