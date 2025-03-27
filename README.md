# 卡赞配表编辑器

## 功能描述

### 解包PAK里 BBQ\Content\_Common\DataTable\Script 目录下的.uasset
可以将所有游戏解包出来的.uasset文件可视化展示

### .uasset编辑
可视化编辑 .uasset 配置文件 并保存成新文件

### 生成PAK
支持以文件夹拖拽的形式，将文件夹打包成游戏内可用的pak mod文件

假如修改后的data文件路径是 \BBQ\Content\_Common\DataTable\Script\xxx.uasset
那么在生成pak时，你需要在这个路径加上你的mod名文件夹，假如你mod命名为MyMod
完整路径为 MyMod\BBQ\Content\_Common\DataTable\Script\xxx.uasset
将 MyMod 文件夹拖放进生成pak格式的窗口内即可完成打包
PAK需要加_P 才能生效
例：MyMod_P.pak

### 备注 导入及导出
可以自己对 .uasset的数据进行备注，以便于标记 已经分析过的配表
支持导入他们配置好的备注文件，以便于更多的mod作者之间 协作分析全量配表

## 使用方法

打开软件后，菜单栏 文件 -> 打开Data目录。 选择一个含有.uasset文件（一般使用 FModel解包出来的 BBQ\Content\_Common\DataTable\Script文件夹）的文件夹打开即可

从做到右分块 依次为 uasset文件列表， 单个uasset文件内的数据列表， 单个数据内的 每个字段数据显示

.uasset每个数据内 个别字段是uasset嵌套形式。目前以 打开新窗体的方式进行嵌套数据编辑

其余上述功能均在 菜单栏 文件 内

## 注意事项

1. 这个工具只是uasset 配置文件的编辑器，并不支持打开其余FModel解开的uasset文件
2. 本工具使用.net 8.0，如果需要使用请安装.net8.0库
3. 如果有大佬觉得工具写的不好，可以自行clone进行修改。二次发布标注作者引用即可
4. 如果有对工具有任何疑问，或者有大佬想要一起协作开发，可以联系作者：[禽兽-云轩](https://space.bilibili.com/8729996)

## 后续更新计划

1. 支持多文件修改保存(已完成)
2. 支持Undo Redo
3. dirty 的data文件标记（已完成）
4. data pak的解包及merge （解包完成）
5. 新增数据（已完成）


# Khazan_DataEditor

## Feature Description

### Unpack .uasset Files from PAK
Visualize all unpacked .uasset files from the `BBQ\Content\_Common\DataTable\Script` directory within PAK files.

### Edit .uasset Files
Visually edit .uasset configuration files and save them as new files.

### Generate PAK
Supports drag-and-drop folder packaging to generate game-compatible PAK mod files.  
If the modified data file path is `\BBQ\Content\_Common\DataTable\Script\xxx.uasset`, you must prepend your mod name folder to this path when generating the PAK. For example, if your mod is named `MyMod`, the full path should be:  
`MyMod\BBQ\Content\_Common\DataTable\Script\xxx.uasset`  
Drag the `MyMod` folder into the PAK generation window to complete packaging.  
**Note**: PAK files must have the `_P` suffix to take effect.  
Example: `MyMod_P.pak`

### Notes Import/Export
Add custom notes to .uasset data to mark analyzed configuration tables.  
Supports importing pre-configured note files to facilitate collaboration among mod authors for full-scale table analysis.

## Usage

1. Open the software and navigate to **File -> Open Data Directory**. Select a folder containing .uasset files (typically the `BBQ\Content\_Common\DataTable\Script` folder unpacked via FModel).  
2. The interface is divided into three sections from left to right:  
   - List of .uasset files  
   - Data entries within a selected .uasset file  
   - Field details of a selected data entry  
3. Some fields in .uasset files contain nested data. These can be edited by opening a new window.  
4. All features mentioned above are accessible under the **File** menu.

## Notes

1. This tool is **only** an editor for .uasset configuration files and does not support other .uasset files unpacked by FModel.  
2. Requires **.NET 8.0 Runtime**. Install it before use.  
3. Feel free to fork and modify this tool. Please credit the original author if redistributing.  
4. For questions or collaboration, contact the author: **[QinShou-YunXuan](https://space.bilibili.com/8729996)**.  

## Future Updates

1. Support multi-file editing and saving (Completed)  
2. Undo/Redo functionality  
3. Dirty file marking (Completed)  
4. PAK unpacking and merging (Unpacking completed)  
5. Add new data entries (Completed)  