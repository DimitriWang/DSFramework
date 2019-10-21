// **********************************************************************
// Copyright (C) 2017 The company name
//
// 文件名(File Name):             UICodeGenerator.cs
// 作者(Author):                  Dimitri Wang
// 创建时间(CreateTime):          2019/04/04 13:23:15
// 修改者列表(modifier):
// 模块描述(Module description):  创建脚本管理器
// **********************************************************************
using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;
using System;
using System.IO;
using System.Reflection;

public enum ScriptCreateType {
    /// <summary>
    /// UI界面
    /// </summary>
    UI,
    /// <summary>
    /// 动物
    /// </summary>
    Animal,
    /// <summary>
    /// 玩家模型
    /// </summary>
    PlayerModel,
    /// <summary>
    /// 玩家控制器
    /// </summary>
    PlayerControl,
    /// <summary>
    /// 背包
    /// </summary>
    KnapSack,
    ModelEdit,
    ModelStyle,
    /// <summary>
    /// 单例管理类
    /// </summary>
    GameManager,
}

public enum FieldType
{
    Int,
    Float,
    String,

}

public class UICodeGenerator : EditorWindow {
    
    ScriptCreateType scriptType = ScriptCreateType.Animal;

    string scriptname;

    List<FieldType> options = new List<FieldType>();
    List<string> targetlist = new List<string>();
    Vector2 v2 = new Vector2(0, 0);

    [MenuItem("Manager/CreateCSharp")]
    static void CreateWindow() {
        UICodeGenerator window = EditorWindow.GetWindow<UICodeGenerator>("脚本创建工具");
        window.Show();
    }

    private void OnGUI()
    {
        scriptType = (ScriptCreateType)EditorGUILayout.EnumPopup("ScriptCreateType", scriptType);
        GUILayout.Space(10);
        #region 简介

        GUILayout.Label("创建脚本工具");
        GUILayout.Label("命名规则： 禁止使用此插件创建Test等测试脚本，" +
            "此插件创建一切脚本 均带前缀以及关键词");
        GUILayout.Label("例: UIPanel AnimalControl WaeponKnapSack TimeManager 等。。。");
        GUILayout.Label("此脚本 创建属性变量 禁止使用a or B 命名方式 可以缩写 例如ClickBtn StartBtn 等");



        GUILayout.Space(20);
        #endregion
        if (GUILayout.Button("创建脚本"))
        {
            MyCreateScript(scriptType,scriptname);
        }
        GUILayout.Space(20);
        if (GUILayout.Button("添加字段")) {
            FieldType x = FieldType.Float;
            options.Add(x);
            targetlist.Add(default(string));
        }

        GUILayout.Label("添加字段暂不可用");

        if (GUILayout.Button("删除命令"))
        {
            options.RemoveAt(options.Count - 1);
            targetlist.RemoveAt(options.Count - 1);
        }

        scriptname = EditorGUILayout.TextField("脚本名称", scriptname);
        v2 = EditorGUILayout.BeginScrollView(v2, false, true, null);
        for (int i = 0; i < options.Count; i++) {
            options[i] = (FieldType)EditorGUILayout.EnumPopup("选项" + i, options[i]);
            targetlist[i] = EditorGUILayout.TextField("变量名称", targetlist[i]);
            switch (options[i])
            {
                case FieldType.Float:
                    
                    break;
                case FieldType.Int:

                    break;
                case FieldType.String:

                    break;
                default:
                    break;
            }
        }

        EditorGUILayout.EndScrollView();

    }

    /// <summary>
    /// 创建脚本
    /// </summary>
    /// <param name="scriptType"></param>
    private void MyCreateScript(ScriptCreateType scriptType,string csname)
    {
        //EditorApplication.applicationContentsPath + "/Resources/ScriptTemplates/81-C# Script-NewBehaviourScript.cs.txt"
        string name = scriptType.ToString();
        ProjectWindowUtilEx.CreateScriptUtil(Application.dataPath + "/Resources/AssetType/"+ name + ".txt",  name + csname+".cs");
    }
}

public class ProjectWindowUtilEx
{
    public static void CreateScriptUtil(string path, string templete)
    {
        MethodInfo method = typeof(ProjectWindowUtil).GetMethod("CreateScriptAsset",
            BindingFlags.Static | BindingFlags.NonPublic);
        if (method != null)
            method.Invoke(null, new object[] { path, templete });
    }
}