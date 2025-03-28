﻿using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Controls;
using KhazanData;
using UAssetAPI;

namespace Khazan_DataEditor.src
{
    public class DataFile
    {
        public string _FileName;
        public string _FilePath;
        public KhazanTableBase _FileData;
        public UAsset _UAsset;
        public string _Desc
        {
            get
            {
                if(MainWindow.s_CustomDescriptionConfig.TryGetValue(_FileName, out var customDesc))
                {
                    return customDesc;
                }
                //var mainWindow = System.Windows.Application.Current.MainWindow as MainWindow;
                if (MainWindow.s_DefaultDescriptionConfig.TryGetValue(_FileName, out var desc))
                {
                    return desc;
                }
                //var windows = Application.Current.Windows;
                return _desc;
            }
            set
            {
                _desc = value;
            }
        }
        private string _desc;
        public bool _IsShow = true;
        public bool _IsTop = false;
        public bool _IsDirty = false;
        public List<DataItem> _FileDataItemList;
        public PropertyInfo _ListPropertyInfo;
        public List<int> _IDList;
        public ListBoxItem _ListBoxItem;
        public DataItem _CurOpenItem = null;

        /// <summary>
        /// 
        /// </summary>
        public object Tag;

        /// <summary>
        /// 
        /// </summary>
        public bool CanOpen { set; get; } = true;

        public void LoadData()
        {
            var filePath = _FilePath;
            if (Tag is string path && File.Exists(path))
            {
                filePath = path;
            }
            if (!CanOpen)
                return;
            var (data, uassset) = Exporter.GetDataByFile(_FileName, filePath);
            if (data != null)
            {
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(_FileName);
                var uassetFileName = fileNameWithoutExtension.Split('_')[0];
                
                
                _FileData = data;
                _UAsset = uassset;
                CanOpen = false;
                _FileDataItemList = new List<DataItem>();
                _IDList = new List<int>();

                var type = data.GetType();
                // if (type.Name.StartsWith("TB"))
                {
                    //获取名为List的public 属性，并且判定类型是否为 RepeatedField<T>
                    var listProperty = type.GetProperty("Table");
                    if (listProperty != null)
                    {
                        _ListPropertyInfo = listProperty;
                        var list = listProperty.GetValue(data) as IList;
                        if (list != null)
                        {
                            foreach (var item in list)
                            {
                                var itemType = item.GetType();
                                var property = itemType.GetProperty("TIDX");
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("ID");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("DropId");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("ItemId");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("ExtentBattleId");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("SimpleStateID");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("MapId");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("Count");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("Group");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("GroupId");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("NpcId");
                                // }
                                // if (property == null)
                                // {
                                //     property = itemType.GetProperty("Rank");
                                // }
                                
                                if (property == null)
                                    continue;

                                DataItem dataItem = new DataItem();
                                var idValue = property.GetValue(item);
                                if (idValue is int id)
                                    dataItem._ID = id;
                                else
                                {
                                    dataItem._ID = System.Convert.ToInt32(idValue);
                                }

                                // dataItem._ID = property.GetValue(item) as int? ?? 0;
                                _IDList.Add(dataItem._ID);
                                dataItem._Data = item as KhazanDataBase;
                                dataItem._File = this;
                                _FileDataItemList.Add(dataItem);
                            }
                        }
                    }
                    //type.GetFields()
                }
            }
        }

        public int GetNewID()
        {
            if (_IDList != null && _IDList.Count > 0)
            {
                return _IDList.Max() + 1;
            }

            return 1000000;
        }

    }

}
