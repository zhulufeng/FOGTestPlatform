﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOGTestPlatform
{
    class ParameterClass
    {
    }
    class FilePara
    {
        public static string DataDirectory = null;
        public static string DataFileName = null;
        public static string BaseDirectory = System.AppDomain.CurrentDomain.BaseDirectory + @"TESTDATA\";
        public static string CurrentDirectory;
        public static string ConfigFilePath;
        public static string ConfigFileLoadPath; 
        public static string ClearDirectory = null;
        public static List<string> dataFileList = new List<string>();
    }
    class SerialParameter
    {
        public string comName = "COM1";
        public string baudRate = "38400";
        public string dataBit = "8";
        public string stopBit = "1";
        public string parityBit = "none";
        public bool serial_enable = true;
    }
    class SerialData
    {
        public List<byte> buffer = new List<byte>(4096);
        public UInt16 index = 0;
    }
    class TestCfgPara
    {
        public int numOftestChannels;
        public bool[] serialportEnable = new bool[7];
        public bool isLoadData = false;
        public bool isHighFreq = false;
        public bool isSaveHex = false;
        public bool isScaleFactorTest = false;
        public bool isDeadBandTest = false;
    }
 
    public class Fogdata
    {
        public int i_fdata;
        public int i_tdata;
        public byte[] arrayRCVData = new byte[10];
        public int Counter;
        public double d_fdata;
        public double d_tdata;
        public double d_fdata_1s;
        public double d_tdata_1s;
        public List<double> fdata_array = new List<double>();//用于平滑的列表,事后处理时候用于保存原始数据
        public List<double> tdata_array = new List<double>();//用于平滑的列表,事后处理时候用于保存原始数据
        public List<double> time_array = new List<double>();
        public List<double> fdata_1s_array = new List<double>();
        public List<double> fdata_deadband_1s_array = new List<double>();
        public List<double> tdata_1s_array = new List<double>();
        public List<double> fdata_smooth_array = new List<double>();
        public List<double> tdata_smooth_array = new List<double>();
        public List<double> time_smooth_array = new List<double>();
        public double ave_Fog_data;
        public double std_Fog_data;
        public double Fog_Bias_std;
        public double scaleFactor;
        public double Fog_Comped_data;
        public string FOGID;
        public string FOG_Channel;
        public string Fog_PortName;
        public List<byte> buffer = new List<byte>(4096);
        public bool zoomed_flag = false;

    }
    class TableData
    {
        public double table_rate;
        public double table_drate;
        public double table_angle;
        public byte[] arrayOriginData = new byte[13];
        public int Counter = 0;
        public int SF_Counter = 0;
        public int SF_Para_index = 0;
        
    }
    class TimePara
    {
        public int total_time = 0;
        public int dt;
        public int sampleFreq = 1000;
        public int drawCount = 0;
        public int testTimes = 0;
        public int sampleTime = 0;//转速平稳，采样时间 1 = 100ms
        public int switchRateTime = 0;//转速切换时间 1 = 100ms

        public List<double> drawIndexTime = new List<double>();
    }
    class ScaleFactorPara
    {
        public List<double> RatePara = new List<double>();
        public int paracount = 0;
        public int rateParaID = 1;

    }
    public class DeadBandPara
    {
        public double StartAgl;
        public double EndAgl;
        public double AglStep;
        public int StepTime;
        public double currentAgl;
        //public int DeadBandSampleTime = 0;//转速平稳，采样时间 1 = 100ms
        public int DeadBandswtichAngleTime = 500;//角度切换时间 1 = 100ms
        public int step_num = 0;
    }

}
