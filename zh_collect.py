import os
import re
from xml.etree import ElementTree as ET
from xml.dom import minidom

def find_xaml_files(base_dir):
    """查找当前目录及子目录下的所有XAML文件"""
    xaml_files = []
    for root, _, files in os.walk(base_dir):
        for file in files:
            if file.lower().endswith('.xaml'):
                xaml_files.append(os.path.join(root, file))
    return xaml_files

def extract_chinese_strings(content):
    """使用正则表达式提取中文文本"""
    pattern = re.compile(r'[\u4e00-\u9fff]+')
    return pattern.findall(content)

def create_resx_file(translations, output_dir):
    """创建符合WPF规范的RESX文件"""
    root = ET.Element('root', 
        xmlns_xsi="http://www.w3.org/2001/XMLSchema-instance",
        xmlns_xsd="http://www.w3.org/2001/XMLSchema",
        xmlns="http://www.w3.org/1999/xlink"
    )
    
    # 添加必要的resheader
    headers = [
        ('resmimetype', 'text/microsoft-resx'),
        ('version', '2.0'),
        ('reader', 'System.Resources.ResXResourceReader...'),
        ('writer', 'System.Resources.ResXResourceWriter...')
    ]
    for name, value in headers:
        header = ET.SubElement(root, 'resheader', name=name)
        ET.SubElement(header, 'value').text = value

    # 添加中文条目
    for idx, text in enumerate(translations, 1):
        data = ET.SubElement(root, 'data', 
            name=f'Text_{idx}',
            xml_space="preserve"
        )
        ET.SubElement(data, 'value').text = text

    # 美化XML输出
    xml_str = minidom.parseString(ET.tostring(root)).toprettyxml()
    output_path = os.path.join(output_dir, 'Resource.ZH-CN.resx')
    with open(output_path, 'w', encoding='utf-8') as f:
        f.write(xml_str)

def main():
    # 查找并处理所有XAML文件
    target_dir = os.path.abspath(input("请输入要扫描的目录路径："))
    xaml_files = find_xaml_files(target_dir)
    all_chinese = []
    
    for file in xaml_files:
        with open(file, 'r', encoding='utf-8') as f:
            content = f.read()
            print(f.name)
            all_chinese.extend(extract_chinese_strings(content))
    
    # 去除重复并生成RESX
    create_resx_file(list(set(all_chinese)), target_dir)

if __name__ == '__main__':
    main()