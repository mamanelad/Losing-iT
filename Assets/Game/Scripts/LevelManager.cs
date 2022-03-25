using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private BarricadeGenerator _barricadeGenerator;
    [SerializeField] private SpawnerScript _spawner;
    [SerializeField] private List<GameObject> _blocks1;
    [SerializeField] private List<GameObject> _blocks2;
    [SerializeField] private List<GameObject> _blocks3;
    [SerializeField] private List<GameObject> _blocks4;
    [SerializeField] private List<GameObject> _blocks5;
    [SerializeField] private List<GameObject> _blocks6;
    [SerializeField] private GameObject _inverter;

    private static LevelManager _shared;
    private int currentLevel;


    private void Awake()
    {
        _shared = this;
    }

    public static void ResetLevel()
    {
        _shared.currentLevel = 0;
        _shared._inverter.SetActive(false);
        CinemachineCamerasController.DisableCameraTilt();
    }

    public static void LoadNextLevel()
    {
        _shared.currentLevel += 1;
        switch (_shared.currentLevel)
        {
            case 1:
                Level1();
                break;
            case 2:
                Level2();
                break;
            case 3:
                Level3();
                break;
            case 4:
                Level4();
                break;
            case 5:
                Level5();
                break;
            default:
                Level5();
                break;
        }
    }

    private static void Level1()
    {
        _shared._spawner.tetrisBlocks = _shared._blocks1;
    }
    
    private static void Level2()
    {
        _shared._spawner.tetrisBlocks = _shared._blocks2;
        CinemachineCamerasController.SetCameraTransitionsDuration(29);
        CheckpointsGenerator.ChangeRadius(34f);
    }
    
    private static void Level3()
    {
        _shared._spawner.tetrisBlocks = _shared._blocks3;
        CinemachineCamerasController.ActivateCameraTilt();
        CheckpointsGenerator.ChangeRadius(40f);
    }
    
    private static void Level4()
    { 
        CinemachineCamerasController.SetCameraTransitionsDuration(27);
        _shared._spawner.tetrisBlocks = _shared._blocks4;
        _shared._inverter.SetActive(true);
    }
    
    private static void Level5()
    {
        _shared._spawner.tetrisBlocks = _shared._blocks5;
    }
}